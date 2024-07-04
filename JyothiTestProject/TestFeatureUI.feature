Feature: Login
	In order to login to Swag labs
	As a user
	I want to be able to enter credentials and click login

#UI Test 1: A valid user login to the application
Scenario: user can login to Swag labs
	Given user opened the Swaglabs website	
    When user enter valid user name 'standard_user'
	    And user enter the password 'secret_sauce' 
		And clicks the Login button 		
	Then user should get logged in 

#UI Test 2: A locked user cannot login to the application
Scenario: locked user cannot login to Swag labs
	Given user opened the Swaglabs website	
    When user enter valid user name 'locked_out_user'
	    And user enter the password 'secret_sauce' 
		And clicks the Login button 		
	Then user should get error message

#UI Test 3: User can login to Swag labs and add an item to cart
Scenario: user can login to Swag labs and add an item to cart
	#This test will be reusing the login steps from above test
	Given user opened the Swaglabs website	
    When user enter valid user name 'standard_user'
	    And user enter the password 'secret_sauce' 
		And clicks the Login button 		
	Then user should get logged in 
	When user add 'Sauce Labs Backpack' to cart
	And user navigate to cart
	Then the item 'Sauce Labs Backpack' should be available in cart