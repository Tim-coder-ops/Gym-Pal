# Gym-Pal
 ## [Table of Contents](#table-of-contents)
 1) [Inspiration](#Inspiration)
 2) [Concept](#concept)
 3) [Wire-Frames](#wire-frames)
 4) [Initial ERD](#ERD)
 5) [Requirements](#requirements)
 6) [Test Table](#test-table)
 7) [User Stories](#user-stories)
 8) [Use Case Diagram](#use-case-diagram)
 9) [Prototypes](#prototypes)

# <a name="Inspiration"></a>
## <div align="Center"> Inspiration</div>  [(Back to top)](#table-of-contents)
Throughout my time in the gym I have searched for gym apps that have all the features that I would want within a workout tracking app. I was never able to find one that had all of my desired functions. I have decided to create this application myself.

# <a name="concept"></a>
## <div align="Center"> Concept</div> [(Back to top)](#table-of-contents)
This app should allow a user to effectively track all their workout and give them information to look back on to improve. It should have a list of available exercises per bodypart. It should allow the user to see their past weights and reps per exercise and view a graph of their volume.

# <a name="wire-frames"></a>
## <div align="Center"> Wire-Frames</div> [(Back to top)](#table-of-contents)
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

# <a name="ERD"></a>
## <div align="Center"> Initial ERD</div> [(Back to top)](#table-of-contents)
![Initial CHEN Diagram](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Initial%20CHEN%20Diagram.PNG)

# <a name="requirements"></a>
## <div align="Center"> Requirements</div> [(Back to top)](#table-of-contents)
[Requirements Document](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Gym%20Pal%20Requirements.docx)
| Requirement ID | Requirement                                                         |
|----------------|-----------------------------------------------------------------------------------------------------|
| 1.0.0          | User must be able to create account                                                                 |
|   1.1.0        | System must see if account already exists                                                           |
|     1.1.1      | System must have access to users in database                                                        |
| 2.0.0          | User must be able to log into account                                                               |
|   2.1.0        | System must check for username                                                                      |
|     2.1.1      | System must have access to database with usernames                                                  |
|  2.2.0         | System must check that input password matches users password                                        |
|     2.2.1      | System must have access to database with passwords                                                  |
| 3.0.0          | System must display past exercise history                                                           |
|   3.1.0        | System must check the exercise that the user exercise                                               |
|     3.1.1      | System must obtain users input exercise                                                             |
|     3.1.2      | System must be able to read the input on the GUI                                                    |
|   3.2.0        | System must obtain users ID to reference in the database                                            |
|     3.2.1      | System must know who is signed in                                                                   |
|   3.3.0        | System must be able to pull exercise history from database                                          |
|     3.3.1      | System must have access to the database                                                             |
| 4.0.0          | System must take user input and store it                                                            |
|   4.1.0        | System must obtain users input in the GUI                                                           |
|   4.2.0        | System must identify exercise ID                                                                    |
|   4.3.0        | System must store exercises in the exercise history table                                           |
| 5.0.0          | System must be able to display a graph of exercise volume                                           |
|   5.1.0        | System must be able to view past exercise weights and reps                                          |
|   5.2.0        | System must be able to do calculations based off of past reps and weights                           |
| 6.0.0          | User must be able to choose buddy                                                                   |
|   6.1.0        | User must be able to search for buddy                                                               |
|     6.1.1      | System must access list of usernames and display them                                               |
| 7.0.0          | User must be able to reset password                                                                 |
|   7.1.0        | System must have stored security questions for the user                                             |
|   7.2.0        | System must be able to compare the users answers to security questions to the ones in the   database|
| 8.0.0          | User must be able to view past body weight                                                          |
|   8.1.0        | System must be able to access past body weights based off of user ID                                |
| 9.0.0          | User must be able to store new body weights                                                         |
|   9.1.0        | System must take users input and store weight based off of user ID                                  |
| 10.0.0         | System must be able to display users history per exercise on progress page                          |
|   10.1.0       | System must obtain users selected body part and exercise from GUI                                   |
|   10.2.0       | System must access all of the users past exercises.                                                 |

# <a name="test-table"></a>
## <div align="Center"> Test Table</div> [(Back to top)](#table-of-contents)

| Test ID | Requirement ID | Test Procedure                                                                                                                                                                      | Status     | Time Stamp |
|---------|----------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|------------|
| 1       | 1.0.0          | Create a new user account and check database for new account.                                                                                                                       | Not Tested |            |
| 2       | 2.0.0          | Log in with created account,  Should to sent to user home screen.                                                                                                                   | Not Tested |            |
| 3       | 3.0.0          | Log new workouts into the app, then  check the progress and log new exercise section to ensure that the past workouts are pulled.                                                   | Not Tested |            |
| 4       | 4.0.0          | Go into the log new workout section and enter at least 3 different exercises. Then change the database to ensure they are stored.                                                   | Not Tested |            |
| 5       | 5.0.0          | Ensure that workouts are logged in the database  under the correct user ID. Then go to the progress  section and check that the graph displays the workouts.                        | Not Tested |            |
| 6       | 6.0.0          | Ensure that multiple users are created and stored in the database. Then go to find a buddy section and search  for another user. The user should appear and be able to be selected. | Not Tested |            |
| 7       | 7.0.0          | Go to the log in window and click the forgot password link. Then answer the security questions. If answered correctly it will allow the user to create a new password.              | Not Tested |            |
| 8       | 8.0.0          | Ensure that multiple user body weights are stored in the  database. Then go to the progress page. It should display  a graph with past weights.                                     | Not Tested |            |
| 9       | 9.0.0          | Log multiple body weights under a logged in user. Ensure that the weights are saved in the database.                                                                                | Not Tested |            |
| 10      | 10.0.0         | Ensure that multiple exercises are stored in the database. Then go to the progress page and select an exercise that is stored. It should display the past sets per exercise.        | Not Tested |            |

# <a name="user-stories"></a>
## <div align="Center"> User Stories</div> [(Back to top)](#table-of-contents)
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

# <a name="use-case-diagram"></a>
## <div align="Center"> Use Case Diagram</div> [(Back to top)](#table-of-contents)
![Use Case Diagram](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Use%20Case%20Diagram.PNG)


# <a name="prototypes"></a>
## <div align="Center"> Prototypes </div> [(Back to top)](#table-of-contents)
[Prototypes of Gym Pal](https://github.com/Tim-coder-ops/Gym-Pal/tree/master/Prototypes)

# <a name="Database Diagram"></a>
## <div align="Center"> Prototypes </div> [(Back to top)](#table-of-contents)
![Database Diagram](https://github.com/Tim-coder-ops/Gym-Pal/blob/master/Database%20Diagram.PNG)
