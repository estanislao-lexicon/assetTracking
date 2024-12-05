# Asset Tracking with database and Entity Framework Core

This project is the start of an Asset Tracking database. 
Asset Tracking is a way to keep track of the company assets, like Laptops, Stationary computers, phones and so on... 
- [X] All assets have an end of life which for simplicity reasons is 3 years. 
- [X] All assets needs to be stored in database using Entity Framework Core. 

## Level 1

- [X] Create a console app that have the following classes and objects: 

Laptop Computers 
- MacBook 
- Asus 
- Lenovo 

Mobile Phones 
- Iphone 
- Samsung 
- Nokia 

- [X] You will need to create the appropriate fields, constructors and properties for each object, like purchase date, price, model name etc. 
- [X] **All assets needs to be stored in database using Entity Framework Core with Create and Read functionality.**

## Level 2

Create a program to create a list of assets (inputs) where the final result is to write the following to the console: 
- [ ] Sorted list with Class as primary (computers first, then phones) 
- [ ] Then sorted by purchase date 
- [X] Mark any item *RED* if purchase date is less than 3 months away from 3 years. 
- [ ] Your application should handle FULL CRUD.

## Level 3

Add offices to the model: 

- [ ] You should be able to place items in 3 different offices around the world which will use the appropriate currency for that country. 
- [ ] You should be able to input values in dollars and convert them to each currency (based on today's currency charts).

When you write the list to the console: 
- [ ] Sorted first by office 
- [ ] Then Purchase date 
- [X] Items *Red* if date less than 3 months away from 3 years 
- [X] Items *Yellow* if date less than 6 months away from 3 years 
- [ ] Each item should have currency according to country 
- [ ] Your application should handle FULL CRUD. 
- [ ] Your application should have some reporting features (?)