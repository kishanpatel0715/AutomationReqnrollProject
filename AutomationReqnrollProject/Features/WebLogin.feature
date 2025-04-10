@ignore 
Feature: WebLogin

A short summary of the feature

@tag1
Scenario: Successful WebLogin with Valid Credentials
	When User enters weblogin credentials "kcpatel07150715@gmail.com" and "Rr1@ockondude"
    And Clicks on Weblogin button
    Then User should be redirected to the weblogin home page
