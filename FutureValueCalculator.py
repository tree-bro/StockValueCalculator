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
#buySellRate=readDecimalParam("请输入交易印花税(decimal, default 0.01): \n",0.01)
buySellRate=Decimal("0.01")

#Annually profit per share
profit=InputUtils.readDecimalParam("请输入当前每股年利润(decimal): \n",0)

#Can regard as corp existance time, or the total investment time
loopLimit=InputUtils.readIntParam("请输入考虑的存续期(int, default 30): \n",30)

#the corp loan interest is about %7 for real estate industry
interest=InputUtils.readDecimalParam("请输入折现率(decimal, default 0.07): \n","0.07")

#the growth here uses the cpi to represent "no growth"
growth=InputUtils.readDecimalParam("请输入利润的年增长率(decimal, default 0.01): \n","0.01")

#Two stage of growth model. HSG time and growth rate
highSpeedGrowthLimit=InputUtils.readIntParam("请输入预计高速增长的年份(int, default 5):\n", 5)
highSpeedGrowth=InputUtils.readDecimalParam("请输入高速增长的年增长率(decimal, default 0):\n",0)

#The dispatched cash
annuallyCashRatio=InputUtils.readDecimalParam("请输入年化分红派息的比例(decimal, default 0.2): \n","0.2")
#cash payment tax rate is about %1 for less than 1 year, and %0.5 for more than 1 year
#taxRate=readDecimalParam("请输入分红派息的所得税\n(decimal, default 0.1): \n",0.1)
taxRate=Decimal("0.005")

#Following are for calculating stock share holding fee. ONLY HK bank has such charge
annuallyFee=0
volume=1000

#The depression loop years for the whole industry
depressionLoop=InputUtils.readIntParam("请输入预计的衰退周期(int, default 7): \n", 7)
#depressionLoop=7
depressionLossRate=InputUtils.readDecimalParam("请输入衰退期的利润损失率(decimal, default 0.5): \n", "0.5")

#This is to calculate the trade charge fee for buy / sell
buySellLoop=InputUtils.readIntParam("请输入持股的买卖周期(int, default 5): \n", 5)

#Before proceed, print out input params
print ("\n================")
print ("当前市价=" +  str(marketPrice))
print ("交易印花税="+ str(buySellRate))
print ("每股净利润="+ str(profit))
print ("存续年份="+ str(loopLimit))
print ("折现率=" + str(interest))
print ("增长率=" + str(growth))
print ("高速增长率="+str(highSpeedGrowth))
print ("高速增长的年份=" + str(highSpeedGrowthLimit))
print ("分红派息比例=" + str(annuallyCashRatio))
print ("分红所得税率=" + str(taxRate))
print ("年化持股费用="+str(annuallyFee))
print ("购买股数="+str(volume))
print ("衰退期="+str(depressionLoop))
print ("衰退期损失率="+str(depressionLossRate))
print ("买卖周期="+str(buySellLoop))
print ("================")

result =Decimal(0)
tempInterest = Decimal(1)
annuallyCash = Decimal(0)
taxPaid = Decimal(0)
resultForSell =Decimal(0)
feePaid=Decimal(0)
buyTax=marketPrice*buySellRate
sellTax=Decimal(0)
tempGrowth=Decimal(1)

for idx in range(1,loopLimit):
	#calculate the risk interest rate for current year
    tempInterest = tempInterest * Decimal(1/(1+interest))
	
	#If HSG is larger than 0, and current year has not reach the upper limit for HSG, then calculate for HSG
    if (highSpeedGrowth>0 and highSpeedGrowthLimit >= idx):
        tempGrowth = tempGrowth*Decimal(1+highSpeedGrowth)
    else:
        tempGrowth = tempGrowth*Decimal(1+growth)
			
    if (idx % depressionLoop > 0):
        annuallyCash = annuallyCash + tempInterest*profit*tempGrowth*annuallyCashRatio*(1-taxRate)
        taxPaid = taxPaid + tempInterest*profit*tempGrowth*annuallyCashRatio*taxRate
        result = result + tempInterest*profit*tempGrowth*(1-annuallyCashRatio)
        resultForSell =resultForSell+profit*tempGrowth*(1-annuallyCashRatio)
        feePaid = feePaid+Decimal(annuallyFee/volume)*tempInterest
    else:
        annuallyCash = annuallyCash + tempInterest*profit*tempGrowth*annuallyCashRatio*(1-taxRate)*(1-depressionLossRate)
        taxPaid = taxPaid + tempInterest*profit*tempGrowth*annuallyCashRatio*taxRate*(1-depressionLossRate)
        result = result + tempInterest*profit*tempGrowth*(1-annuallyCashRatio)*(1-depressionLossRate)
        resultForSell =resultForSell+profit*tempGrowth*(1-annuallyCashRatio)*(1-depressionLossRate)
        feePaid = feePaid+Decimal(annuallyFee/volume)*tempInterest
        
        
    if(buySellLoop > 0 and idx%buySellLoop==0):
        buyTax=buyTax+marketPrice*Decimal(1+idx*0.02)*buySellRate*tempInterest
        sellTax=sellTax+marketPrice*Decimal(1+idx*0.02)*buySellRate*tempInterest

sellTax=sellTax+resultForSell*tempInterest*buySellRate

print ("\n<<<<<<<<<<<<<<")
print ("除息后该股现值为: " + str(round(result,5)))
print ("总分红派息为: " + str(round(annuallyCash,5))) 
print ("总所得税为: " + str(round(taxPaid,5)))
print ("总持股费用为: "+str(round(feePaid,5)))
print ("买入交易税: " + str(round(buyTax,5)))
print ("卖出交易税: " + str(round(sellTax,5)))
print ("该股总现值为 :" + str(round(result- buyTax - sellTax + annuallyCash - feePaid,5)))
print ("\n该股市价/现值比例约为 " + str(round(marketPrice/(result- buyTax - sellTax + annuallyCash - feePaid),5) *100)+"%")
