Feature: RPNCalc
	I want to get the arithmetic opration of two numbers

@mytag
Scenario: Add two numbers
	Given First value as 50
	And Second value as 70
	When I have entered sign "+"
	Then the result should be 120 on the screen

Scenario: Subtract two numbers
	Given First value as 50
	And Second value as 10
	When I have entered sign "-"
	Then the result should be 40 on the screen

Scenario: Multiply two numbers
	Given First value as 50
	And Second value as 1
	When I have entered sign "*"
	Then the result should be 50 on the screen

Scenario: Divide two numbers
	Given First value as 50
	And Second value as 10
	When I have entered sign "/"
	Then the result should be 5 on the screen