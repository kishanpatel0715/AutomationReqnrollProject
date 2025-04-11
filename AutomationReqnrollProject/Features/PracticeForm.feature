Feature: PracticeForm
To test Practice Form

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

	Scenario: TC:223459 Verify button gets visible after 5 seconds
		When user navigates to the Dynamic Properties page
	    Then after 5 seconds, button is visible

	Scenario: TC:323459 Verify button gets enabled after 5 seconds
		When user navigates to the Dynamic Properties page
	    Then after 5 seconds, button is enabled

	Scenario: TC:423459 Verify alert
		When user navigates to the Alerts, Frame & Windows page page
		And user clicks on button to see alert
	    Then alert is displayed with text "You clicked a button"
		When user accepts the alert
		Then alert is disappeared 