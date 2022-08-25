# _Bakery_

https://github.com/lilia-S/TDD_Bakery.git

#### By Liliia Kryvelova

 
#### _The Bakery application is taking user input and calculates the price for Bread and Pastry. For working with data from user input in the program was implemented Interface. The main idea is using the same method in multiple classes that can be achieved by using Interface._

## Technologies Used

* C# .NET5
* VS Code
* coverlet.collector
* NUnit3TestAdapter
* NUnit
* Microsoft.NET.Test.Sdk

## Description

_The Bakery application is creating two new objects. Object Bread and object Pastry. These two objects are using the same method that is declared in Interface (the method is taking the amount and price of items for further calculation). Interface in C# is like the class it also has methods, properties, indexers, and events. The main benefit for us is that declared method is going to be accessible for all classes that are implemented for our Main class._

## Setup/Installation Requirements

_The main idea for creating this project is practicing to work with Test Driven Development. Looking through all instruments I decided to use the NUnit Test framework in VS Code. There is an easy way to setuping the project on a computer. Also, it is an open-source developer platform for building a different types of applications. How was Setting up the Development Environment:_

Open GitBash or other console application;
  1. Run  
  `Dotnet --version`  
  We are going to use 5.0.408.
  2. Create the work folder  
  `mkdir Bakery`
  3. Go into the folder and create C# Console project  
  `cd Bakery`  
  `dotnet new console -o Bakery`
  4. Create the NUnit Test Project(Unit Test Assembly)  
  `dotnet new nunit -o Bakery.Tests`
  5. Go to the Test Project directory and add a reference to the Console Project  
  `cd Bakery.Tests`  
  `dotnet add reference ../Bakery/Bakery.csproj`
  6. For ensuring that the project is installed in the correct way Run  
  `dotnet test`
  
When .NET CLI created our first project, we will see the passed test on our display. So, it will indicate that our programming environment created a simple Unit test method. In the last step, we will have separated folders Bakery and Bakery. Tests with by default divided files and references.  
At this point, there is an amazing feature, by running the command: `dotnet watch test --nologo`  
This command will watch for our file changes and run the test automatically each time we save the changes in our files.  
It is an easy way for creating all necessary folders and dividing our program logic.  

How to clone the working project on a computer:
* For cloning: use the button Clone -> from the repository.
* Copy the clone command(SSH format or HTTPS). From a terminal on your local computer, use the command `cd` to find the directory where you want to clone this repository.
* Type the command `git clone <URL copied in previous step>`. If you clone successfully, a new sub-directory appears on your local computer.
* For working with the project, after cloning the project you need to run in the cmd `dotnet build`, for running tests `dotnet test`

_Testing the app functionality on the problematic test suites and main functionality:_
_Bread class (basic functionality for Bread-> Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves cost $10, and three loaves cost $10.): All test for main functionality located in (BreadPastryTests.cs); By default, we allow User to input only values greater or equal than 0;
The application should return the total cost;_

* What if User input 0, the cost should be 0$ -> BreadChoose_GetZeroCost0_true();
* What if User input 1 - Bread, the cost shoud be 5$ -> BreadChoose_GetOneCost5_true();
* What if User input 2 - Bread, the cost should be 10$ -> BreadChoose_GetTwoCost10_true();
* What if User input 3 - Bread, the cost should be 10$ -> BreadChoose_GetThreeCost10_true();
* What if User input 4 - Bread, the cost should be 15$ -> BreadChoose_GetFourCost15_true();
* What if User input 11 - Bread, the cost should be 40$ -> BreadChoose_GetElevenCost40_true();
* What if User input 100 - Bread, the cost should be 335$ -> BreadChoose_Get100Cost335_true();

_Pastry class (basic functionality for Pastry-> Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.):_
* What if User input 1 - Pastry, the cost should be 2$ -> PastryChoose_Get1Cost2_true();
* What if User input 2 - Pastry, the cost should be 4$ -> PastryChoose_Get2Cost4_true();
* What if User input 3 - Pastry, the cost should be 5$ -> PastryChoose_Get3Cost5_true();
* What if User input 4 - Pastry, the cost should be 7$ -> PastryChoose_Get4Cost7_true();
* What if User input 5 - Pastry, the cost should be 9$ -> PastryChoose_Get5Cost9_true();
* What if User input 6 - Pastry, the cost should be 10$ -> PastryChoose_Get6Cost10_true();
* What if User input 15 - Pastry, the cost should be 25$ -> PastryChoose_Get15Cost25_true();
* What if User input 0 - Pastry, the cost should be 0$ -> PastryChoose_Get0Cost0_true();

## Known Bugs
* There are possibilities to insert the 0, but the return could be unexpected
* There are possibilities to insert the negative numbers, but the return could be unexpected

## License

Copyright (c) _07/03/2022_ _author Liliia Kryvelova_
