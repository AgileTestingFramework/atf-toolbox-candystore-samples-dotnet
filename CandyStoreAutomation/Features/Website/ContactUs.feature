@WebApplication
Feature: Contact Us
	In order to provide feedback and questions to the owners of the Candy Store
	As a CandyStoreWebsiteBrowser
	I want to provide feedback about the candy store
	So that I can influence the products and services the candy store offers

Scenario: web Submit more than maximum (25) characters allowed for first name
	Given I have entered to the Candy Store website and navigated to the Contact Us page
	And I have entered my first name "Kristen8901234567890123456"
	When I complete my entry
	Then I expect my first name not to have exceeded the maximum length of 25