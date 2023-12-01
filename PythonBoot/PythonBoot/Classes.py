# -*- coding: utf-8 -*-
"""
Created on Tue Jul 11 16:08:21 2022

"""
"""A class in python is a way to package objects. All members in classes are
    public.
    
    Members function of classes are affixed with the def-keyword and the
    first parameter is always self.
    
    __init__ is the constructor method. Python has a policy of one constructor
    per class. No multiple constructors are allowed(normally)."""

"""Sample class to explain the classes in python"""
class MyClass:
    
    def __init__(self, first_para, second_para):
        self.first_para = first_para
        self.second_para = second_para
        """This is the way to assign variables in python. No pre-declaration
           of instance variables are required."""
    
    def print_params(self):
        print(self.first_para + " and "+ self.second_para)
    
    """Static methods are declared by the following way. We affix @staticmethod before
    the fucntion and on the next line, comes the def func...."""
    
    @staticmethod
    def StaticMethod():
        print('Hello World in static method')

class_obj = MyClass('D section', '22 session')
class_obj.print_params()

MyClass.StaticMethod()