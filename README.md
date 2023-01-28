# FiguresCalculator
###
This is the test case made for MindBox.   
It represents a class library that calculates simple characteristics of various figures. For the current moment it provides area for a triangle by its sides and a round by its radius. It also has a bool method to determine if the triangle is right.  
All of the library figures are inherited from the class "Figure" which implements interface IFigure.  
Class Figure has a virtual method overrided in each figure's class.  
To add a new figure you can add the new class and inherit it from "Figure" and provide an override method to calculate your figure's area along with extra methods for the exact figure.  
Unit tests are provided for each figure class using Fluent Assertions. 
