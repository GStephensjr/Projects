/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Name]
      ,[Commander]
      ,[Location]
      ,[Motto]
      ,[Mission]
      ,[Size]
      ,[Majcom]
  FROM [Hierarchy].[dbo].[NumberedAFs]


   bulk insert
 dbo.NumberedAfs
 from 'c:\users\grego\onedrive\desktop\mssa\projects\heirarchy database gui\hierarchygui v3\databasecsv\numberedafs.csv'
 with
(
firstrow = 1,
fieldterminator = ',',
rowterminator = '\n'
);


delete from dbo.NumberedAFs