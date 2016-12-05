Feature: Getting the weather forecast
	In order to get weather
	As person who has to go outside sometimes
	I want to be told the weather so i know what to wear

Scenario: Get forecast for manually added location in Celcius
	Given I opened the app
	When I have entered "Amsterdam" as the location
	When I set the Imperial switch to Off
	When I press the Get Weather button
	Then the weather for "Amsterdam" should be shown in "Celsius"

Scenario: Get forecast for manually added location in Fahrenheit
	Given I opened the app
	When I have entered "Amsterdam" as the location
	When I press the Get Weather button
	Then the weather for "Amsterdam" should be shown in "Fahrenheit"

Scenario: Get forecast for GPS location in Celcius
	Given I opened the app
	When I Set the Use GPS switch to On
	When I set the Imperial switch to Off
	When I press the Get Weather button
	Then the weather for "Amsterdam" should be shown in "Fahrenheit"

Scenario: Get forecast for GPS location in Fahrenheit
	Given I opened the app
	When I Set the Use GPS switch to On
	When I press the Get Weather button
	Then the weather for "Amsterdam" should be shown in "Fahrenheit"	