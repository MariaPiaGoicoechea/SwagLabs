Feature: Products


Background: 
	Given I launch the SauceDemo webpage
	And I enter the username 'standard_user' and the password 'secret_sauce' of a user

Scenario: Verify price low to high order
	When I order the products by 'Price (low to high)'
	Then The products are ordered by price from low to high