@ImageAutomation
Feature: MSWord
	In order to validate image automation
	As an automated tester
	I want to be start MSWord by locating its start icon
	So that I can see image recognition working

Scenario: win MSWord Startup
	Given I have referenced the ATFFramework
	And I have captured a screen shot of the image I will be locating
	When I click on the image
	Then MSWord will open
