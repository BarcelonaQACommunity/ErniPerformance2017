Feature: Add Task view - How to create different tasks
	In order to create different tasks
	As a user
	I want to create tasks

@ID:FCA58CA7-D7F7-4F20-B65E-269A8864E47E
@Owner: Juan Serna
Scenario Outline: Add Task View - Check the values from the task
	Given The application is running with the 'Default' configuration
	And The user goes to the add task view
	When The user sets the task with the title '<Title>', the content '<Content>', and the color '<Color>'
	Then The user check that the title '<Title>' and the content '<Content>' from the task are the correct values

	Examples: 
	| Title   | Content             | Color  |
	| Title 1 | This is a content 1 | Blue   |
	| Title 2 | This is a content 2 | White  |
	| Title 3 | This is a content 3 | Yellow |
