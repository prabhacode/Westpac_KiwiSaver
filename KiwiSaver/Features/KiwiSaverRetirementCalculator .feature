Feature: KiwiSaverRetirementCalculator
As a Product Owner 
I want that the KiwiSaver Retirement Calculator users are able to calculate what their KiwiSaver projected balance would be at retirement
So that 
The users are able to plan their investments better.

Background:
	Given I am on the Westpac Home page
	And I click on KiwiSaver menu
	And I click on KiwiSaver Calculator button
	And I click on Click here to get started button

@automation
Scenario: Calculate KiwiSaver projected balance at retirement for Employed
	When I add KiwiSaver details for Employed
	Then The button View your KiwiSaver retirement projection should be visible
	When I click on View your KiwiSaver retirement projection button
	Then The projected balance at retirement should be displayed

@automation
Scenario: Calculate KiwiSaver projected balance at retirement for Self-Employed
	When I add KiwiSaver details for Self-Employed
	Then The button View your KiwiSaver retirement projection should be visible
	When I click on View your KiwiSaver retirement projection button
	Then The projected balance at retirement should be displayed

@automation
Scenario: Calculate KiwiSaver projected balance at retirement for Not Employed
	When I add KiwiSaver details for Not Employed
	Then The button View your KiwiSaver retirement projection should be visible
	When I click on View your KiwiSaver retirement projection button
	Then The projected balance at retirement should be displayed