#This module contains web utils for parsing stock info
import re
import urllib.request
import InputUtils
from StockEntity import StockEntity
from StockMarketTypes import StockMarketType
from html.parser import HTMLParser
from lxml import etree
from decimal import Decimal

stockURLTemplate = 'https://gupiao.baidu.com/stock/[_STOCK_ID_].html'
szStockPattern = r'^00[0-9]{4}$'
shStockPattern = r'^60[0-9]{4}$'
hkStockPattern = r'^0[0-9]{4}$'

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
		page = etree.HTML(response)
		entity = StockEntity()
		nameNode = page.xpath('//a[@class=\'bets-name\']')
		dateNode = page.xpath('//span[@class=\'state f-up\']')
		closePriceNode = page.xpath('//strong[@class=\'_close\']')
		detailNode = page.xpath('//div[@class=\'bets-content\']//div')
		entity.lastTradingPrice = Decimal(closePriceNode[0].text)
		entity.stockName = nameNode[0].text
		entity.updateDate = dateNode[0].text

		for ele in detailNode[0]:
			if(len(ele) > 1):
				if(ele[0].text == '市盈率'):
					entity.peRatio = Decimal(ele[1].text)
				elif(ele[0].text == '每股收益'):
					entity.profitPerShareLatest = Decimal(ele[1].text)

		return entity 

	else:
		InputUtils.readEnterForReturn('股票代码不存在！请查准后再试一次！')
		return None