-- INSERIR PRODUTO NA TABELA
IF OBJECT_ID('SP_InfoProduto_InserirProduto') IS NOT NULL
	DROP PROCEDURE SP_InfoProduto_InserirProduto
GO
CREATE PROCEDURE SP_InfoProduto_InserirProduto
@idProduto		INT,
@nomeProduto	NVARCHAR(100),
@color			NVARCHAR(50),
@status			NVARCHAR(50),
@dataVencimento	DATETIME

AS
BEGIN

	-- Inicia transação
    IF @@TRANCOUNT = 0
        BEGIN TRANSACTION InserirProdutoInfoProduto;
    ELSE
        SAVE TRANSACTION InserirProdutoInfoProduto;

	-- Insere produtos na tabela InfoProduto
	INSERT INTO InfoProduto(idProduto, nomeProduto,cor,status,dataVencimento)
	VALUES (@idProduto, @nomeProduto, @color, @status, @dataVencimento)

    
	COMMIT TRANSACTION InserirProdutoInfoProduto;

END