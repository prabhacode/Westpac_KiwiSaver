
# Automated-Test-Solution
# Westpac Automation Practical Assessment

## Project Description and Purpose 
The purpose of this project is to create an Automated Test Solution for the given User Stories in the requirements documentation.
## Features
The project is all about creating an automated test solution to test the Kiwisaver functionality on the Westpac's Web application.
## URL used 
http://www.westpac.co.nz/
## Navigation Flow 
KiwiSaver > KiwiSaver Calculators > Click here to get started button under (Westpac KiwiSaver Scheme Retirement Calculator)
## Solution Specification
### Language Used 
C# .NET
### Automation Tool / Framework 
Selenium WebDriver
### Other tools used 
SpecFlow - Behaviour Driven Development

Microsoft Excel - Excel Data Reader
### Prerequisite / Setup 
Visual Studio, Chrome Browser or Firefox
### Source Control Repository 
[GitHub] https://github.com/prabhacode/Westpac_KiwiSaver.git
## Solution Execution
### Steps Before Execution:
:white_check_mark: Download or clone the GitHub repository mentioned above 

:white_check_mark: Open the solution file (KiwiSaver.sln) from the downloaded folder

:white_check_mark: Make sure that you have installed the Visual Studio before opening the solution file.

:white_check_mark: If you would like to run the tests on the Firefox Browser, go to the Config folder and double-click on the KiwiSaverResources.resx file and change the value of the Browser to 1. Note that the configuration is already set to Chrome Browser by default.

### How to execute:

:white_check_mark: Open the solution file - KiwiSaver.sln from the downloded folder

:white_check_mark: Open the Test Explorer window from the tool bar Test -> Test Explorer

:white_check_mark: To execute the automation script, Right-click on the project and click Run

:white_check_mark: You will be able to view the browser actions with respect to the automated test scripts.

:white_check_mark: Test pass / fail results can be viewed on the Test explorer

:white_check_mark: If you would like to change the test data, Navigate to the downloaded project folder -> KiwiSaver > KiwiSaver > ExcelData > TestData.xlsx and change
the values, save it and run the tests again.


### Test Results and Analysis:

The automated test solution is prepared and executed as per the requirements specification. The test results are in accordance with the requirements except,

:white_check_mark: The first user story to check the infomation icon on the current age when clicked, the message on the requirements states "This calculator has an age limit of 64 years old as you need to be under the age of 65 to join KiwiSaver". But the actual result is "This calculator has an age limit of 18 to 64 years old." Hence the test got failed - which is not aligned with the requirements.

:white_check_mark: The run-time test output screenshots can be viewed on path: KiwiSaver > KiwiSaver > TestReports > Screenshot
