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
Scenario: Add new Time and Material item
	Given User click Administration and Time and Material from dropdown
	When  User click on Create New button
	Then User should able to add new Time and Material item
	And  Verify new time and material is added


