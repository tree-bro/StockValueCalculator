#This is the object for storing parsed stock info
import datetime
from decimal import Decimal

class StockEntity:
	stockName = ''
	updateDate = ''
	lastTradingPrice = Decimal(0)
	peRatio = Decimal(0)
	profitPerShareAnnually = Decimal(0)
	profitPerShareLatest = Decimal(0)

	def recalculateProfitPerShare(self):
		currentDate = datetime.date.today()
		yearBegin = datetime.date(currentDate.year,1,1)
		dateDelta = currentDate - yearBegin
		if (self.peRatio > Decimal(0)):
			self.profitPerShareAnnually = round(self.lastTradingPrice/self.peRatio * Decimal(365) / Decimal(dateDelta.days), 5)
		elif (self.profitPerShareLatest > Decimal(0)):
			self.profitPerShareAnnually = round(self.profitPerShareLatest * Decimal(365) / Decimal(dateDelta.days), 5)
