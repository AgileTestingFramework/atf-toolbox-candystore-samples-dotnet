@Converter
Feature: TemperatureConversion
	As a Canandian
	I want to convert from celcius to fahrenheit
	So that I know how hot or cold it really is

@Converter
Scenario Outline: Frm2 Convert from Celcius to Fahrenheit
	Given I have entered temperature conversion
	And I have entered <celcius> into the converter
	When I press equals
	Then the <fahrenheit> conversion should be displayed

	Examples:
		| celcius | fahrenheit |
		| 16      | 60.8|
		| 28      | 82  |
		| -40     | -40 |

