/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[name]
      ,[gender]
      ,[age]
      ,[designation]
  FROM [CFDBWF].[dbo].[employees]