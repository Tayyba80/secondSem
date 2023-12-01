# -*- coding: utf-8 -*-
"""
Created on Tue Jul 11 15:41:40 2022

"""

"""Python is an interpreted language.
    What we mean by an interpreted language is that there 
    is no compiler involved whatsoever. The code is picked up
    line-by-line, and then executed.
    
    Python works on basis of significant indentation, i.e, the spacing
    from the left side. No brackets whatsoever are required in python."""
    
# Let's start with Hello World and the print statement.

print('Hello World in Python')  #the print function automatically adds a \n at the end

# to remove the \n and make two prints appear side by side, we use sep= and end=
print('This is first print =>',sep=' ', end=' ')
print('And this is second print')   #No sep= and end= mean the next print will be on next line


print('And this is third print.')

"""Speaking of which: Python doesn't have a char datatype. It 
    only has a string datatype, which has commas ' ' associated with it.
    """