USE [TEC_QA_CRM]
GO

/****** Object:  StoredProcedure [dbo].[getTrainings]    Script Date: 11/13/2017 12:05:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getRelationatedProducts] 
@UserID INT
AS   
    SELECT * FROM Trainings
	WHERE Trainings.TrainingID NOT IN(
	SELECT UserXTraining.fTrainingID FROM UserXTraining
	WHERE UserXTraining.fUserID = @UserID 
	);



GO


