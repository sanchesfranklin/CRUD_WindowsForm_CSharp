-- LISTAR PRODUTOS POR ID
IF OBJECT_ID('SP_InfoProduto_ListarProduto_byId') IS NOT NULL
	DROP PROCEDURE SP_InfoProduto_ListarProduto_byId
GO
CREATE PROCEDURE SP_InfoProduto_ListarProduto_byId
@idProduto		INT
AS
BEGIN

	SELECT * FROM InfoProduto
	WHERE idProduto = @idProduto
END