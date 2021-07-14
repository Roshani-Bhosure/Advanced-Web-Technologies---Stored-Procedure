USE [FYMCA_SEM2]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[All_Operation_StoredProcedure]

SELECT	@return_value as 'Return Value'

GO
