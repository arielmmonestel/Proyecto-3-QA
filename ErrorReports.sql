Create table ErrorReports(
	ErrorID int IDENTITY(1,1) NOT NULL,
	UserID int,
	SaleID int,
	ProductName nvarchar(100),
	ErrorDate Date,
	ContactMail nvarchar(100),
	ErrorDescription nvarchar(max)
	)

