Feature: Login
  As a user,
  I want to login into website 
  So that I can be logged in to site.

@smoke
Scenario: Perform Login of E-commerce Site
	Given I launch the application
	When I navigate to login 
	And I enter the following details
	|UserName | Password |
	|user     | password |
	And I click on login button
	Then I should see home page

Examples: Try to login with invalid password 
	Given I launch the application
	When I navigate to login
	And I enter enter the following details
	|UserName | Password |
	|userinvalid | password |
	And I click on login button
	Then I should see an error message saying "Password is incorrect!"
	And I stay on login page

Examples: Scenario : Try to login with invalid username
	Given I launch the application
	When I navigate to login
	And I enter the following details
	|UserName | Password |
	|userinvalid     | password |
	And I click on login button
	Then I should see an error message saying "Username is incorrect!"
	And I stay on login page