# Unnamed Time Application
This is a project for my MSSA Cohort. :feelsgood:

## Description
The main focus of this application is to allow a user to be able to prioritize, track, and manage their tasks while using a built in work timer to help focus on completeing them.

## Table of Contents
1. [Draft Wire Frame Diagram](https://github.com/jonathan-f-gomez/unnamed-time-application#draft-wire-frame-diagram)
1. [User Stories](https://github.com/jonathan-f-gomez/unnamed-time-application#user-stories)
1. [Use-Cases](https://github.com/jonathan-f-gomez/unnamed-time-application#use-cases)
1. [Use-Case Diagram](https://github.com/jonathan-f-gomez/unnamed-time-application#use-case-diagram)
1. [Requirements](https://github.com/jonathan-f-gomez/unnamed-time-application#test-requirements)
2. [Lessons Learned](https://github.com/jonathan-f-gomez/unnamed-time-application/blob/main/README.md#lessons-learned)
3. [Check out the Prototype!  :electron:](https://github.com/jonathan-f-gomez/unnamed-time-application/blob/main/Prototype/README.MD#prototype-for-the-uta)<br />




## Draft Wire Frame Diagram
![Draft WFD](https://github.com/jonathan-f-gomez/unnamed-time-application/blob/main/Requirements/Wire-Frame-Diagram/UTAFull.jpg)


[See individual draft wire diagram frame pictures](https://github.com/jonathan-f-gomez/unnamed-time-application/blob/main/Requirements/Wire-Frame-Diagram)<br />
[Back to the top](https://github.com/jonathan-f-gomez/unnamed-time-application#unnamed-time-application)


## User Stories
As a Student, I need a website that will help me track my tasks.

As a Student, I need a website that helps me visualize when my tasks are due.

As a Student, I need an way to effectively manage my time while completing my tasks.

[Back to the top](https://github.com/jonathan-f-gomez/unnamed-time-application#unnamed-time-application)

## Use-Cases

As a user I need a way to access my task list from anywhere so I can always reference my tasks.

As a user I need a way to add tasks to a list so I can track them.

As a user I need a way to add a name to a task to help easily identify the task.

As a user I need a way to set the priority of a task so I know which one to work on first.

As a user I need a way to set the due date for a task to manage my time.

As a user I need a way to edit a task if I make a mistake or something changes.

As a user I need a way to delete a task to remove it completely.

As a user I need a way to edit the length of my timers so that I can find a time the benefits me the most.

[Back to the top](https://github.com/jonathan-f-gomez/unnamed-time-application#unnamed-time-application)

## Use-Case Diagram
![Image of UMLUnNamedTimeApp](https://github.com/jonathan-f-gomez/unnamed-time-application/blob/main/Requirements/UMLUnNamedTimeApp.jpg)

[Back to the top](https://github.com/jonathan-f-gomez/unnamed-time-application#unnamed-time-application)

## Test Requirements

| Requirement ID | Requirement Description | Test Procedure | Test Result | Notes |
| -------------: | :---------------------- | :------------: | :---------: | :---: |
| 1 | The system shall allow the current user to log in, create a user account or continue as a guest.	| User Login | :green_circle: | The system Allows users to login |
| 1.1 | The system shall provide means for an existing user to enter his/her user ID and password.	|  | :green_circle: |  |
| 1.1.1 | Given a user ID, the system shall verify the validity of the user ID and password. |  | :green_circle: |  |
| 1.1.2 | Given authorization, the system shall allow the user access to their task list.	|  | :red_circle: | As of 16 May all users can see everyones tasks |
| 1.1.3 | The system shall allow the new user to create new user ID and allow the new user to create a password. |  | :green_circle: |  |
| 1.1.4 | The system shall give access to the application when the user continues as guest.	|  | :green_circle: |  |
| 1.2 | The system shall allow the user to access the calendar, task list, and timer.	| Website Layout | :orange_circle: | The Calendar view no longer exits |
| 1.2.1 | The system shall allow the user to display the user’s task list.	|  | :orange_circle: | Displays a task list that shows everyones tasks |
| 1.2.2 | The system shall allow the user to display the Pomodoro Timer. |  | :green_circle: |  |
| 1.2.3 | The system shall allow the user to display the calendar.	|  | :red_circle: | Calendar view no longer exits |
| 1.3 | The system shall display options to create a new task.	| Website Layout | :green_circle: |  |
| 1.3.1 | The system shall display options to edit a task.		|  | :green_circle: |  |
| 1.3.2 | The system shall display options to delete a task.	|  | :green_circle: |  |
| 1.4 | The system shall display options to edit the durations of the timers.	|  | :red_circle: |  |
| 2 | The system shall save the data provided by the user in the application database.	|  | :green_circle: |  |
| 2.2 | the System shall only save data from a guest user for that session.	|  | :red_circle: | With the current build everyone can create tasks and display everyones task. |

[Back to the top](https://github.com/jonathan-f-gomez/unnamed-time-application#unnamed-time-application)


## Lessons learned:

### What did I do right?
Keeping my project small allowed me to focus more on fundamentals.

### What did I do wrong?
At the beginning of the project, I spent three weeks on one problem, and instead of putting it on the backlog, I put myself three weeks behind.

### What would I change / what do I know now that I wish I knew "then"?
I would follow my original design of having a single webpage and use more partial views as well as not putting my efforts into one portion of the project for so long.


[Back to the top](https://github.com/jonathan-f-gomez/unnamed-time-application#unnamed-time-application)


