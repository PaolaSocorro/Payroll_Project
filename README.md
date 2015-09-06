Payroll
=================

Group Project for C# class. 

•  Database - made by Zixing Qiao. 
•	
•	ReportClass, Paystub report, and w_report derived class - made by Qianqun Xu. 
•	
•	Payroll Class, User Interface, Forms, Payroll_Form code, splashcreen, graphics - made by Paola Socorro.
•	
•	Note(s): Small changes made to Database to correct spelling errors, Originally also made code to read and gather data from datafiles, code was replaced by the use of a database. - both by PSocorro.
•	Project database located:  Payroll_Project04\Project4\Resources
***

This program should calculate the salary per month of a company's employees. It calculates both for employees paid per hour, and for those with a fixed salary regardless of hours. 
The program deducts the cost for medical and dental benefits, life insurance, 401k account, and FSA. 
It also takes into account taxes like, social security tax (10%), federal income tax(15%) and state income tax (5%).
for each employee the program also creates monthly pay stubs. as well as w-2's at the end of the year.
a database is used to keep record of the employees  and their individual information like id number, name, pay per hour or salary and benefits. Etc. 
The database has a master table for employee data, and a separate table to keep monthly data of hours worked. 
Hours worked by salaried employees are for record keeping only. Their net pay is calculated, based on the gross monthly salary. 
medical and dental benefits are deducted first, before tax deductions. Tax is based on the subsequent amount. 

All commits available at GitHub

https://github.com/ZenRumi/Payroll_Project04

Limitations: 

Program cannot place reports in a separate window for user view before printing. 
All forms go to print preview at once.
program cannot create paystub per employee, one at a time. All are created at once, one after the other.
Program cannot update, change database in anyway.
cannot add employee, remove employee
cannot create reports for quarters.
program does not take into account the occasional switch of idnumber's position in month files. (possible error noticed but had no time to implement a solution. My idea was to search the array first and place values in the proper place according to id number position.) 

