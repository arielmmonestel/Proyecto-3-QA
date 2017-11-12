CREATE VIEW Contact_View AS
select sales.ClientID, petition.SaleID, person.Name, person.Address, person.Email
from [dbo].[ReviewPetitions] as petition
inner join [dbo].[Persons] as person on petition.EmployeeID = person.PersonID
inner join [dbo].[Sales] as sales on petition.SaleID = sales.SaleID
