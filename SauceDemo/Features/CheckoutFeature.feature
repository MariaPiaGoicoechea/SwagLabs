Feature: Checkout

Background: 
	Given I launch the SauceDemo webpage
	And I enter the username 'standard_user' and the password 'secret_sauce' of a user
	And I add the product 'Sauce Labs Backpack' to the cart
	And I go to see my cart
	And I start the checkout

Scenario: Successful checkout 
	When I complete my information
	And I click continue
	And I finish the checkout
	Then Checkout is successfully completed
