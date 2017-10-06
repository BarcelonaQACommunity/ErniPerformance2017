Feature: Main view - How to manage the different lists
	In order to manage the diferrent lists
	As a user
	I want to make the basic operations

@ID:83491912-EE62-4204-B7B3-9F2CD15B8D90
@Owner: Juan Serna
Scenario: Main View - With an empty view the user can see a motivational phrase
	Given The application is running with the 'Default' configuration
	When The application does not have any tasks
	Then The user sees a proverb

@ID:079E0D72-2753-4016-ADE3-7C27021D8AE6
@Owner: Juan Serna
Scenario: Main View - When the user creates a task the main view have one task
	Given The application is running with the 'Default' configuration
	And The application does not have any tasks
	When The user goes to the add task view
	And The user sets the task with the title 'Go to shop', the content 'Buy eggs and onions', and the color 'Red'
	And The user creates the task
	Then The application has '1' task created

@ID:78DD63E3-1134-4A0D-97E4-695FC1B06421
@Owner: Juan Serna
Scenario: Main View - When the user creates three tasks and the main view have three tasks
	Given The application is running with the 'Default' configuration
	When The user creates a task with the title 'Prepare meetup', the content 'Check all the content', and the color 'Blue'
	And The user creates a task with the title 'Buy pizzas', the content 'Call and buy pizzas', and the color 'Yellow'
	And The user creates a task with the title 'Feedback', the content 'Ask for feedback', and the color 'Red'
	Then The application has '3' task created

@ID:3F4DC055-EE69-4EFC-BAB9-FDF2E9A96A5E
@Owner: Juan Serna
Scenario: Main View - The user removes a task and check that the task has been removed
	Given The application is running with the 'Default' configuration
	And The user creates a task with the title 'Prepare meetup', the content 'Check all the content', and the color 'Blue'
	And The user creates a task with the title 'Buy pizzas', the content 'Call and buy pizzas', and the color 'Yellow'
	And The user creates a task with the title 'Feedback', the content 'Ask for feedback', and the color 'Red'
	When The user goes to the task '2' edit view
	And The user removes the task
	Then The application has '2' task created