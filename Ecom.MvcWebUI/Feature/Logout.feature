Feature: Logout
  As a user,
  I want to logout from system
  So that I will not be logged in anymore.

@smoke
Scenario: Perform Logout of E-commerce Site
	Given I am logged in to the system
	And I click on logout icon
	Then I got log out from the site and navigate to sign page.

