DROP TABLE IF EXISTS [Exercises]
CREATE TABLE [Exercises] (
  [ID] INT PRIMARY KEY IDENTITY,
  [BodyPart]  VARCHAR(20),
  [Excercise] VARCHAR(20),
  [TypeOfWorkout] VARCHAR(20)
);

DROP TABLE IF EXISTS [Workout]
CREATE TABLE [Workout] (
  ID INT IDENTITY PRIMARY KEY,
  [Workout Number] INT,
  [UserID] INT FOREIGN KEY REFERENCES Users(ID),
  [Date] Date
);

DROP TABLE IF EXISTS [Sets]
CREATE TABLE [Sets] (
  ID INT IDENTITY PRIMARY KEY,
  [ExerciseID] INT FOREIGN KEY REFERENCES Exercises(ID),
  [NumberOfReps] INT,
  [Weight] INT,
  [Workout ID] INT FOREIGN KEY REFERENCES Workout(ID)
);

DROP TABLE IF EXISTS [Progress]
CREATE TABLE [Progress] (
  [ID] INT PRIMARY KEY IDENTITY ,
  [Date] DATE,
  [BodyWeight] INT,
  [UserID] INT FOREIGN KEY REFERENCES Users(ID)
);

DROP TABLE IF EXISTS [Users]
CREATE TABLE [Users] (
  [ID] INT PRIMARY KEY IDENTITY,
  [FirstName] NVARCHAR(40),
  [LastName] NVARCHAR(40),
  [Email] NVARCHAR(120),
  [Password] NVARCHAR(50)
);

--Seeding Data

INSERT INTO [Exercises] ( BodyPart, Excercise, TypeOfWorkout)
VALUES ( 'Chest', 'Bench Press', 'strength'),
( 'Back', 'Lat Pulldowns',  'strength'),
( 'legs', 'Squats', 'strength')

INSERT INTO [Workout] ([Workout Number], UserID, Date)
VALUES (1,1, '2020-07-20')

INSERT INTO Sets (ExerciseID, NumberOfReps, Weight, [Workout ID])
VALUES(1, 12, 205, 1),
(1, 15, 205, 1),
(1, 10, 225, 1),
(1, 8, 245, 1)

INSERT INTO [Progress] (UserID, Date, BodyWeight) 
VALUES (1, '2020-07-20', 215)

INSERT INTO [Users] ( [FirstName], [LastName], Email, Password)
VALUES ( 'Tim', 'Weigel', 'example@SomeThing.com', 'Password')

--Ensuring Tables are populated
SELECT * FROM Users
SELECT * FROM Progress
SELECT * FROM Sets
SELECT * FROM Workout
SELECT * FROM Exercises
