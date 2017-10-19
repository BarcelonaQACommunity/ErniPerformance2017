Feature: Main view - How to manage the different lists
	In order to manage the diferrent lists
	As a user
	I want to make the basic operations

@ID:83491912-EE62-4204-B7B3-9F2CD15B8D90
@Owner: Juan Serna
Scenario: Main View - With an empty view the user can see a phrase
	Given The application does not have any tasks
	Then The user sees a proverb

@ID:079E0D72-2753-4016-ADE3-7C27021D8AE6
@Owner: Juan Serna
Scenario: Main View - When the user creates a task the main view have one task
	Given The application does not have any tasks
	When The user goes to the add task view
	And The user sets the task with the title 'Go to shop', the content 'Buy eggs and onions', and the color 'Red'
	And The user creates the task
	Then The application has '1' task created

#Exercise1:
#TODO: The user adds 3 tasks and then must deleted all of them, implement the corresponding Gerkin (MainViewSteps.cs).