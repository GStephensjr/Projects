/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Name]
      ,[Commander]
      ,[Location]
      ,[Motto]
      ,[Mission]
      ,[Size]
  FROM [Hierarchy].[dbo].[Majcoms]

--  bulk insert
--  dbo.Majcoms
--  from 'C:\Users\Grego\OneDrive\Desktop\MSSA\Projects\Heirarchy Database GUI\HierarchyGUI V3\DatabaseCSV\majcoms.csv'
--  WITH
--(
--FIRSTROW = 1,
--FIELDTERMINATOR = ',',
--ROWTERMINATOR = '\n'
--);