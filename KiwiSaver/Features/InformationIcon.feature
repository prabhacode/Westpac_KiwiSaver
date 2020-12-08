Feature: KiwiSaver Information Icon
As a Product Owner 
I want that while using the KiwiSaver Retirement Calculator all fields in the calculator have got the information icon present
So that 
The user is able to get a clear understanding of what needs to be entered in the field.

Background:
	Given I am on the Westpac Home page
	And I click on KiwiSaver menu
	And I click on KiwiSaver Calculator button
	And I click on Click here to get started button

@automation
Scenario: Click information icon besides Current age
	When I click on information icon besides Current age
	Then The message should display below the current age field