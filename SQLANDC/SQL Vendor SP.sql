USE [AdventureWorks2012]
GO


Create Proc [dbo].[spAllVendors] 
as

Select	V.name [Vendor], PreferredVendorStatus [Preferred Vendor Status], 
		AddressLine1 [Address Line 1], AddressLine2 [Address Line 2], City, Sp.Name [State], PostalCode [ZIP]
From Purchasing.Vendor V
Inner Join Person.BusinessEntityAddress BEA
On V.BusinessEntityID = BEA.BusinessEntityID
Inner Join Person.[Address] A
On BEA.AddressID = A.AddressID
Inner Join Person.StateProvince SP
On A.StateProvinceID = SP.StateProvinceID
GO


