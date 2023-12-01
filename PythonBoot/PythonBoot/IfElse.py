# -*- coding: utf-8 -*-
"""
Created on Tue Jul 11 15:47:19 2022

"""

"""The datatype in python is dynamic. That is, we dont need to 
    assign datatypes at compile time rather the compiler, at runtime,
    picks up the datatype and does the job"""

N = "abc"
print(type(N))  #<class 'str'>

N = 10
print(type(N))  #<class 'int'>

if N == 10:
    print('Inside first if')
    if N == 11 - 1:
        print('Nested If')
    elif N == 12 - 2:           #elif is basically else-if, but in python :)
        print('Else if')  
else:
    print('Else')   # Won't run tho

"""If, elif and else are the three python statements used for control flow"""
# && == 'and' keyword
# || keyword == 'or' keyword
# ! operator remains the same