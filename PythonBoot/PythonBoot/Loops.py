# -*- coding: utf-8 -*-
"""
Created on Tue Jul 11 15:55:38 2022

"""

"""Python has two types of loops: for and while."""

"""There are four ways to write a for loop in python.
    For better understanding, I will also write the equivalent c++/c# loop"""


# Method 1:    c++ -> for(int i = 0; i < 10: i++)
for i in range(0, 10):
    print(i, sep=" ",end=" ")

print('End of first for variant')

# The range function has an optional parameter: that is the step. In i++
# we have i + 1. But we can customize it too. This customization is the
# third parameter for the range function. Additionally, the range function
# does include the lower bound but does not include the upper bound (10) under any
# circumstance.

for i in range(0, 10, 2):       # for(int i =0; i < 10; i = i + 2)
    print(i, sep=" ",end=" ")

print('End of second for variant')

# Method 3:      C# -> foreach(var i in obj)
my_list = ['one', 'two', 'three']           # this is list, will cover in list.py
for i in my_list:
    print(i, sep=" ",end=" ")

print('End of third for variant')

# Method 4:     This method is unique to python.
"""The enumerate function in python returns the list elements indexed. This
    implementation will make it clear."""

for i,j in enumerate(my_list):
    print(str(i) + " " + str(j))      #just converted i and j to strings 

print('End of last for variant')

# While Loop in python
while True:
    # do something
    break
    
    #break, continue are keywords to control loop. Pass is a function to end the function.




    