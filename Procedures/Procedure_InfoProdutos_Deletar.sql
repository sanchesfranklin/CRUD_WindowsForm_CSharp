-- DELETAR PRODUTO
IF OBJECT_ID('SP_InfoProduto_DeletarProduto') IS NOT NULL
	DROP PROCEDURE SP_InfoProduto_DeletarProduto
GO
CREATE PROCEDURE SP_InfoProduto_DeletarProduto
@idProduto		INT
AS
BEGIN

	-- Inicia Transação
	IF @@TRANCOUNT = 0
        BEGIN TRANSACTION DeletarProdutoInfoProduto;
    ELSE
        SAVE TRANSACTION DeletarProdutoInfoProduto;

	DELETE FROM InfoProduto
	WHERE idProduto = @idProduto

	COMMIT TRANSACTION DeletarProdutoInfoProduto;
END