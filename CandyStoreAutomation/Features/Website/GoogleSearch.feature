@MobileApplication
Feature: Google
	In order to navigate the internet
	As a web user
	I want to navigate the internet
	So that I can find items I am needing information about

Scenario: mobile Search for automation information
	Given I have opened a browser to "https://www.google.com"
	When I search for "Agile Testing Framework"
	Then I expect my search results to contain "Agile Testing Framework (ATF)"
