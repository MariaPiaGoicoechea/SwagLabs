Feature: AddToCart

Background: 
	Given I launch the SauceDemo webpage
	And I enter the username 'standard_user' and the password 'secret_sauce' of a user

Scenario: Check cart products
	When I add the product 'Sauce Labs Backpack' to the cart
	And I go to see my cart
	Then The product 'Sauce Labs Backpack' should be in the cart