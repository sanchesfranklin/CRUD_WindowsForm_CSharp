-- ATUALIZAR PRODUTO
IF OBJECT_ID('SP_InfoProduto_AtualizarProduto') IS NOT NULL
	DROP PROCEDURE SP_InfoProduto_AtualizarProduto
GO
CREATE PROCEDURE SP_InfoProduto_AtualizarProduto
@idProduto		INT,
@nomeProduto	NVARCHAR(100),
@color			NVARCHAR(50),
@status			NVARCHAR(50),
@dataVencimento	DATETIME

AS
BEGIN
	
	-- Inicia Transa��o
	IF @@TRANCOUNT = 0
        BEGIN TRANSACTION AtualizarProdutoInfoProduto;
    ELSE
        SAVE TRANSACTION AtualizarProdutoInfoProduto;

	-- Atualiza produtos
	UPDATE InfoProduto SET 
	idProduto = @idProduto, 
	nomeProduto = @nomeProduto,
	cor = @color,
	status = @status,
	dataVencimento = @dataVencimento
	WHERE idProduto = @idProduto

	--Comita transa��o
	COMMIT TRANSACTION AtualizarProdutoInfoProduto;

END