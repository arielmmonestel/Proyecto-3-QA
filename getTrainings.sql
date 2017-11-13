
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE getTrainings 
@UserID INT
AS   
    SELECT Trainings.StartDate,Trainings.Duration,Trainings.Name,UserXTraining.trainingState, UserXTraining.calification
	FROM UserXTraining
	INNER JOIN Trainings
	ON UserXTraining.fTrainingID = Trainings.TrainingID
	WHERE UserXTraining.fUserID = @UserID;


GO
