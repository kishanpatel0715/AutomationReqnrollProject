Feature: PracticeForm

A short summary of the feature

Scenario: TC:123459 Verify Practice Form submission
	When user navigates to the practice form page
	And user enters following details:
	| Field           | Value                                              |
	| First Name      | Kishan                                             |
	| Last Name       | Patel                                              |
	| Email           | kcpatel07150715@gmail.com                          |
	| Gender          | Female                                             |
	| Mobile          | 5879735451                                         |
	| Subjects        | Automation                                         |
	| Hobbies         | Reading                                            |
	| Picture         | C:\\Users\\kisha\\Pictures\\Screenshots\\Kohli.png |
	| Current Address | 25 red sky                                         |
	| State           | Haryana                                            |
	| City            | Panipat                                            |  
	And user submits the form
	Then form is submitted successfully 
	And following details are displayed
	| Field           | Value                     |
	| First Name      | Kishan                    |
	| Last Name       | Patel                     |
	| Email           | kcpatel07150715@gmail.com |
	| Gender          | Female                    |
	| Mobile          | 5879735451                |
	| Subjects        | Automation                |
	| Hobbies         | Reading                   |
	| Picture         | Kohli.png                 |  
	| Current Address | 25 red sky                |
	| State           | Haryana                   |
	| City            | Panipat                   |