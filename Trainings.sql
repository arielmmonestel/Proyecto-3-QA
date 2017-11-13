
CREATE TABLE [dbo].[Trainings](
	[TrainingID] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Duration] [nvarchar](300) NOT NULL,
	[StartDate] date NOT NULL,
	[MaximumQuota] nvarchar(10) NOT NULL);

Create TABLE UserXTraining(
	userXTrainingID [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	fUserID int not null FOREIGN KEY REFERENCES Users(UserID),
	fTrainingID int not null FOREIGN KEY REFERENCES Trainings(TrainingID),
	trainingState nvarchar(100),
	calification int
);

