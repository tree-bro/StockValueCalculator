#This module (class) is to group the input related methods
from decimal import Decimal
import datetime

def readDecimalParam(printMsg,defaultValue):
    x = input(printMsg)

    if(x is None or x == ""):
        return Decimal(defaultValue)
    else:
        return Decimal(x)

def readIntParam(printMsg,defaultValue):
    x = input(printMsg)

    if(x is None or x == ""):
        return defaultValue
    else:
        return int(x)

def readStringParam(printMsg):
    x = input(printMsg)

    return x
    
def readEnterForTime(printMsg):
    x = input(printMsg)
    return datetime.datetime.now()

def readEnterForReturn(printMsg):
    x = input(printMsg)