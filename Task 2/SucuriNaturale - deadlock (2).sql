USE [S12]
GO

CREATE OR ALTER PROCEDURE [dbo].[S12Deadlock2]
@avoidDeadlockFlag BIT
AS
BEGIN
	--SET DEADLOCK_PRIORITY HIGH
	--SET DEADLOCK_PRIORITY LOW

	BEGIN TRAN -- BEGIN TRANSACTION

	IF @avoidDeadlockFlag = 0
	BEGIN
		UPDATE [S12].[dbo].[TipuriSucuriNaturale] SET [Categorie] = 'eco/bio' WHERE [Denumire] = 'Limonada cu cirese'
		WAITFOR DELAY '00:00:05'
		UPDATE [S12].[dbo].[SucuriNaturale] SET [Producator] = 'Santal' WHERE [Denumire] = 'Fresh de capsuni de gradina'
	END
	ELSE
	BEGIN
		UPDATE [S12].[dbo].[SucuriNaturale] SET [Producator] = 'Santal' WHERE [Denumire] = 'Fresh de capsuni de gradina'
		WAITFOR DELAY '00:00:05'
		UPDATE [S12].[dbo].[TipuriSucuriNaturale] SET [Categorie] = 'eco/bio' WHERE [Denumire] = 'Limonada cu cirese'
	END

	COMMIT TRAN -- COMMIT TRANSACTION
END

GO

-- CALL THAT CAUSE DEADLOCK
EXEC [dbo].[S12Deadlock2] 0

-- CALL WHICH AVOIDS DEADLOCK
EXEC [dbo].[S12Deadlock2] 1

SELECT * FROM [S12].[dbo].[SucuriNaturale]
SELECT * FROM [S12].[dbo].[TipuriSucuriNaturale]