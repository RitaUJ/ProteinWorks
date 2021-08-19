Feature: ProteinWorks
	as a user 
	i want to register

@mytag
Scenario: create account
	Given I fill in my details
	When I click sign up
	Then I should be registered