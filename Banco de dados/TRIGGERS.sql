CREATE TRIGGER trgSegurancaViewTipoUsuario
        ON vwTipoUsuario 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaTipoUsuarioManter
    ON tblTipoUsuario
    INSTEAD OF INSERT, UPDATE, DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewUsuario
        ON vwUsuario 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaUsuarioManter
    ON tblUsuario
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewEstado
        ON vwEstado 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaEstadoManter
    ON tblEstado
    INSTEAD OF INSERT, UPDATE, DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewCidade
        ON vwCidade 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaCidadeManter
    ON tblCidade
    INSTEAD OF INSERT, UPDATE, DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewPessoa
        ON vwPessoa 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaPessoaManter
    ON tblPessoa
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewPessoaFisica
        ON vwPessoaFisica 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewPessoaJuridica
        ON vwPessoaJuridica 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewContratoAluguel
        ON vwContratoAluguel 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaContratoAluguelManter
    ON tblContratoAluguel
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewPasto
        ON vwPasto 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaPastoManter
    ON tblPasto
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewEstoqueLocalidade
        ON vwEstoqueLocalidade 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaEstoqueLocalidadeManter
    ON tblEstoqueLocalidade
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewTipoItem
        ON vwTipoItem 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaTipoItemManter
    ON tblTipoItem
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewItem
        ON vwItem 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaItemManter
    ON tblItem
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewEstoque
        ON vwEstoque 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaEstoqueManter
    ON tblEstoque
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewEntradaItem 
        ON vwEntradaItem 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para somar ao estoque quando houve entrada
CREATE TRIGGER trgEntradaItemSomaEstoque
    ON tblEntradaItem 
    AFTER INSERT
    AS
	BEGIN
		UPDATE 
			tblEstoque 
		SET
			EstoqueQuantidade = EstoqueQuantidade + (SELECT EntradaItemQuantidade FROM INSERTED)
		WHERE 
			EstoqueID = (SELECT EstoqueID FROM INSERTED)
	END
			
-- Trigger para subtrair do estoque quando houver exclusão da entrada
CREATE TRIGGER trgEntradaItemSubtrairEstoque
    ON tblEntradaItem 
    AFTER DELETE
    AS
	BEGIN
		UPDATE 
			tblEstoque 
		SET
			EstoqueQuantidade = EstoqueQuantidade - (SELECT EntradaItemQuantidade FROM DELETED)
		WHERE 
			EstoqueID = (SELECT EstoqueID FROM DELETED)
	END

CREATE TRIGGER trgSegurancaViewRetiradaItem
        ON vwRetiradaItem
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
						
-- Trigger para subtrair ao estoque quando houve retirada
CREATE TRIGGER trgRetiradaItemSubtracaoEstoque
    ON tblRetiradaItem 
    AFTER INSERT
    AS
	BEGIN
		UPDATE 
			tblEstoque 
		SET
			EstoqueQuantidade = EstoqueQuantidade - (SELECT  RetiradaItemQuantidade FROM INSERTED)
		WHERE 
			EstoqueID = (SELECT EstoqueID FROM INSERTED)
	END
			
-- Trigger para somar do estoque quando houver exclusão da retirada
CREATE TRIGGER trgRetiradaItemSomaEstoque
    ON tblRetiradaItem 
    AFTER DELETE
    AS
	BEGIN
		UPDATE 
			tblEstoque 
		SET
			EstoqueQuantidade = EstoqueQuantidade + (SELECT  RetiradaItemQuantidade FROM DELETED) 
		WHERE 
			EstoqueID = (SELECT EstoqueID FROM DELETED)
	END


CREATE TRIGGER trgSegurancaViewPiquete
        ON vwPiquete
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK


CREATE TRIGGER trgSegurancaViewRaca
        ON vwRaca
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaRacaManter
    ON tblRaca
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK


CREATE TRIGGER trgSegurancaViewAnimal
        ON vwAnimal
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaAnimalManter
    ON tblAnimal
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK


CREATE TRIGGER trgSegurancaViewPesagem
        ON vwPesagem
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK


CREATE TRIGGER trgSegurancaViewUltimaPesagemAnimal
        ON vwUltimaPesagemAnimal
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK

			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaPesagemManter
    ON tblPesagem
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

			
CREATE TRIGGER trgSegurancaViewVeterinario
        ON vwVeterinario
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaVeterinarioManter
    ON tblVeterinario
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewConsultaVeterinaria
        ON vwConsultaVeterinaria
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaConsultaVeterinariaManter
    ON tblConsultaVeterinaria
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewListaVeterinario
        ON vwListaVeterinario
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaListaVeterinarioManter
    ON tblListaVeterinario
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewListaCompra
        ON vwListaCompra
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewCompra
        ON vwCompra
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaCompraManter
    ON tblCompra
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaViewListaVenda
        ON vwListaVenda
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
CREATE TRIGGER trgSegurancaViewVenda
        ON vwVenda
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'Não é permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK

CREATE TRIGGER trgSegurancaVendaManter
    ON tblVenda
    INSTEAD OF DELETE
    AS
            PRINT  'Não é permitido alterar nenhum dado desta tabela.' 
            ROLLBACK