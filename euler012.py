# Project Euler #12 in Python... again
# What is the value of the first triangle number to have over five hundred divisors?

from math import *

def triangleNums():
    i = 0
    last = 0
    while True:
        i += 1
        last += i
        yield last

def divisors(n):
    s = floor(sqrt(n))
    divs = 0
    for i in range(1, s + 1):
        if n % i == 0:
            divs += 2
    if s == sqrt(n):
        divs -= 1
    return divs
        
def test():
    for num in triangleNums():
        if divisors(num) > 500:
            return num

print(test())
