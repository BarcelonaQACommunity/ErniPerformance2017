Feature: Edit Task view - How to edit different tasks
	In order to edit different tasks
	As a user
	I want to edit tasks

@ID:038A7EA2-CF10-4F9A-86AF-F620E63CDC90
@Owner: Juan Serna
Scenario: Edit Task View - Check that the created task has the correct values in the edit view
	Given The application is running with the 'Default' configuration
	When The user creates a task with the title 'Prepare meetup', the content 'Check all the content', and the color 'Blue'
	And The user goes to the task '1' edit view
	Then The task has the title 'Prepare meetup' and the content 'Check all the content'
