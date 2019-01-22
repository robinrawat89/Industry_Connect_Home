Feature: TimeAndMaterial
	In order to use Time and Material page
	As a user
	I want to add, edit and delete the Time and Material items

@mytag
Scenario: Add new Time and Material item
	Given User can login with valid credentials
	When User click Administration and Time and Material from dropdown
	Then User should able to add new Time and Material item
