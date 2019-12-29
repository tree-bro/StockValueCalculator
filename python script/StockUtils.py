#This module contains web utils for parsing stock info
import re
import urllib.request
import requests
import InputUtils
import ssl
import json
from StockEntity import StockEntity
from StockMarketTypes import StockMarketType
from html.parser import HTMLParser
from decimal import Decimal

#stockURLTemplate = 'https://gupiao.baidu.com/stock/[_STOCK_ID_].html'
stockURLTemplate = 'https://gupiao.baidu.com/api/stocks/stockbets?from=h5&os_ver=0&cuid=xxx&vv=2.2&format=json&stock_code=[_STOCK_ID_]'
szStockPattern = r'^00[0-9]{4}$'
shStockPattern = r'^60[0-9]{4}$'
hkStockPattern = r'^0[0-9]{4}$'

ctx = ssl.create_default_context()
ctx.check_hostname = False
ctx.verify_mode = ssl.CERT_NONE

user_agent = 'Mozilla/5.0 (Linux; Android 9; MIX 2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Mobile Safari/537.36'
accept = 'text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3'
accept_encoding = 'gzip, deflate, br'
accept_language = 'zh-CN,zh;q=0.9,en;q=0.8'
sec_fetch_mode = 'navigate'


head = {}
head['User-Agent'] = user_agent
head['Accept'] = accept
#head['Accept-Encoding'] = accept_encoding
#head['Accept-Language'] = accept_language
head['Sec-Fetch-Mode'] = sec_fetch_mode

class ResponseHtmlParser(HTMLParser):
 
	parseNameNode = False
	parseDateNode = False
	parseClosePriceNode = False
	parseDetailNode = False
	parsePERatioNode = False
	parseProfitPerSharingNode = False
	peRatioContentCount = 0
	nameNodeText = ''
	dateNodeText = ''
	closePriceNodeText = ''
	peRatioNodeText = ''
	profitPerSharingNodeText = ''

	def handle_starttag(self, tag, attrs):
		if (tag == 'a'):
			for attr in attrs:
				if (attr[0] == 'class' and attr[1] == 'bets-name'):
					#Encountered name node
					self.parseNameNode = True
		elif (tag == 'span'):
			for attr in attrs:
				if (attr[0] == 'class' and attr[1] == 'state f-up'):
					#Encountered date node
					self.parseDateNode = True
		elif (tag == 'strong'):
			for attr in attrs:
				if (attr[0] == 'class' and attr[1] == '_close'):
					#Encountered close node
					self.parseClosePriceNode = True
		elif (tag == 'div'):
			for attr in attrs:
				if (attr[0] == 'class' and attr[1] == 'bets-content'):
					self.parseDetailNode = True

	def handle_endtag(self,tag):
		if (tag == 'a' and self.parseNameNode):
			#Encountered name node
			self.parseNameNode = False
		elif (tag == 'span' and self.parseDateNode):
			#Encountered date node
			self.parseDateNode = False
		elif (tag == 'strong' and self.parseClosePriceNode):
			#Encountered close node
			self.parseClosePriceNode = False
		elif (tag == 'div' and self.parseDetailNode):
			#Encountered detail node
			self.parseDetailNode = False

	def handle_data(self,data):
		if(self.parseNameNode):
			self.nameNodeText += data
		elif(self.parseDateNode):
			self.dateNodeText += data
		elif(self.parseClosePriceNode):
			self.closePriceNodeText += data
		elif(self.parseDetailNode):
			if (data == '市盈率'):
				self.parsePERatioNode = True
			elif (data == '每股收益'):
				self.parseProfitPerSharingNode = True
			elif (self.parsePERatioNode):
				if (self.peRatioContentCount < 1):
					self.peRatioContentCount += 1
				else:
					self.peRatioNodeText += data
					self.parsePERatioNode = False
			elif (self.parseProfitPerSharingNode):
				self.profitPerSharingNodeText += data
				self.parseProfitPerSharingNode = False

def constructURL(stockID):
	if(re.compile(szStockPattern).match(stockID)):
		return stockURLTemplate.replace('[_STOCK_ID_]', 'sz' + stockID)
	elif(re.compile(shStockPattern).match(stockID)):
		return stockURLTemplate.replace('[_STOCK_ID_]', 'sh' + stockID)
	elif(re.compile(hkStockPattern).match(stockID)):
		return stockURLTemplate.replace('[_STOCK_ID_]', 'hk' + stockID)
	else:
		return ''

def parseFromServer(stockID):
	stockURL = constructURL(stockID)

	if (stockURL != ''):
		#req = urllib.request.Request(stockURL,headers = head)
		req = requests.get(url = stockURL,headers = head)
		response = req.text
		jsonObject = json.loads(response)
		
		#print (jsonObject)
		json_close = jsonObject.get('snapShot').get('close')
		json_stockName = jsonObject.get('snapShot').get('stockBasic').get('stockName')
		json_date = str(jsonObject.get('snapShot').get('date'))
		json_peRatio = str(jsonObject.get('snapShot').get('peratio'))
		json_profitPerShare = str(jsonObject.get('snapShot').get('perShareEarn'))
		
		entity = StockEntity()
		entity.lastTradingPrice = Decimal(json_close)
		print ('[公司名称='+json_stockName+']')
		print ('[资料更新日期='+json_date+']')
		print ('[市盈率=' + json_peRatio+']')
		print ('[每股盈利=' + json_profitPerShare +']')
		entity.stockName = json_stockName
		entity.updateDate = json_date
		if (json_peRatio != 'NoneType' and json_peRatio != 'None'):
			entity.peRatio = Decimal(json_peRatio)
		if (json_profitPerShare != 'NoneType' and json_profitPerShare != 'None'):
			entity.profitPerShareLatest = Decimal(json_profitPerShare)
		return entity
		'''
		try:
			parser = ResponseHtmlParser()
			parser.feed(response)

			entity = StockEntity()
			entity.lastTradingPrice = Decimal(parser.closePriceNodeText)
			print ('[公司名称='+parser.nameNodeText+']')
			print ('[资料更新日期='+parser.dateNodeText+']')
			print ('[市盈率=' + parser.peRatioNodeText+']')
			print ('[每股盈利=' + parser.profitPerSharingNodeText+']')
			entity.stockName = parser.nameNodeText
			entity.updateDate = parser.dateNodeText
			if (parser.peRatioNodeText != ''):
				entity.peRatio = Decimal(parser.peRatioNodeText)
			if (parser.profitPerSharingNodeText != ''):
				entity.profitPerShareLatest = Decimal(parser.profitPerSharingNodeText)

			return entity
		except:
			print ('ERROR! 提取公司资料出错!')
			print ('URL=')
			print (stockURL,req.url)
			print ('RESPONSE=')
			print (response)
			return None
		'''

	else:
		InputUtils.readEnterForReturn('股票代码不存在！请查准后再试一次！')
		return None
