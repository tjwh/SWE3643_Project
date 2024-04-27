# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator
Contained here is a web-based calculator built using C# and Blazor. NUnit is used for unit tests and
Playwright is used for end-to-end testing.

## Table of Contents
- [Environment](#environment)
- [Executing the Web Application](#executing-the-web-application)
- [Executing Unit Tests](#executing-unit-tests)
- [Reviewing Unit Test Coverage](#reviewing-unit-test-coverage)
- [Executing End-To-End Tests](#executing-end-to-end-tests)
- [Final Video Presentation](#final-video-presentation)

## Team Members
tjwh

Tyler Hood

## Architecture
This project uses C# and Blazor and loosely follows the MVC software pattern. 

All calculator operations and
logic are performed inside of the Calculator project, and the front-end HTML, CSS, and Blazor components are
inside the CalculatorWebServerApp project. 

NUnit was used to create unit tests for the calculator operations
and are stored within the CalculatorUnitTests project. Finally, Playwright was used to create end-to-end 
tests for the server and UI components.

![System Architecture Diagram](https://i.imgur.com/Cc82Ltk.png)

## Environment
This is a cross-platform application and should work in Windows 10+, Mac OSx Ventura+, and various Linux 
environments. Note that the application has only been carefully tested in Windows 10 and Linux.

To prepare your environment to execute this application:
* Install the [latest .NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) for your operating system.
* Install the [latest version of git](https://git-scm.com/download/win) for your operating system.
* Open a terminal and navigate to your desired location to clone the repository to.

`cd <your desired directory> ... (E.g. C:\Users\user\example)`
  
* Clone the repository.

`git clone https://github.com/tjwh/SWE3643_Project.git`

To configure Playwright for end-to-end testing:
* Open up a terminal and navigate to the repository's main project folder.

`cd <directory>\SWE3643_Project`

* Build the project.

`dotnet build`

* Navigate to the repository's CalculatorPlaywrightTests folder.

`cd CalculatorPlaywrightTests`

* Install the required Playwright browsers (for Windows).

`pwsh bin/Debug/net8.0/playwright.ps1 install`

* __NOTE: If you do not have Powershell installed, install it using the following command:__

`winget install --id Microsoft.Powershell --source winget`

## Executing the Web Application
To execute the web application: 

* Open up a terminal and navigate to the repository's CalculatorWebServerApp folder.

`cd <directory>\SWE3643_Project\CalculatorWebServerApp`

* Run the application.

`dotnet run`

* Upon a successful run, your console should output the following:
```
$ dotnet run
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5116
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
```

* Navigate to `http://localhost:5116` in your browser.

## Executing Unit Tests
To execute the unit tests:

* Open up a terminal and navigate to the CalculatorUnitTests folder.

`cd <directory>\SWE3643_Project\CalculatorUnitTests`

* Run the tests.

`dotnet test`

* Upon a successful run, your console should output the following:
```
$ dotnet test
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:    20, Skipped:     0, Total:    20,
Duration: 97 ms - CalculatorUnitTests.dll (net8.0)
```

## Reviewing Unit Test Coverage
![Coverage Statistics](https://i.imgur.com/d1CNSxQ.png)

## Executing End-To-End Tests
* With the web server app already running, open up a terminal and navigate to the CalculatorPlaywrightTests folder.

`cd <directory>\SWE3643_Project\CalculatorPlaywrightTests`

* Run the tests.

`dotnet test`

* Upon a successful run, your console should output the following:
```
$ dotnet test
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5,
Duration: 1 s - CalculatorPlaywrightTests.dll (net8.0)
```

* __NOTE: For some reason, one of the End to End tests may fail when running it for the first time. Run them again and they all should pass.__

## Final Video Presentation
[![Video Link](https://i.imgur.com/LsmM3Se.png)](https://www.youtube.com/watch?v=k0-N-1a8jpw)
