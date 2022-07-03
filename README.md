# _{Bakery}_
https://github.com/liliia87/TDD_Bakery.git

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
2. Create the work folder -> mkdir Bakery;
3. Go into the folder and creating C# Console project 
-> cd Bakery;

-> dotnet new console -o Bakery;

4. Create the NUnit Test Project(Unit Test Assembly)
-> dotnet new nunit -o Bakery.Tests;

5. Go to the Test Project directory and add reference to the Console Project
-> cd Bakery.Tests;
-> dotnet add referance ../Bakery/Bakery.csproj;

6. For ensuring that the project is instaled in correct way Run -> dotnet test;

When .NET CLI created our firs project, we will see the passed test on our display. So, it will indicate that our programm environment created a simple Unit test method. on the last step we wil have separated folders Bakery and Bakery.Tests with by default divided files and references.

It is the easy way for creating all necessary folders and dividing our program logic.

How to clone the working project on computer:
_*For clonning: use button Clone -> from repository.
_*Copy the clone command(SSH format or HTTPS). From a terminal on your local computer, use command "cd" to find the directory where you want to clone this repository.
_*Type the command ($ git clone HTTPs). If you clone successfully , a new sub-directory appears on your local computer.
_*For working with project, install "npm module" inside the working folder. (npm install): after successful install, run command (npm run build) for building project on your own computer after it type (npm run start) for star your project.}_

## License

Copyright (c) _07/03/2022_ _author Liliia Kryvelova(s)_
