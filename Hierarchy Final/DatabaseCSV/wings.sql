/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Name]
      ,[Commander]
      ,[Location]
      ,[Motto]
      ,[Mission]
      ,[Size]
  FROM [Hierarchy].[dbo].[Wings]

   bulk insert
 dbo.wings
 from 'c:\users\grego\onedrive\desktop\mssa\projects\heirarchy database gui\hierarchygui v3\databasecsv\wings.csv'
 with
(
firstrow = 1,
fieldterminator = ',',
rowterminator = '\n'
);