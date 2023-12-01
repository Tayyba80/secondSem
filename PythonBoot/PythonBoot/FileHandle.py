# -*- coding: utf-8 -*-
"""
Created on Tue Jul 11 16:19:27 2022

"""

my_list = []

# There are several ways to perform file handling in python. However, we will consider
# the most easiest way, that is to use the 'with' keyword. What happens in the with 
# keyword is that it automatically closes the file, even in the case of exceptions.


# with keyword has the following structure.

with open('sample.txt', 'r') as file_var:         # 'r' means read mode.
    my_list = file_var.read()

# and that's it. The with keyword will make sure to close the file itself.
print(my_list)

with open('sample.txt', 'w') as file_var:         # 'w' means write mode.
    for i in my_list:
        file_var.writelines(i)