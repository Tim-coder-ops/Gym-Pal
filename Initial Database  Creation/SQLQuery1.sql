DROP TABLE IF EXISTS [Excercises]
CREATE TABLE [Excercises] (
  [ID] INT PRIMARY KEY IDENTITY,
  [BodyPart]  VARCHAR(20),
  [Excercise] VARCHAR(20),
  [TypeOfWorkout] VARCHAR(20)
);

DROP TABLE IF EXISTS [Workout]
CREATE TABLE [Workout] (
  ID INT IDENTITY(1,1) PRIMARY KEY,
  [Workout Number] INT,
  [UserID] INT FOREIGN KEY REFERENCES Users(ID),
  [Date] Date
);

DROP TABLE IF EXISTS [Sets]
CREATE TABLE [Sets] (
  ID INT IDENTITY(1,1) PRIMARY KEY,
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

INSERT INTO [Excercises] (ExerciseID, BodyPart, Excercise, TypeOfWorkout)
VALUES (1, 'Chest', 'Bench Press', 'strength'),
(2, 'Back', 'Lat Pulldowns',  'strength'),
(3, 'legs', 'Squats', 'strength')

INSERT INTO [Workout History] ([Workout Number], ExerciseID, SetID, UserID,  NumberOfReps, Weight, Date)
VALUES (1, 1, 1, 1, 12, 185, '2020-07-20'),
(1, 1, 2, 1, 10, 205, '2020-07-20'),
(1, 1, 3, 1, 10, 205, '2020-07-20'),
(1, 1, 4, 1, 7, 225, '2020-07-20'),
(1, 2, 1, 1, 12, 180, '2020-07-20'),
(1, 2, 2, 1, 10, 200, '2020-07-20'),
(1, 2, 3, 1, 10, 200, '2020-07-20'),
(1, 2, 4, 1, 6, 220, '2020-07-20')

INSERT INTO [Progress] (UserID, Date, Weight) 
VALUES (1, '2020-07-20', 215)

INSERT INTO [Users] (UserID, [FirstName], [LastName])
VALUES (1, 'Tim', 'Weigel'),
(2, 'John', 'Smith')

SELECT FirstName + ' ' + LastName AS Name,
	BodyPart, Excercise,
	[Workout Number], 
	SetID,
	Weight,
	NumberOfReps, 
	Date
FROM Excercises E
JOIN [Workout History] WH
ON E.ExerciseID = WH.ExerciseID
JOIN Users U
ON U.UserID = WH.UserID

SELECT FirstName, 
	LastName, 
	Date, 
	Weight
FROM Users U
JOIN Progress P
ON U.UserID = P.UserID