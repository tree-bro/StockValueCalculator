#This module contains web utils for parsing stock info
import re
import urllib.request
import InputUtils
from StockEntity import StockEntity
from StockMarketTypes import StockMarketType
from html.parser import HTMLParser
from decimal import Decimal

stockURLTemplate = 'https://gupiao.baidu.com/stock/[_STOCK_ID_].html'
szStockPattern = r'^00[0-9]{4}$'
shStockPattern = r'^60[0-9]{4}$'
hkStockPattern = r'^0[0-9]{4}$'

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
		response_data = urllib.request.urlopen(stockURL)
		response = response_data.read().decode('utf-8')
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

	else:
		InputUtils.readEnterForReturn('股票代码不存在！请查准后再试一次！')
		return None