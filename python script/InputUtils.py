#This module (class) is to group the input related methods

from decimal import Decimal
import datetime

def readDecimalParam(pringMsg,defaultValue):
    x = input(pringMsg)

    if(x is None or x == ""):
        return Decimal(defaultValue)
    else:
        return Decimal(x)

def readIntParam(pringMsg,defaultValue):
    x = input(pringMsg)

    if(x is None or x == ""):
        return defaultValue
    else:
        return int(x)
        
def readEnterForTime(printMsg):
    x = input(printMsg)
    return datetime.datetime.now()