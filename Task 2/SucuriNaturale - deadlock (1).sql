USE [S12]
GO

CREATE OR ALTER PROCEDURE [dbo].[S12Deadlock1]
AS
BEGIN
	--SET DEADLOCK_PRIORITY HIGH
	--SET DEADLOCK_PRIORITY LOW

	BEGIN TRAN -- BEGIN TRANSACTION
	UPDATE [S12].[dbo].[SucuriNaturale] SET [Producator] = 'Prigat' WHERE [Denumire] = 'Fresh de capsuni de gradina'
	WAITFOR DELAY '00:00:05'
	UPDATE [S12].[dbo].[TipuriSucuriNaturale] SET [Categorie] = 'natural 100%' WHERE [Denumire] = 'Limonada cu cirese'
	COMMIT TRAN -- COMMIT TRANSACTION
END

GO

EXEC [dbo].[S12Deadlock1]

SELECT * FROM [S12].[dbo].[SucuriNaturale]
SELECT * FROM [S12].[dbo].[TipuriSucuriNaturale]