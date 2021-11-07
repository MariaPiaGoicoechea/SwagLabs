Feature: Login

Scenario: Login to SauceDemo
	Given I launch the SauceDemo webpage
	When I enter the username 'standard_user' and the password 'secret_sauce' of a user
	Then User is successfully logged in and taken to the Products page

Scenario: Invalid login to SauceDemo
	Given I launch the SauceDemo webpage
	When I enter the username 'locked_out_user' and the password 'secret_sauce' of a user
	Then appears an error message