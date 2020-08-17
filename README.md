# Gym-Pal
 Application designed for logging workouts
## Inspiration
Throughout my time in the gym I have searched for gym apps that have all the features that I would want within a workout tracking app. I was never able to find one that had all of my desired functions. I have decided to create this application myself.
## Concept
This app should allow a user to effectively track all their workout and give them information to look back on to improve. It should have a list of available exercises per bodypart. It should allow the user to see their past weights and reps per exercise and view a graph of their volume.
## Wire-Frames
The Home Page will have an integrated GIF of a gym, along with a features list and buttons to become a user and sign in.
![Home Page](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Wire%20Diagram%20PDFs/New%20Project%201/Application%20Wire-frames/Homepage.png)

The sign in page will prompt the user for their username and password. A link will also be on the page for users who forget their password.
![Sign in Page](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Wire%20Diagram%20PDFs/New%20Project%201/Application%20Wire-frames/Sign%20In.png)


The User Page will display a chart showing the users overall body volume. It will also show a chart for the users body weight. It will also provide links to all the funnctions of the app.
![User Page](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Wire%20Diagram%20PDFs/New%20Project%201/Application%20Wire-frames/User%20Page.png)

The Create an Account will allow the user to select a username, password, and input current body weight.
![Create an Account Page](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Wire%20Diagram%20PDFs/New%20Project%201/Application%20Wire-frames/Become%20a%20User.png)

The Log New Excercise page will allow the user to select their exercise and input the wieght and reps of the exercise. It will also display the users past workout to reference in order to ensure they progress.
![Log New Exercise](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Wire%20Diagram%20PDFs/New%20Project%201/Application%20Wire-frames/Log%20New%20Workout.png)

The Progress page will allow the user to view their past volume per bodypart along with their past workouts per exercise. These charts will be based on what the users selections. It will also display the users past body weight.
![Progress Page](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Wire%20Diagram%20PDFs/New%20Project%201/Application%20Wire-frames/Progress_Workout%20History.png)

## Initial CHEN Relational Diagram
![Initial CHEN Diagram](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Initial%20CHEN%20Diagram.PNG)

## Requirements
1.0.0 User must be able to create account
1.1.0 System must see if account already exists
1.1.1 System must have access to users in database
1.2.0 System must compare users password and confirmed password.
2.0.0 User must be able to log into account
	2.1.0 System must check for username
		2.1.1 System must have access to database with usernames
	2.2.0 System must check that input password matches users password
		2.2.1 System must have access to database with passwords
3.0.0 System must display past exercise history
	3.1.0 System must check the exercise that the user selected
		3.1.1 System must obtain users input exercise
		3.1.2 System must be able to read the input on the GUI
	3.2.0 System must obtain users ID to reference in the database
		3.2.1 System must know who is signed in
	3.3.0 System must be able to pull exercise history from database
		3.3.1 System must have access to database.
4.0.0 System must take user input and store it
	4.1.0 System must obtain users input in the GUI
	4.2.0 System must identify exercise ID
	4.3.0 System must store exercises in the exercise history table
5.0.0 System must be able to display a graph of exercise volume
	5.1.0 System must be able to view past exercise weights and reps
	5.2.0 System must be able to do calculations based off of past reps and weights
6.0.0 User must be able to choose buddy
	6.1.0 User must be able to search for buddy
		6.1.1 System must access list of usernames and display them
7.0.0 User must be able to reset password

## User Stories
User Story #1:
As a user 
I need to be able to track my past weights and reps for exercises.
So that I can look back and base future workouts off of them.

User Story #2:
As a user
I need to be able to see my past volume per week.
So that I can ensure that I have progressive overload.

User Story #3:
As a user 
I want to be able to track my progress via weight.
So that I can see if I am improving.

User Story #4:
As a user
I want to be able to have a workout buddy that can view my workouts.
So that we can work together and motivate one another. 

## Use Case Diagram
![Use Case Diagram](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Use%20Case%20Diagram.PNG)
