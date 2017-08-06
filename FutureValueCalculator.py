#-*-coding:utf8;-*-
#qpy:2
#qpy:console
import InputUtils
from decimal import Decimal

print ("\n\n>>>>>>>>>>>>>>>>")
print ("This is FVC for python3 version\n")
print ("当计算股票市值时，应当考虑以合理的数值输入下列所有参数***\n\n")

#Current market price for the product
marketPrice=InputUtils.readDecimalParam("请输入市场价(decimal): \n",0)

#Market trade charge fee. In reality, the buy sell rate is about %0.9
#tradingTaxRate=readDecimalParam("请输入交易印花税(decimal, default 0.01): \n",0.01)
tradingTaxRate=Decimal("0.01")

#Annually profit per share
profitPerShare=InputUtils.readDecimalParam("请输入当前每股年利润(decimal): \n",0)

#Can regard as company existance period, or the total investment time
companyDuration=InputUtils.readIntParam("请输入考虑的存续期(int, default 30): \n",30)

#the corp loan interest rate is about %7 for real estate industry
discountRate=InputUtils.readDecimalParam("请输入折现率(decimal, default 0.07): \n","0.07")

#the growth here uses the cpi to represent "no growth"
growth=InputUtils.readDecimalParam("请输入利润的年增长率(decimal, default 0.01): \n","0.01")

#Two stage of growth model. HSG time and growth rate
highSpeedGrowthDuration=InputUtils.readIntParam("请输入预计高速增长的年份(int, default 5):\n", 5)
highSpeedGrowthRate=InputUtils.readDecimalParam("请输入高速增长的年增长率(decimal, default 0):\n",0)

#The dispatched cash rate, or the profit sharing rate
profitSharingRate=InputUtils.readDecimalParam("请输入年化分红派息的比例(decimal, default 0.2): \n","0.2")
#profit sharing tax rate is about %1 for less than 1 year, and %0.5 for more than 1 year
#profitSharingTaxRate=readDecimalParam("请输入分红派息的所得税\n(decimal, default 0.1): \n",0.1)
profitSharingTaxRate=Decimal("0.005")

#Following are for calculating stock share holding fee. ONLY HK bank has such charge
annuallyFee=0
volume=1000

#The depression loop years for the whole industry
depressionFrequency=InputUtils.readIntParam("请输入预计的衰退周期(int, default 7): \n", 7)
depressionLossRate=InputUtils.readDecimalParam("请输入衰退期的利润损失率(decimal, default 0.5): \n", "0.5")

#This is to calculate the trade charge fee for buy / sell
stockHeldDuration=InputUtils.readIntParam("请输入持股的买卖周期(int, default 5): \n", 5)

#Before proceed, print out input params
print ("\n================")
print ("当前市价=" +  str(marketPrice))
print ("交易印花税="+ str(tradingTaxRate))
print ("每股净利润="+ str(profitPerShare))
print ("存续年份="+ str(companyDuration))
print ("折现率=" + str(discountRate))
print ("增长率=" + str(growth))
print ("高速增长率="+str(highSpeedGrowthRate))
print ("高速增长的年份=" + str(highSpeedGrowthDuration))
print ("分红派息比例=" + str(profitSharingRate))
print ("分红所得税率=" + str(profitSharingTaxRate))
print ("年化持股费用="+str(annuallyFee))
print ("购买股数="+str(volume))
print ("衰退期="+str(depressionFrequency))
print ("衰退期损失率="+str(depressionLossRate))
print ("买卖周期="+str(stockHeldDuration))
print ("================")

result =Decimal(0)
currentInterest = Decimal(1)
totalProfitSharing = Decimal(0)
totalTradingTaxPaid = Decimal(0)
resultForSell =Decimal(0)
totalStockHeldFee=Decimal(0)
totalBuyTax=marketPrice*tradingTaxRate
totalSellTax=Decimal(0)
currentGrowthRate=Decimal(1)

for idx in range(1,companyDuration):
	#calculate the risk interest rate for current year
    currentInterest = currentInterest * Decimal(1/(1+discountRate))
	
	#If HSG is larger than 0, and current year has not reach the upper limit for HSG, then calculate for HSG
    if (highSpeedGrowthRate>0 and highSpeedGrowthDuration >= idx):
        currentGrowthRate = currentGrowthRate*Decimal(1+highSpeedGrowthRate)
    else:
        currentGrowthRate = currentGrowthRate*Decimal(1+growth)
			
    if (idx % depressionFrequency > 0):
        totalProfitSharing = totalProfitSharing + currentInterest*profitPerShare*currentGrowthRate*profitSharingRate*(1-profitSharingTaxRate)
        totalTradingTaxPaid = totalTradingTaxPaid + currentInterest*profitPerShare*currentGrowthRate*profitSharingRate*profitSharingTaxRate
        result = result + currentInterest*profitPerShare*currentGrowthRate*(1-profitSharingRate)
        resultForSell =resultForSell+profitPerShare*currentGrowthRate*(1-profitSharingRate)
        totalStockHeldFee = totalStockHeldFee+Decimal(annuallyFee/volume)*currentInterest
    else:
        totalProfitSharing = totalProfitSharing + currentInterest*profitPerShare*currentGrowthRate*profitSharingRate*(1-profitSharingTaxRate)*(1-depressionLossRate)
        totalTradingTaxPaid = totalTradingTaxPaid + currentInterest*profitPerShare*currentGrowthRate*profitSharingRate*profitSharingTaxRate*(1-depressionLossRate)
        result = result + currentInterest*profitPerShare*currentGrowthRate*(1-profitSharingRate)*(1-depressionLossRate)
        resultForSell =resultForSell+profitPerShare*currentGrowthRate*(1-profitSharingRate)*(1-depressionLossRate)
        totalStockHeldFee = totalStockHeldFee+Decimal(annuallyFee/volume)*currentInterest
        
        
    if(stockHeldDuration > 0 and idx%stockHeldDuration==0):
        totalBuyTax=totalBuyTax+marketPrice*Decimal(1+idx*0.02)*tradingTaxRate*currentInterest
        totalSellTax=totalSellTax+marketPrice*Decimal(1+idx*0.02)*tradingTaxRate*currentInterest

totalSellTax=totalSellTax+resultForSell*currentInterest*tradingTaxRate

print ("\n<<<<<<<<<<<<<<")
print ("除息后该股现值为: " + str(round(result,5)))
print ("总分红派息为: " + str(round(totalProfitSharing,5))) 
print ("总所得税为: " + str(round(totalTradingTaxPaid,5)))
print ("总持股费用为: "+str(round(totalStockHeldFee,5)))
print ("买入交易税: " + str(round(totalBuyTax,5)))
print ("卖出交易税: " + str(round(totalSellTax,5)))
print ("该股总现值为 :" + str(round(result- totalBuyTax - totalSellTax + totalProfitSharing - totalStockHeldFee,5)))
print ("\n该股市价/现值比例约为 " + str(round(marketPrice/(result- totalBuyTax - totalSellTax + totalProfitSharing - totalStockHeldFee),5) *100)+"%")
