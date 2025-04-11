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

	Scenario: TC:523459 Verify alert appeares after 5 seconds
		When user navigates to the Alerts, Frame & Windows page page
		And user clicks on button to see delayed alert
	    Then delayed alert is displayed with text "This alert appeared after 5 seconds"
		When user accepts the alert
		Then alert is disappeared 

	Scenario: TC:623459 Verify cancel action for confirm box 
		When user navigates to the Alerts, Frame & Windows page page
		And user clicks on button to see confirm box
		Then alert is displayed with text "Do you confirm action?"
		When user cancels the alert
		Then alert is disappeared 
		And "You selected Cancel" message is displayed

	Scenario: TC:723459 Verify prompt alert
		When user navigates to the Alerts, Frame & Windows page page
		And user clicks on button to see prompt box
		Then alert is displayed with text "Please enter your name"
		When user enters the name "Kishan Patel"
		And  user accepts the alert
		Then "You entered Kishan Patel" message is displayed