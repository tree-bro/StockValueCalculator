import InputUtils
from decimal import Decimal

#Define calculator class
class Calculator:
	marketPrice = Decimal(0)
	profitPerShare = Decimal(0)
	companyDuration = Decimal(0)
	discountRate = Decimal(0)
	growth = Decimal(0)
	highSpeedGrowthDuration = Decimal(0)
	highSpeedGrowthRate = Decimal(0)
	profitSharingRate = Decimal(0)
	depressionFrequency = Decimal(0)
	depressionLossRate = Decimal(0)
	stockHeldDuration = Decimal(0)
	#Market trade charge fee. In reality, the buy sell rate is about %0.9
	#tradingTaxRate=readDecimalParam("请输入交易印花税(decimal, default 0.01): \n",0.01)
	tradingTaxRate=Decimal("1")/100
	#Following are for calculating stock share holding fee. ONLY HK bank has such charge
	annuallyFee=0
	volume=1000
	#profit sharing tax rate is about %1 for less than 1 year, and %0.5 for more than 1 year
	#profitSharingTaxRate=readDecimalParam("请输入分红派息的所得税\n(decimal, default 0.1): \n",0.1)
	profitSharingTaxRate=Decimal("0.5") / 100

	def readStockInfo(self):
		#Can regard as company existance period, or the total investment time
		self.companyDuration=InputUtils.readIntParam("请输入考虑的存续期(int, default 30): \n",50)
		#the corp loan interest rate is about %7 for real estate industry
		self.discountRate=InputUtils.readDecimalParam("请输入折现率(decimal, default 7%): \n","7.0") / 100
		#the growth here uses the cpi to represent "no growth"
		self.growth=InputUtils.readDecimalParam("请输入利润的年增长率(decimal, default 1%): \n","1.0") / 100
		#Two stage of growth model. HSG time and growth rate
		self.highSpeedGrowthDuration=InputUtils.readIntParam("请输入预计高速增长的年份(int, default 5):\n", 5)
		self.highSpeedGrowthRate=InputUtils.readDecimalParam("请输入高速增长的年增长率(decimal, default 0%):\n",0) / 100
		#The dispatched cash rate, or the profit sharing rate
		self.profitSharingRate=InputUtils.readDecimalParam("请输入年化分红派息的比例(decimal, default 20%): \n","20.0") / 100
		#The depression loop years for the whole industry
		self.depressionFrequency=InputUtils.readIntParam("请输入预计的衰退周期(int, default 7): \n", 5)
		self.depressionLossRate=InputUtils.readDecimalParam("请输入衰退期的利润损失率(decimal, default 90%): \n", "99.0") / 100
		#This is to calculate the trade charge fee for buy / sell
		self.stockHeldDuration=InputUtils.readIntParam("请输入持股的买卖周期(int, default 10): \n", 10)

	def calculateStockInfo(self):
		#Before proceed, print out input params
		print ("\n================")
		print ("当前市价=" +  str(self.marketPrice))
		print ("交易印花税="+ str(self.tradingTaxRate * 100) + "%")
		print ("每股净利润="+ str(self.profitPerShare))
		print ("存续年份="+ str(self.companyDuration))
		print ("折现率=" + str(self.discountRate * 100) + "%")
		print ("增长率=" + str(self.growth * 100) + "%")
		print ("高速增长率="+str(self.highSpeedGrowthRate * 100) + "%")
		print ("高速增长的年份=" + str(self.highSpeedGrowthDuration))
		print ("分红派息比例=" + str(self.profitSharingRate * 100) + "%")
		print ("分红所得税率=" + str(self.profitSharingTaxRate * 100) + "%")
		print ("年化持股费用="+str(self.annuallyFee))
		print ("购买股数="+str(self.volume))
		print ("衰退期="+str(self.depressionFrequency))
		print ("衰退期损失率="+str(self.depressionLossRate * 100) + "%")
		print ("买卖周期="+str(self.stockHeldDuration))
		print ("================")

		result =Decimal(0)
		currentInterest = Decimal(1)
		totalProfitSharing = Decimal(0)
		totalTradingTaxPaid = Decimal(0)
		resultForSell =Decimal(0)
		totalStockHeldFee=Decimal(0)
		totalBuyTax=self.marketPrice*self.tradingTaxRate
		totalSellTax=Decimal(0)
		currentGrowthRate=Decimal(1)

		for idx in range(1,self.companyDuration):
			#calculate the risk interest rate for current year
		    currentInterest = currentInterest * Decimal(1 / (1 + self.discountRate))
			
			#If HSG is larger than 0, and current year has not reach the upper limit for HSG, then calculate for HSG
		    if (self.highSpeedGrowthRate > 0 and self.highSpeedGrowthDuration >= idx):
		        currentGrowthRate = currentGrowthRate*Decimal(1 + self.highSpeedGrowthRate)
		    else:
		        currentGrowthRate = currentGrowthRate*Decimal(1 + self.growth)
					
		    if (idx % self.depressionFrequency > 0):
		        totalProfitSharing = totalProfitSharing + currentInterest*self.profitPerShare*currentGrowthRate*self.profitSharingRate*(1-self.profitSharingTaxRate)
		        totalTradingTaxPaid = totalTradingTaxPaid + currentInterest*self.profitPerShare*currentGrowthRate*self.profitSharingRate*self.profitSharingTaxRate
		        result = result + currentInterest*self.profitPerShare*currentGrowthRate*(1-self.profitSharingRate)
		        resultForSell =resultForSell+self.profitPerShare*currentGrowthRate*(1-self.profitSharingRate)
		        totalStockHeldFee = totalStockHeldFee+Decimal(self.annuallyFee/self.volume)*currentInterest
		    else:
		        totalProfitSharing = totalProfitSharing + currentInterest*self.profitPerShare*currentGrowthRate*self.profitSharingRate*(1-self.profitSharingTaxRate)*(1-self.depressionLossRate)
		        totalTradingTaxPaid = totalTradingTaxPaid + currentInterest*self.profitPerShare*currentGrowthRate*self.profitSharingRate*self.profitSharingTaxRate*(1-self.depressionLossRate)
		        result = result + currentInterest*self.profitPerShare*currentGrowthRate*(1-self.profitSharingRate)*(1-self.depressionLossRate)
		        resultForSell =resultForSell+self.profitPerShare*currentGrowthRate*(1-self.profitSharingRate)*(1-self.depressionLossRate)
		        totalStockHeldFee = totalStockHeldFee+Decimal(self.annuallyFee/self.volume)*currentInterest
		        
		        
		    if(self.stockHeldDuration > 0 and idx%self.stockHeldDuration==0):
		        totalBuyTax=totalBuyTax+self.marketPrice*Decimal(1+idx*0.02)*self.tradingTaxRate*currentInterest
		        totalSellTax=totalSellTax+self.marketPrice*Decimal(1+idx*0.02)*self.tradingTaxRate*currentInterest

		totalSellTax=totalSellTax+resultForSell*currentInterest*self.tradingTaxRate

		print ("\n<<<<<<<<<<<<<<")
		print ("除息后该股现值为: " + str(round(result,5)))
		print ("总分红派息为: " + str(round(totalProfitSharing,5))) 
		print ("总所得税为: " + str(round(totalTradingTaxPaid,5)))
		print ("总持股费用为: "+str(round(totalStockHeldFee,5)))
		print ("买入交易税: " + str(round(totalBuyTax,5)))
		print ("卖出交易税: " + str(round(totalSellTax,5)))
		print ("该股总现值为 :" + str(round(result- totalBuyTax - totalSellTax + totalProfitSharing - totalStockHeldFee,5)))
		print ("\n该股市价/现值比例约为 " + str(round(self.marketPrice/(result- totalBuyTax - totalSellTax + totalProfitSharing - totalStockHeldFee),5) *100)+"%")