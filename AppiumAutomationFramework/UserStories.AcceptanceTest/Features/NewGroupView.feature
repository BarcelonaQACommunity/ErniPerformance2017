Feature: Main view - How to manage the create groups
	In order to create diferrent groups
	As a user
	I want to manage all lists from the groups

@ID:0F73D6D1-0428-4918-9592-BB4829DB4556
@Owner: Juan Serna
@ignore
Scenario: New Group View - Creates a new group
	Given The application is running with the 'Default' configuration
	When The user goes to the group list
	And The user creates the group 'New Group'
	Then The group 'New Group' is created
