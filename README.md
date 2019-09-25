# QAHomework

C#, Selenium, NUnit and SpecFlow :)

#### Steps to run the QAHomework tests

##### Prerequisites

- .NET Core 2.2+ with Dotnet CLI (https://dotnet.microsoft.com/download/dotnet-core/2.2)
- Visual Studio 2015+ (https://visualstudio.microsoft.com/downloads/)
- If Windows, chromedriver.exe mapping on the PATH Environment Variable

##### Run using Visual Studio

- Clone or download the project from github
- Open the file QAHomework.sln in QAHomework folder with Visual Studio
- Wait the Restoring Packages
- Go to Test Explorer/Unit Tests window and click on 'Run all' button

##### Run using Terminal/CMD
	
- Clone or download the project from github
- Navigate to QAHomework folder and run the follow commands:

```sh
dotnet build QAHomework
dotnet test QAHomework --logger trx
```

#### Test Results

- Total tests: 13
- Passed: 12
- Failed: 1
- Total time: 13.4579 Seconds

##### Failed test infos

```sh
### 1 ###
Related Req. ID: REQ_UI_12

Steps to reproduce:

 Given an user access Form Page
-> done: FormPageSteps.GivenAnUserAccessFormPage() (0.1s)
Then Docler Holding logo is present
-> done: BaseSteps.ThenDoclerHoldingLogoIsPresent() (0.0s)
And title should be "UI Testing Site"
-> done: BaseSteps.ThenTitleShouldBe("UI Testing Site") (0.0s)
Given an user enter the São Paulo
-> done: FormPageSteps.GivenAnUserEnterThe("São Paulo") (0.2s)
When I click on Go button
-> done: FormPageSteps.WhenIClickOnGoButton() (0.4s)
Then a message "Hello São Paulo!" is displayed
-> error:   Expected string length 16 but was 21. Strings differ at index 7.
Expected: "Hello São Paulo!"
But was:  "Hello S%C3%A3o+Paulo!"
```

**********************************************************************
