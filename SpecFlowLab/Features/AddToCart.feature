Feature: AddToCart

@mytag
Scenario: Add two numbers
	Given swaglabs page
	When user logined
	And first product was added
	And open cart page
	Then check if selected product was added