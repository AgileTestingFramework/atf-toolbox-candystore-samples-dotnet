@FormApplication
Feature: Calculate
	In order to avoid silly mistakes
	As a math idiot
	I want to add numbers
	So that I can get the correct total

@FormApplication
Scenario: frm Add 50 and 70 numbers
	Given I have entered fifty "50" into the calculator
	And I have pressed the add sign
	And I have entered seventy "70" into the calculator
	When I press the equal sign
	Then the result should be one hundred twenty "120" on the screen
	And the running paper should show the full calculation of "50 + 70 = 120"

@FormApplication
Scenario Outline: frm Add 2 numbers
	Given I have enetered a first number <firstNumber>
	And I have pressed the add sign
	And I have entered a second number <secondNumber>
	When I press the equal sign
	Then the sum should be <sum>
	And the running paper should show <paperOutput>

	Examples:
		| firstNumber | secondNumber | sum | paperOutput      |
		| 1           | 2            | 3   | "1 + 2 = 3"      |
		| 3           | 4            | 7   | "3 + 4 = 7"      |
		| 56          | 789          | 845 | "56 + 789 = 845" |
