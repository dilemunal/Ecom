Feature: Register
As a user,
I want to register to the website 
So that i can be a member of website.

@smoke
Scenario: : Perform Register of E-Commerce Site
	Given I launch the application
	When I click register link
	And I enter the following details
	| Name | SurName | UserName | Email | Password | RePassword |
	| name | surname | username| mail address | password | repassword|
	And I click on register button
	Then i should see login page.

Examples : Try to register with invalid e-mail address
	Given I launch the application
	When I click register
	|Name | Surname | eMail | Password | RePassword |
	|name | surname | invalidaddress | password | repassword |
	And I click on register button
	Then I should see “Invalid mail address!”

Examples : Try to register with invalid password
	Given I launch the application
	When I click register
	|Name | Surname | eMail | Password | RePassword|
	|name | surname | mail address | password | repassword |
	And I click on register button
	Then I should see “Invalid password!”





	
