# _{Bakery}_
https://github.com/lilia-S/TDD_Bakery.git

#### By _**{Liliia Kryvelova}**_

#### _{The Bakery application is taking user input and calculate price for Bread and Pastry. For working with data form user input in program were implemented Interaface. The main idea is using the same method in multiple classes that can be achived by using Interface. }_

## Technologies Used

* _C# .NET5
* _VS Code
* _coverlet.collector
* _NUnit3TestAdapter
* _NUnit
* _Microsoft.NET.Test.Sdk

## Description
_{The Bakery application is creating two new object. Object Bread and object Pastry. This two objects are  using the same method that is declarated in Interface(method is taking amount and price of items for further calculation). Interface in C# is like the class it also has methods, properties, indexers, and events. The main benefit for us is that declarated methor is going to be accessible for all classes that are implemented for our Main class.}_


## Setup/Installation Requirements

_{The main idea for creating this project is practicing to work with Test Driven Development. Loking throught all instruments I decidet to use NUnit Test framework in VS Code. There is easy way for setuping the project on computer. Also, it is open-source developer platform for building different type of applications.
How was Setting up the Development Environment:

Open GitBash or other console application;

1. Run -> dotnet --version; We are going to use 5.0.408.
2. Create the work folder 
-> mkdir Bakery

3. Go into the folder and creating C# Console project 
-> cd Bakery

-> dotnet new console -o Bakery

4. Create the NUnit Test Project(Unit Test Assembly)
-> dotnet new nunit -o Bakery.Tests

5. Go to the Test Project directory and add reference to the Console Project
-> cd Bakery.Tests;
-> dotnet add referance ../Bakery/Bakery.csproj

6. For ensuring that the project is instaled in correct way Run -> dotnet test

When .NET CLI created our firs project, we will see the passed test on our display. So, it will indicate that our programm environment created a simple Unit test method. on the last step we wil have separated folders Bakery and Bakery.Tests with by default divided files and references.

At this point. there is an amazing feature, by running the command:
-> dotnet watch test --nologo

This command will watch for our file changes and run the test automatically each time we save the changes in our files.


It is the easy way for creating all necessary folders and dividing our program logic.

How to clone the working project on computer:
_*For clonning: use button Clone -> from repository.
_*Copy the clone command(SSH format or HTTPS). From a terminal on your local computer, use command "cd" to find the directory where you want to clone this repository.
_*Type the command ($ git clone HTTPs). If you clone successfully , a new sub-directory appears on your local computer.
_*For working with project, after clonint the project you need to run in the cmd ->(dotnet build) -> for runing the tests -> (dotnet test);}_

## Testing the app functionality on the problematic test suites and main functionality:

Bread class (basic functionality for Bread-> Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.):
All test for main functionality located in (BreadPastryTests.cs);
By default, we allow User to input only values greater or equal than 0; 

The application should return the total cost;
1. What if User input 0, The cost should be 0$ -> BreadChoose_GetZeroCost0_true();
2. What if User input 1 - Bread, The cost shoud be 5$ -> BreadChoose_GetOneCost5_true();
3. What if User input 2 - Bread, The cost should be 10$ -> BreadChoose_GetTwoCost10_true();
4. What if User input 3 - Bread, The cost should be 10$ -> BreadChoose_GetThreeCost10_true();
5. What if User input 4 -Bread, The cost should be 15$ -> BreadChoose_GetFourCost15_true();
6. What if User input 11 - Bread, The cost should be 40$ -> BreadChoose_GetElevenCost40_true();
7. What if User input 100 - Bread, the cost should be 335$ -> BreadChoose_Get100Cost335_true();

Pastry class (basic functionality for Pastry-> Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.):
1. What if User input 1- Pastry, The cost should be 2$ -> PastryChoose_Get1Cost2_true();
2. What if User input 2 - Pastry, The cost should be 4$ -> PastryChoose_Get2Cost4_true();
3. What if User input 3 - Pastry, The cost should be 5$ -> PastryChoose_Get3Cost5_true();
4. What if User input 4 - Pastry, The cost should be 7$ -> PastryChoose_Get4Cost7_true();
5. What if User input 5 - Pastry, The cost should be 9$ -> PastryChoose_Get5Cost9_true();
6. What if User input 6 - Pastry, The cost should be 10$ -> PastryChoose_Get6Cost10_true();
7. What if User input 15 - Pastry, The cost should be 25$ -> PastryChoose_Get15Cost25_true();
8. What if User input 0 - Pastry, The cost should be 0$ -> PastryChoose_Get0Cost0_true();

## Known Bugs

* _There are possibilities to insert the 0, but return could be unexpected_
* _There are possibilities to insert the negative numbers, but return could be unexpected_

## License

Copyright (c) _07/03/2022_ _author Liliia Kryvelova(s)_
