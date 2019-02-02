Feature: TimeAndMaterial
	In order to use Time and Material page
	As a user
	I want to add, edit and delete the Time and Material items

Background: 
Given Shopper is using "Chrome" browser
When  User navigate to "http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f" url
And   User enter valid credentials "hari" and "123123"
Then  User is able to Login



@BasicFlows
Scenario Outline: 1 Add new Time and Material item
			Given User click Administration and Time and Material from dropdown
			When  User click on Create New button
			Then User should able to add <TypeCode>, <Code>, <Description> and <PricePerUnit> 
			And  Verify new time and material is added

Examples:
		| TypeCode | Code      | Description      | PricePerUnit |
		| Material | testCode  | testDescription2 | 3            |
		| Time     | testCode1 | testDescription  | 2            |


Scenario: 2  Edit the new Time and Material item
			Given User click Administration and Time and Material from dropdown
			When  User navigated to end page of the items
			Then User should able to edit new Time and Material item
			And  Verify new time and material is edited

Scenario: 3  Delete the new Time and Material item
			Given User click Administration and Time and Material from dropdown
			When  User navigated to end page of the items
			Then User should able to delete edited Time and Material item
	

