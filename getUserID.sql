USE [TEC_QA_CRM]
GO

/****** Object:  UserDefinedFunction [dbo].[validarLogin]    Script Date: 11/17/2017 3:01:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[getUserID]
(
@userName as nvarchar(256)
)
returns int
as
begin
declare
	@isUser as int = -1
	select @isUser = u.UserID 
	from Users u 
	where u.Email = @userName
	
	return @isUser
end
