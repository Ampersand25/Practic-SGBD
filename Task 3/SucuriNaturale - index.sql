USE [S12]
GO

DROP INDEX IF EXISTS [idx_SucuriNaturale_Denumire] ON [S12].[dbo].[SucuriNaturale]

CREATE INDEX [idx_SucuriNaturale_Denumire] ON [S12].[dbo].[SucuriNaturale] ([Denumire])

GO

DROP VIEW [vw_SucuriNaturale]

GO

CREATE VIEW [vw_SucuriNaturale] AS
SELECT [Denumire] AS 'Denumire suc natural', [Producator suc] = [Producator], [Gramaj]
FROM [S12].[dbo].[SucuriNaturale]

GO

SELECT * FROM [vw_SucuriNaturale]
ORDER BY [Denumire suc natural] DESC