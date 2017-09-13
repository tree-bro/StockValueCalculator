#-*-coding:utf8;-*-
#qpy:2
#qpy:console
import InputUtils
import StockUtils
from decimal import Decimal
from StockCalculator import Calculator
from StockEntity import StockEntity

#This is the start of the main function
print ("\n\n>>>>>>>>>>>>>>>>")
print ("This is FVC for python3 version\n")
print ("当计算股票市值时，应当考虑以合理的数值输入下列所有参数***\n")

#Check operation type
cal = Calculator()
operationType = InputUtils.readIntParam("请输入操作模式(1=手动输入模式,2=从服务器读取公司部分资料,默认为2): \n", 2)
if (operationType != 1 and operationType != 2):
	InputUtils.readEnterForReturn("模式输入有误，按任意键结束")
elif (operationType == 1):
	#Current market price for the product
	cal.marketPrice=InputUtils.readDecimalParam("请输入市场价(decimal): \n",0)
	#Annually profit per share
	cal.profitPerShare=InputUtils.readDecimalParam("请输入当前每股年利润(decimal): \n",0)
	cal.readStockInfo()
	cal.calculateStockInfo()
elif (operationType == 2):
	stockID = InputUtils.readStringParam('请输入股票代码：\n')
	entity = StockUtils.parseFromServer(stockID)

	if (entity is not None):
		entity.recalculateProfitPerShare()
		cal.marketPrice = entity.lastTradingPrice
		cal.profitPerShare = entity.profitPerShareAnnually
		cal.readStockInfo()
		cal.calculateStockInfo()


