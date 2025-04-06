@Login
Feature: LogIn
This feature file covers the login scenarios

	Background:
		Given User is on the login page
@One
Scenario: TC:123456 Successful Login with Valid Credentials
	When User enters "standard_user" and "secret_sauce"
    And Clicks on login button
    Then User should be redirected to the home page
	When user opens menu 
	Then Logout option is displayed 


Scenario Outline: TC:123457 Login With Invalid Credentials
	When User enters invalid <User_Name> and <Password>
    And Clicks on login button
    Then User should be redirected to the home page

	Examples: 
	| User_Name     | Password     |
	| standard_user | secret_sauce |  
	| CV            | Patel        |