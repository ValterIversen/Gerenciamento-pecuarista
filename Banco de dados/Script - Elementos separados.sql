
BEGIN-- Tipo Usu�rio
CREATE TABLE tblTipoUsuario(
	TipoUsuarioID INT PRIMARY KEY IDENTITY(1,1),
	TipoUsuarioDescricao VARCHAR(40)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwTipoUsuario AS (
    SELECT TipoUsuarioID, TipoUsuarioDescricao
    FROM tblTipoUsuario
)

INSERT tblTipoUsuario VALUES ('Administrador')
INSERT tblTipoUsuario VALUES ('Funcion�rio')


-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewTipoUsuario
        ON vwTipoUsuario 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaTipoUsuarioManter
    ON tblTipoUsuario
    INSTEAD OF INSERT, UPDATE, DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- Usu�rio
CREATE TABLE tblUsuario(
	UsuarioID INT PRIMARY KEY IDENTITY(1,1),
	UsuarioLogin VARCHAR(15) NOT NULL,
	UsuarioSenha VARCHAR(32) NOT NULL,
	UsuarioNome  VARCHAR(60) NOT NULL,
	UsuarioAtivo BIT NOT NULL,
	TipoUsuarioID INT NOT NULL,

	CONSTRAINT UQ_UsuarioLogin UNIQUE (UsuarioLogin),
	CONSTRAINT FK_Usuario_TipoUsuario FOREIGN KEY (TipoUsuarioID) REFERENCES tblTipoUsuario (TipoUsuarioID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwUsuario AS (
    SELECT u.UsuarioID, u.UsuarioLogin, u.UsuarioSenha, u.UsuarioNome, u.UsuarioAtivo,
	tu.TipoUsuarioID, tu.TipoUsuarioDescricao
    FROM tblUsuario u
	INNER JOIN vwTipoUsuario tu ON (u.TipoUsuarioID = tu.TipoUsuarioID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewUsuario
        ON vwUsuario 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaUsuarioManter
    ON tblUsuario
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END
		


		
BEGIN-- Estado
CREATE TABLE tblEstado(
	EstadoID INT PRIMARY KEY IDENTITY(1,1),
	EstadoNome VARCHAR(50) NOT NULL,
	EstadoSigla VARCHAR(2) NOT NULL
)

-- Antes de criar uma trigger que bloqueia os INSERT na tabela, devemos realizar os insert dos dados necess�rios

insert tblEstado values ('Acre', 'AC');
insert tblEstado values ('Alagoas', 'AL');
insert tblEstado values ('Amap�', 'AP');
insert tblEstado values ('Amazonas', 'AM');
insert tblEstado values ('Bahia', 'BA');
insert tblEstado values ('Cear�', 'CE');
insert tblEstado values ('Distrito Federal', 'DF');
insert tblEstado values ('Esp�rito Santo', 'ES');
insert tblEstado values ('Goi�s', 'GO');
insert tblEstado values ('Maranh�o', 'MA');
insert tblEstado values ('Mato Grosso', 'MT');
insert tblEstado values ('Mato Grosso do Sul', 'MS');
insert tblEstado values ('Minas Gerais', 'MG');
insert tblEstado values ('Par�', 'PA');
insert tblEstado values ('Para�ba', 'PB');
insert tblEstado values ('Paran�', 'PR');
insert tblEstado values ('Pernambuco', 'PE');
insert tblEstado values ('Piau�', 'PI');
insert tblEstado values ('Rio de Janeiro', 'RJ');
insert tblEstado values ('Rio Grande do Norte', 'RN');
insert tblEstado values ('Rio Grande do Sul', 'RS');
insert tblEstado values ('Rond�nia', 'RO');
insert tblEstado values ('Roraima', 'RR');
insert tblEstado values ('Santa Catarina', 'SC');
insert tblEstado values ('S�o Paulo', 'SP');
insert tblEstado values ('Sergipe', 'SE');
insert tblEstado values ('Tocantins', 'TO');


/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwEstado AS (
    SELECT EstadoID, EstadoNome, EstadoSigla
    FROM tblEstado
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewEstado
        ON vwEstado 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaEstadoManter
    ON tblEstado
    INSTEAD OF INSERT, UPDATE, DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK

END




BEGIN-- Cidade
CREATE TABLE tblCidade(
	CidadeID INT PRIMARY KEY IDENTITY(1,1),
	CidadeNome VARCHAR(60) NOT NULL,
	EstadoID INT NOT NULL,

	CONSTRAINT FK_Cidade_Estado FOREIGN KEY (EstadoID) REFERENCES tblEstado (EstadoID)
)

-- Antes de criar uma trigger que bloqueia os INSERT na tabela, devemos realizar os insert dos dados necess�rios

insert tblCIDADE values ('Acrel�ndia', 1);
insert tblCIDADE values ('Assis Brasil', 1);
insert tblCIDADE values ('Brasil�ia', 1);
insert tblCIDADE values ('Bujari', 1);
insert tblCIDADE values ('Capixaba', 1);
insert tblCIDADE values ('Cruzeiro do Sul', 1);
insert tblCIDADE values ('Epitaciol�ndia', 1);
insert tblCIDADE values ('Feij�', 1);
insert tblCIDADE values ('Jord�o', 1);
insert tblCIDADE values ('M�ncio Lima', 1);
insert tblCIDADE values ('Manoel Urbano', 1);
insert tblCIDADE values ('Marechal Thaumaturgo', 1);
insert tblCIDADE values ('Pl�cido de Castro', 1);
insert tblCIDADE values ('Porto Walter', 1);
insert tblCIDADE values ('Rio Branco', 1);
insert tblCIDADE values ('Rodrigues Alves', 1);
insert tblCIDADE values ('Santa Rosa do Purus', 1);
insert tblCIDADE values ('Senador Guiomard', 1);
insert tblCIDADE values ('Sena Madureira', 1);
insert tblCIDADE values ('Tarauac�', 1);
insert tblCIDADE values ('Xapuri', 1);
insert tblCIDADE values ('Porto Acre', 1);
insert tblCIDADE values ('�gua Branca', 2);
insert tblCIDADE values ('Anadia', 2);
insert tblCIDADE values ('Arapiraca', 2);
insert tblCIDADE values ('Atalaia', 2);
insert tblCIDADE values ('Barra de Santo Ant�nio', 2);
insert tblCIDADE values ('Barra de S�o Miguel', 2);
insert tblCIDADE values ('Batalha', 2);
insert tblCIDADE values ('Bel�m', 2);
insert tblCIDADE values ('Belo Monte', 2);
insert tblCIDADE values ('Boca da Mata', 2);
insert tblCIDADE values ('Branquinha', 2);
insert tblCIDADE values ('Cacimbinhas', 2);
insert tblCIDADE values ('Cajueiro', 2);
insert tblCIDADE values ('Campestre', 2);
insert tblCIDADE values ('Campo Alegre', 2);
insert tblCIDADE values ('Campo Grande', 2);
insert tblCIDADE values ('Canapi', 2);
insert tblCIDADE values ('Capela', 2);
insert tblCIDADE values ('Carneiros', 2);
insert tblCIDADE values ('Ch� Preta', 2);
insert tblCIDADE values ('Coit� do N�ia', 2);
insert tblCIDADE values ('Col�nia Leopoldina', 2);
insert tblCIDADE values ('Coqueiro Seco', 2);
insert tblCIDADE values ('Coruripe', 2);
insert tblCIDADE values ('Cra�bas', 2);
insert tblCIDADE values ('Delmiro Gouveia', 2);
insert tblCIDADE values ('Dois Riachos', 2);
insert tblCIDADE values ('Estrela de Alagoas', 2);
insert tblCIDADE values ('Feira Grande', 2);
insert tblCIDADE values ('Feliz Deserto', 2);
insert tblCIDADE values ('Flexeiras', 2);
insert tblCIDADE values ('Girau do Ponciano', 2);
insert tblCIDADE values ('Ibateguara', 2);
insert tblCIDADE values ('Igaci', 2);
insert tblCIDADE values ('Igreja Nova', 2);
insert tblCIDADE values ('Inhapi', 2);
insert tblCIDADE values ('Jacar� dos Homens', 2);
insert tblCIDADE values ('Jacu�pe', 2);
insert tblCIDADE values ('Japaratinga', 2);
insert tblCIDADE values ('Jaramataia', 2);
insert tblCIDADE values ('Jequi� da Praia', 2);
insert tblCIDADE values ('Joaquim Gomes', 2);
insert tblCIDADE values ('Jundi�', 2);
insert tblCIDADE values ('Junqueiro', 2);
insert tblCIDADE values ('Lagoa da Canoa', 2);
insert tblCIDADE values ('Limoeiro de Anadia', 2);
insert tblCIDADE values ('Macei�', 2);
insert tblCIDADE values ('Major Isidoro', 2);
insert tblCIDADE values ('Maragogi', 2);
insert tblCIDADE values ('Maravilha', 2);
insert tblCIDADE values ('Marechal Deodoro', 2);
insert tblCIDADE values ('Maribondo', 2);
insert tblCIDADE values ('Mar Vermelho', 2);
insert tblCIDADE values ('Mata Grande', 2);
insert tblCIDADE values ('Matriz de Camaragibe', 2);
insert tblCIDADE values ('Messias', 2);
insert tblCIDADE values ('Minador do Negr�o', 2);
insert tblCIDADE values ('Monteir�polis', 2);
insert tblCIDADE values ('Murici', 2);
insert tblCIDADE values ('Novo Lino', 2);
insert tblCIDADE values ('Olho d''�gua das Flores', 2);
insert tblCIDADE values ('Olho d''�gua do Casado', 2);
insert tblCIDADE values ('Olho d''�gua Grande', 2);
insert tblCIDADE values ('Oliven�a', 2);
insert tblCIDADE values ('Ouro Branco', 2);
insert tblCIDADE values ('Palestina', 2);
insert tblCIDADE values ('Palmeira dos �ndios', 2);
insert tblCIDADE values ('P�o de A��car', 2);
insert tblCIDADE values ('Pariconha', 2);
insert tblCIDADE values ('Paripueira', 2);
insert tblCIDADE values ('Passo de Camaragibe', 2);
insert tblCIDADE values ('Paulo Jacinto', 2);
insert tblCIDADE values ('Penedo', 2);
insert tblCIDADE values ('Pia�abu�u', 2);
insert tblCIDADE values ('Pilar', 2);
insert tblCIDADE values ('Pindoba', 2);
insert tblCIDADE values ('Piranhas', 2);
insert tblCIDADE values ('Po�o das Trincheiras', 2);
insert tblCIDADE values ('Porto Calvo', 2);
insert tblCIDADE values ('Porto de Pedras', 2);
insert tblCIDADE values ('Porto Real do Col�gio', 2);
insert tblCIDADE values ('Quebrangulo', 2);
insert tblCIDADE values ('Rio Largo', 2);
insert tblCIDADE values ('Roteiro', 2);
insert tblCIDADE values ('Santa Luzia do Norte', 2);
insert tblCIDADE values ('Santana do Ipanema', 2);
insert tblCIDADE values ('Santana do Munda�', 2);
insert tblCIDADE values ('S�o Br�s', 2);
insert tblCIDADE values ('S�o Jos� da Laje', 2);
insert tblCIDADE values ('S�o Jos� da Tapera', 2);
insert tblCIDADE values ('S�o Lu�s do Quitunde', 2);
insert tblCIDADE values ('S�o Miguel dos Campos', 2);
insert tblCIDADE values ('S�o Miguel dos Milagres', 2);
insert tblCIDADE values ('S�o Sebasti�o', 2);
insert tblCIDADE values ('Satuba', 2);
insert tblCIDADE values ('Senador Rui Palmeira', 2);
insert tblCIDADE values ('Tanque d''Arca', 2);
insert tblCIDADE values ('Taquarana', 2);
insert tblCIDADE values ('Teot�nio Vilela', 2);
insert tblCIDADE values ('Traipu', 2);
insert tblCIDADE values ('Uni�o dos Palmares', 2);
insert tblCIDADE values ('Vi�osa', 2);
insert tblCIDADE values ('Serra do Navio', 3);
insert tblCIDADE values ('Amap�', 3);
insert tblCIDADE values ('Pedra Branca do Amapari', 3);
insert tblCIDADE values ('Cal�oene', 3);
insert tblCIDADE values ('Cutias', 3);
insert tblCIDADE values ('Ferreira Gomes', 3);
insert tblCIDADE values ('Itaubal', 3);
insert tblCIDADE values ('Laranjal do Jari', 3);
insert tblCIDADE values ('Macap�', 3);
insert tblCIDADE values ('Mazag�o', 3);
insert tblCIDADE values ('Oiapoque', 3);
insert tblCIDADE values ('Porto Grande', 3);
insert tblCIDADE values ('Pracu�ba', 3);
insert tblCIDADE values ('Santana', 3);
insert tblCIDADE values ('Tartarugalzinho', 3);
insert tblCIDADE values ('Vit�ria do Jari', 3);
insert tblCIDADE values ('Alvar�es', 4);
insert tblCIDADE values ('Amatur�', 4);
insert tblCIDADE values ('Anam�', 4);
insert tblCIDADE values ('Anori', 4);
insert tblCIDADE values ('Apu�', 4);
insert tblCIDADE values ('Atalaia do Norte', 4);
insert tblCIDADE values ('Autazes', 4);
insert tblCIDADE values ('Barcelos', 4);
insert tblCIDADE values ('Barreirinha', 4);
insert tblCIDADE values ('Benjamin Constant', 4);
insert tblCIDADE values ('Beruri', 4);
insert tblCIDADE values ('Boa Vista do Ramos', 4);
insert tblCIDADE values ('Boca do Acre', 4);
insert tblCIDADE values ('Borba', 4);
insert tblCIDADE values ('Caapiranga', 4);
insert tblCIDADE values ('Canutama', 4);
insert tblCIDADE values ('Carauari', 4);
insert tblCIDADE values ('Careiro', 4);
insert tblCIDADE values ('Careiro da V�rzea', 4);
insert tblCIDADE values ('Coari', 4);
insert tblCIDADE values ('Codaj�s', 4);
insert tblCIDADE values ('Eirunep�', 4);
insert tblCIDADE values ('Envira', 4);
insert tblCIDADE values ('Fonte Boa', 4);
insert tblCIDADE values ('Guajar�', 4);
insert tblCIDADE values ('Humait�', 4);
insert tblCIDADE values ('Ipixuna', 4);
insert tblCIDADE values ('Iranduba', 4);
insert tblCIDADE values ('Itacoatiara', 4);
insert tblCIDADE values ('Itamarati', 4);
insert tblCIDADE values ('Itapiranga', 4);
insert tblCIDADE values ('Japur�', 4);
insert tblCIDADE values ('Juru�', 4);
insert tblCIDADE values ('Juta�', 4);
insert tblCIDADE values ('L�brea', 4);
insert tblCIDADE values ('Manacapuru', 4);
insert tblCIDADE values ('Manaquiri', 4);
insert tblCIDADE values ('Manaus', 4);
insert tblCIDADE values ('Manicor�', 4);
insert tblCIDADE values ('Mara�', 4);
insert tblCIDADE values ('Mau�s', 4);
insert tblCIDADE values ('Nhamund�', 4);
insert tblCIDADE values ('Nova Olinda do Norte', 4);
insert tblCIDADE values ('Novo Air�o', 4);
insert tblCIDADE values ('Novo Aripuan�', 4);
insert tblCIDADE values ('Parintins', 4);
insert tblCIDADE values ('Pauini', 4);
insert tblCIDADE values ('Presidente Figueiredo', 4);
insert tblCIDADE values ('Rio Preto da Eva', 4);
insert tblCIDADE values ('Santa Isabel do Rio Negro', 4);
insert tblCIDADE values ('Santo Ant�nio do I��', 4);
insert tblCIDADE values ('S�o Gabriel da Cachoeira', 4);
insert tblCIDADE values ('S�o Paulo de Oliven�a', 4);
insert tblCIDADE values ('S�o Sebasti�o do Uatum�', 4);
insert tblCIDADE values ('Silves', 4);
insert tblCIDADE values ('Tabatinga', 4);
insert tblCIDADE values ('Tapau�', 4);
insert tblCIDADE values ('Tef�', 4);
insert tblCIDADE values ('Tonantins', 4);
insert tblCIDADE values ('Uarini', 4);
insert tblCIDADE values ('Urucar�', 4);
insert tblCIDADE values ('Urucurituba', 4);
insert tblCIDADE values ('Aba�ra', 5);
insert tblCIDADE values ('Abar�', 5);
insert tblCIDADE values ('Acajutiba', 5);
insert tblCIDADE values ('Adustina', 5);
insert tblCIDADE values ('�gua Fria', 5);
insert tblCIDADE values ('�rico Cardoso', 5);
insert tblCIDADE values ('Aiquara', 5);
insert tblCIDADE values ('Alagoinhas', 5);
insert tblCIDADE values ('Alcoba�a', 5);
insert tblCIDADE values ('Almadina', 5);
insert tblCIDADE values ('Amargosa', 5);
insert tblCIDADE values ('Am�lia Rodrigues', 5);
insert tblCIDADE values ('Am�rica Dourada', 5);
insert tblCIDADE values ('Anag�', 5);
insert tblCIDADE values ('Andara�', 5);
insert tblCIDADE values ('Andorinha', 5);
insert tblCIDADE values ('Angical', 5);
insert tblCIDADE values ('Anguera', 5);
insert tblCIDADE values ('Antas', 5);
insert tblCIDADE values ('Ant�nio Cardoso', 5);
insert tblCIDADE values ('Ant�nio Gon�alves', 5);
insert tblCIDADE values ('Apor�', 5);
insert tblCIDADE values ('Apuarema', 5);
insert tblCIDADE values ('Aracatu', 5);
insert tblCIDADE values ('Ara�as', 5);
insert tblCIDADE values ('Araci', 5);
insert tblCIDADE values ('Aramari', 5);
insert tblCIDADE values ('Arataca', 5);
insert tblCIDADE values ('Aratu�pe', 5);
insert tblCIDADE values ('Aurelino Leal', 5);
insert tblCIDADE values ('Baian�polis', 5);
insert tblCIDADE values ('Baixa Grande', 5);
insert tblCIDADE values ('Banza�', 5);
insert tblCIDADE values ('Barra', 5);
insert tblCIDADE values ('Barra da Estiva', 5);
insert tblCIDADE values ('Barra do Cho�a', 5);
insert tblCIDADE values ('Barra do Mendes', 5);
insert tblCIDADE values ('Barra do Rocha', 5);
insert tblCIDADE values ('Barreiras', 5);
insert tblCIDADE values ('Barro Alto', 5);
insert tblCIDADE values ('Barrocas', 5);
insert tblCIDADE values ('Barro Preto', 5);
insert tblCIDADE values ('Belmonte', 5);
insert tblCIDADE values ('Belo Campo', 5);
insert tblCIDADE values ('Biritinga', 5);
insert tblCIDADE values ('Boa Nova', 5);
insert tblCIDADE values ('Boa Vista do Tupim', 5);
insert tblCIDADE values ('Bom Jesus da Lapa', 5);
insert tblCIDADE values ('Bom Jesus da Serra', 5);
insert tblCIDADE values ('Boninal', 5);
insert tblCIDADE values ('Bonito', 5);
insert tblCIDADE values ('Boquira', 5);
insert tblCIDADE values ('Botupor�', 5);
insert tblCIDADE values ('Brej�es', 5);
insert tblCIDADE values ('Brejol�ndia', 5);
insert tblCIDADE values ('Brotas de Maca�bas', 5);
insert tblCIDADE values ('Brumado', 5);
insert tblCIDADE values ('Buerarema', 5);
insert tblCIDADE values ('Buritirama', 5);
insert tblCIDADE values ('Caatiba', 5);
insert tblCIDADE values ('Cabaceiras do Paragua�u', 5);
insert tblCIDADE values ('Cachoeira', 5);
insert tblCIDADE values ('Cacul�', 5);
insert tblCIDADE values ('Ca�m', 5);
insert tblCIDADE values ('Caetanos', 5);
insert tblCIDADE values ('Caetit�', 5);
insert tblCIDADE values ('Cafarnaum', 5);
insert tblCIDADE values ('Cairu', 5);
insert tblCIDADE values ('Caldeir�o Grande', 5);
insert tblCIDADE values ('Camacan', 5);
insert tblCIDADE values ('Cama�ari', 5);
insert tblCIDADE values ('Camamu', 5);
insert tblCIDADE values ('Campo Alegre de Lourdes', 5);
insert tblCIDADE values ('Campo Formoso', 5);
insert tblCIDADE values ('Can�polis', 5);
insert tblCIDADE values ('Canarana', 5);
insert tblCIDADE values ('Canavieiras', 5);
insert tblCIDADE values ('Candeal', 5);
insert tblCIDADE values ('Candeias', 5);
insert tblCIDADE values ('Candiba', 5);
insert tblCIDADE values ('C�ndido Sales', 5);
insert tblCIDADE values ('Cansan��o', 5);
insert tblCIDADE values ('Canudos', 5);
insert tblCIDADE values ('Capela do Alto Alegre', 5);
insert tblCIDADE values ('Capim Grosso', 5);
insert tblCIDADE values ('Cara�bas', 5);
insert tblCIDADE values ('Caravelas', 5);
insert tblCIDADE values ('Cardeal da Silva', 5);
insert tblCIDADE values ('Carinhanha', 5);
insert tblCIDADE values ('Casa Nova', 5);
insert tblCIDADE values ('Castro Alves', 5);
insert tblCIDADE values ('Catol�ndia', 5);
insert tblCIDADE values ('Catu', 5);
insert tblCIDADE values ('Caturama', 5);
insert tblCIDADE values ('Central', 5);
insert tblCIDADE values ('Chorroch�', 5);
insert tblCIDADE values ('C�cero Dantas', 5);
insert tblCIDADE values ('Cip�', 5);
insert tblCIDADE values ('Coaraci', 5);
insert tblCIDADE values ('Cocos', 5);
insert tblCIDADE values ('Concei��o da Feira', 5);
insert tblCIDADE values ('Concei��o do Almeida', 5);
insert tblCIDADE values ('Concei��o do Coit�', 5);
insert tblCIDADE values ('Concei��o do Jacu�pe', 5);
insert tblCIDADE values ('Conde', 5);
insert tblCIDADE values ('Conde�ba', 5);
insert tblCIDADE values ('Contendas do Sincor�', 5);
insert tblCIDADE values ('Cora��o de Maria', 5);
insert tblCIDADE values ('Cordeiros', 5);
insert tblCIDADE values ('Coribe', 5);
insert tblCIDADE values ('Coronel Jo�o S�', 5);
insert tblCIDADE values ('Correntina', 5);
insert tblCIDADE values ('Cotegipe', 5);
insert tblCIDADE values ('Cravol�ndia', 5);
insert tblCIDADE values ('Cris�polis', 5);
insert tblCIDADE values ('Crist�polis', 5);
insert tblCIDADE values ('Cruz das Almas', 5);
insert tblCIDADE values ('Cura��', 5);
insert tblCIDADE values ('D�rio Meira', 5);
insert tblCIDADE values ('Dias d''�vila', 5);
insert tblCIDADE values ('Dom Bas�lio', 5);
insert tblCIDADE values ('Dom Macedo Costa', 5);
insert tblCIDADE values ('El�sio Medrado', 5);
insert tblCIDADE values ('Encruzilhada', 5);
insert tblCIDADE values ('Entre Rios', 5);
insert tblCIDADE values ('Esplanada', 5);
insert tblCIDADE values ('Euclides da Cunha', 5);
insert tblCIDADE values ('Eun�polis', 5);
insert tblCIDADE values ('F�tima', 5);
insert tblCIDADE values ('Feira da Mata', 5);
insert tblCIDADE values ('Feira de Santana', 5);
insert tblCIDADE values ('Filad�lfia', 5);
insert tblCIDADE values ('Firmino Alves', 5);
insert tblCIDADE values ('Floresta Azul', 5);
insert tblCIDADE values ('Formosa do Rio Preto', 5);
insert tblCIDADE values ('Gandu', 5);
insert tblCIDADE values ('Gavi�o', 5);
insert tblCIDADE values ('Gentio do Ouro', 5);
insert tblCIDADE values ('Gl�ria', 5);
insert tblCIDADE values ('Gongogi', 5);
insert tblCIDADE values ('Governador Mangabeira', 5);
insert tblCIDADE values ('Guajeru', 5);
insert tblCIDADE values ('Guanambi', 5);
insert tblCIDADE values ('Guaratinga', 5);
insert tblCIDADE values ('Heli�polis', 5);
insert tblCIDADE values ('Ia�u', 5);
insert tblCIDADE values ('Ibiassuc�', 5);
insert tblCIDADE values ('Ibicara�', 5);
insert tblCIDADE values ('Ibicoara', 5);
insert tblCIDADE values ('Ibicu�', 5);
insert tblCIDADE values ('Ibipeba', 5);
insert tblCIDADE values ('Ibipitanga', 5);
insert tblCIDADE values ('Ibiquera', 5);
insert tblCIDADE values ('Ibirapitanga', 5);
insert tblCIDADE values ('Ibirapu�', 5);
insert tblCIDADE values ('Ibirataia', 5);
insert tblCIDADE values ('Ibitiara', 5);
insert tblCIDADE values ('Ibitit�', 5);
insert tblCIDADE values ('Ibotirama', 5);
insert tblCIDADE values ('Ichu', 5);
insert tblCIDADE values ('Igapor�', 5);
insert tblCIDADE values ('Igrapi�na', 5);
insert tblCIDADE values ('Igua�', 5);
insert tblCIDADE values ('Ilh�us', 5);
insert tblCIDADE values ('Inhambupe', 5);
insert tblCIDADE values ('Ipecaet�', 5);
insert tblCIDADE values ('Ipia�', 5);
insert tblCIDADE values ('Ipir�', 5);
insert tblCIDADE values ('Ipupiara', 5);
insert tblCIDADE values ('Irajuba', 5);
insert tblCIDADE values ('Iramaia', 5);
insert tblCIDADE values ('Iraquara', 5);
insert tblCIDADE values ('Irar�', 5);
insert tblCIDADE values ('Irec�', 5);
insert tblCIDADE values ('Itabela', 5);
insert tblCIDADE values ('Itaberaba', 5);
insert tblCIDADE values ('Itabuna', 5);
insert tblCIDADE values ('Itacar�', 5);
insert tblCIDADE values ('Itaet�', 5);
insert tblCIDADE values ('Itagi', 5);
insert tblCIDADE values ('Itagib�', 5);
insert tblCIDADE values ('Itagimirim', 5);
insert tblCIDADE values ('Itagua�u da Bahia', 5);
insert tblCIDADE values ('Itaju do Col�nia', 5);
insert tblCIDADE values ('Itaju�pe', 5);
insert tblCIDADE values ('Itamaraju', 5);
insert tblCIDADE values ('Itamari', 5);
insert tblCIDADE values ('Itamb�', 5);
insert tblCIDADE values ('Itanagra', 5);
insert tblCIDADE values ('Itanh�m', 5);
insert tblCIDADE values ('Itaparica', 5);
insert tblCIDADE values ('Itap�', 5);
insert tblCIDADE values ('Itapebi', 5);
insert tblCIDADE values ('Itapetinga', 5);
insert tblCIDADE values ('Itapicuru', 5);
insert tblCIDADE values ('Itapitanga', 5);
insert tblCIDADE values ('Itaquara', 5);
insert tblCIDADE values ('Itarantim', 5);
insert tblCIDADE values ('Itatim', 5);
insert tblCIDADE values ('Itiru�u', 5);
insert tblCIDADE values ('Iti�ba', 5);
insert tblCIDADE values ('Itoror�', 5);
insert tblCIDADE values ('Itua�u', 5);
insert tblCIDADE values ('Ituber�', 5);
insert tblCIDADE values ('Iui�', 5);
insert tblCIDADE values ('Jaborandi', 5);
insert tblCIDADE values ('Jacaraci', 5);
insert tblCIDADE values ('Jacobina', 5);
insert tblCIDADE values ('Jaguaquara', 5);
insert tblCIDADE values ('Jaguarari', 5);
insert tblCIDADE values ('Jaguaripe', 5);
insert tblCIDADE values ('Janda�ra', 5);
insert tblCIDADE values ('Jequi�', 5);
insert tblCIDADE values ('Jeremoabo', 5);
insert tblCIDADE values ('Jiquiri��', 5);
insert tblCIDADE values ('Jita�na', 5);
insert tblCIDADE values ('Jo�o Dourado', 5);
insert tblCIDADE values ('Juazeiro', 5);
insert tblCIDADE values ('Jucuru�u', 5);
insert tblCIDADE values ('Jussara', 5);
insert tblCIDADE values ('Jussari', 5);
insert tblCIDADE values ('Jussiape', 5);
insert tblCIDADE values ('Lafaiete Coutinho', 5);
insert tblCIDADE values ('Lagoa Real', 5);
insert tblCIDADE values ('Laje', 5);
insert tblCIDADE values ('Lajed�o', 5);
insert tblCIDADE values ('Lajedinho', 5);
insert tblCIDADE values ('Lajedo do Tabocal', 5);
insert tblCIDADE values ('Lamar�o', 5);
insert tblCIDADE values ('Lap�o', 5);
insert tblCIDADE values ('Lauro de Freitas', 5);
insert tblCIDADE values ('Len��is', 5);
insert tblCIDADE values ('Lic�nio de Almeida', 5);
insert tblCIDADE values ('Livramento de Nossa Senhora', 5);
insert tblCIDADE values ('Lu�s Eduardo Magalh�es', 5);
insert tblCIDADE values ('Macajuba', 5);
insert tblCIDADE values ('Macarani', 5);
insert tblCIDADE values ('Maca�bas', 5);
insert tblCIDADE values ('Macurur�', 5);
insert tblCIDADE values ('Madre de Deus', 5);
insert tblCIDADE values ('Maetinga', 5);
insert tblCIDADE values ('Maiquinique', 5);
insert tblCIDADE values ('Mairi', 5);
insert tblCIDADE values ('Malhada', 5);
insert tblCIDADE values ('Malhada de Pedras', 5);
insert tblCIDADE values ('Manoel Vitorino', 5);
insert tblCIDADE values ('Mansid�o', 5);
insert tblCIDADE values ('Marac�s', 5);
insert tblCIDADE values ('Maragogipe', 5);
insert tblCIDADE values ('Mara�', 5);
insert tblCIDADE values ('Marcion�lio Souza', 5);
insert tblCIDADE values ('Mascote', 5);
insert tblCIDADE values ('Mata de S�o Jo�o', 5);
insert tblCIDADE values ('Matina', 5);
insert tblCIDADE values ('Medeiros Neto', 5);
insert tblCIDADE values ('Miguel Calmon', 5);
insert tblCIDADE values ('Milagres', 5);
insert tblCIDADE values ('Mirangaba', 5);
insert tblCIDADE values ('Mirante', 5);
insert tblCIDADE values ('Monte Santo', 5);
insert tblCIDADE values ('Morpar�', 5);
insert tblCIDADE values ('Morro do Chap�u', 5);
insert tblCIDADE values ('Mortugaba', 5);
insert tblCIDADE values ('Mucug�', 5);
insert tblCIDADE values ('Mucuri', 5);
insert tblCIDADE values ('Mulungu do Morro', 5);
insert tblCIDADE values ('Mundo Novo', 5);
insert tblCIDADE values ('Muniz Ferreira', 5);
insert tblCIDADE values ('Muqu�m de S�o Francisco', 5);
insert tblCIDADE values ('Muritiba', 5);
insert tblCIDADE values ('Mutu�pe', 5);
insert tblCIDADE values ('Nazar�', 5);
insert tblCIDADE values ('Nilo Pe�anha', 5);
insert tblCIDADE values ('Nordestina', 5);
insert tblCIDADE values ('Nova Cana�', 5);
insert tblCIDADE values ('Nova F�tima', 5);
insert tblCIDADE values ('Nova Ibi�', 5);
insert tblCIDADE values ('Nova Itarana', 5);
insert tblCIDADE values ('Nova Reden��o', 5);
insert tblCIDADE values ('Nova Soure', 5);
insert tblCIDADE values ('Nova Vi�osa', 5);
insert tblCIDADE values ('Novo Horizonte', 5);
insert tblCIDADE values ('Novo Triunfo', 5);
insert tblCIDADE values ('Olindina', 5);
insert tblCIDADE values ('Oliveira dos Brejinhos', 5);
insert tblCIDADE values ('Ouri�angas', 5);
insert tblCIDADE values ('Ourol�ndia', 5);
insert tblCIDADE values ('Palmas de Monte Alto', 5);
insert tblCIDADE values ('Palmeiras', 5);
insert tblCIDADE values ('Paramirim', 5);
insert tblCIDADE values ('Paratinga', 5);
insert tblCIDADE values ('Paripiranga', 5);
insert tblCIDADE values ('Pau Brasil', 5);
insert tblCIDADE values ('Paulo Afonso', 5);
insert tblCIDADE values ('P� de Serra', 5);
insert tblCIDADE values ('Pedr�o', 5);
insert tblCIDADE values ('Pedro Alexandre', 5);
insert tblCIDADE values ('Piat�', 5);
insert tblCIDADE values ('Pil�o Arcado', 5);
insert tblCIDADE values ('Pinda�', 5);
insert tblCIDADE values ('Pindoba�u', 5);
insert tblCIDADE values ('Pintadas', 5);
insert tblCIDADE values ('Pira� do Norte', 5);
insert tblCIDADE values ('Pirip�', 5);
insert tblCIDADE values ('Piritiba', 5);
insert tblCIDADE values ('Planaltino', 5);
insert tblCIDADE values ('Planalto', 5);
insert tblCIDADE values ('Po��es', 5);
insert tblCIDADE values ('Pojuca', 5);
insert tblCIDADE values ('Ponto Novo', 5);
insert tblCIDADE values ('Porto Seguro', 5);
insert tblCIDADE values ('Potiragu�', 5);
insert tblCIDADE values ('Prado', 5);
insert tblCIDADE values ('Presidente Dutra', 5);
insert tblCIDADE values ('Presidente J�nio Quadros', 5);
insert tblCIDADE values ('Presidente Tancredo Neves', 5);
insert tblCIDADE values ('Queimadas', 5);
insert tblCIDADE values ('Quijingue', 5);
insert tblCIDADE values ('Quixabeira', 5);
insert tblCIDADE values ('Rafael Jambeiro', 5);
insert tblCIDADE values ('Remanso', 5);
insert tblCIDADE values ('Retirol�ndia', 5);
insert tblCIDADE values ('Riach�o das Neves', 5);
insert tblCIDADE values ('Riach�o do Jacu�pe', 5);
insert tblCIDADE values ('Riacho de Santana', 5);
insert tblCIDADE values ('Ribeira do Amparo', 5);
insert tblCIDADE values ('Ribeira do Pombal', 5);
insert tblCIDADE values ('Ribeir�o do Largo', 5);
insert tblCIDADE values ('Rio de Contas', 5);
insert tblCIDADE values ('Rio do Ant�nio', 5);
insert tblCIDADE values ('Rio do Pires', 5);
insert tblCIDADE values ('Rio Real', 5);
insert tblCIDADE values ('Rodelas', 5);
insert tblCIDADE values ('Ruy Barbosa', 5);
insert tblCIDADE values ('Salinas da Margarida', 5);
insert tblCIDADE values ('Salvador', 5);
insert tblCIDADE values ('Santa B�rbara', 5);
insert tblCIDADE values ('Santa Br�gida', 5);
insert tblCIDADE values ('Santa Cruz Cabr�lia', 5);
insert tblCIDADE values ('Santa Cruz da Vit�ria', 5);
insert tblCIDADE values ('Santa In�s', 5);
insert tblCIDADE values ('Santaluz', 5);
insert tblCIDADE values ('Santa Luzia', 5);
insert tblCIDADE values ('Santa Maria da Vit�ria', 5);
insert tblCIDADE values ('Santana', 5);
insert tblCIDADE values ('Santan�polis', 5);
insert tblCIDADE values ('Santa Rita de C�ssia', 5);
insert tblCIDADE values ('Santa Teresinha', 5);
insert tblCIDADE values ('Santo Amaro', 5);
insert tblCIDADE values ('Santo Ant�nio de Jesus', 5);
insert tblCIDADE values ('Santo Est�v�o', 5);
insert tblCIDADE values ('S�o Desid�rio', 5);
insert tblCIDADE values ('S�o Domingos', 5);
insert tblCIDADE values ('S�o F�lix', 5);
insert tblCIDADE values ('S�o F�lix do Coribe', 5);
insert tblCIDADE values ('S�o Felipe', 5);
insert tblCIDADE values ('S�o Francisco do Conde', 5);
insert tblCIDADE values ('S�o Gabriel', 5);
insert tblCIDADE values ('S�o Gon�alo dos Campos', 5);
insert tblCIDADE values ('S�o Jos� da Vit�ria', 5);
insert tblCIDADE values ('S�o Jos� do Jacu�pe', 5);
insert tblCIDADE values ('S�o Miguel das Matas', 5);
insert tblCIDADE values ('S�o Sebasti�o do Pass�', 5);
insert tblCIDADE values ('Sapea�u', 5);
insert tblCIDADE values ('S�tiro Dias', 5);
insert tblCIDADE values ('Saubara', 5);
insert tblCIDADE values ('Sa�de', 5);
insert tblCIDADE values ('Seabra', 5);
insert tblCIDADE values ('Sebasti�o Laranjeiras', 5);
insert tblCIDADE values ('Senhor do Bonfim', 5);
insert tblCIDADE values ('Serra do Ramalho', 5);
insert tblCIDADE values ('Sento S�', 5);
insert tblCIDADE values ('Serra Dourada', 5);
insert tblCIDADE values ('Serra Preta', 5);
insert tblCIDADE values ('Serrinha', 5);
insert tblCIDADE values ('Serrol�ndia', 5);
insert tblCIDADE values ('Sim�es Filho', 5);
insert tblCIDADE values ('S�tio do Mato', 5);
insert tblCIDADE values ('S�tio do Quinto', 5);
insert tblCIDADE values ('Sobradinho', 5);
insert tblCIDADE values ('Souto Soares', 5);
insert tblCIDADE values ('Tabocas do Brejo Velho', 5);
insert tblCIDADE values ('Tanha�u', 5);
insert tblCIDADE values ('Tanque Novo', 5);
insert tblCIDADE values ('Tanquinho', 5);
insert tblCIDADE values ('Tapero�', 5);
insert tblCIDADE values ('Tapiramut�', 5);
insert tblCIDADE values ('Teixeira de Freitas', 5);
insert tblCIDADE values ('Teodoro Sampaio', 5);
insert tblCIDADE values ('Teofil�ndia', 5);
insert tblCIDADE values ('Teol�ndia', 5);
insert tblCIDADE values ('Terra Nova', 5);
insert tblCIDADE values ('Tremedal', 5);
insert tblCIDADE values ('Tucano', 5);
insert tblCIDADE values ('Uau�', 5);
insert tblCIDADE values ('Uba�ra', 5);
insert tblCIDADE values ('Ubaitaba', 5);
insert tblCIDADE values ('Ubat�', 5);
insert tblCIDADE values ('Uiba�', 5);
insert tblCIDADE values ('Umburanas', 5);
insert tblCIDADE values ('Una', 5);
insert tblCIDADE values ('Urandi', 5);
insert tblCIDADE values ('Uru�uca', 5);
insert tblCIDADE values ('Utinga', 5);
insert tblCIDADE values ('Valen�a', 5);
insert tblCIDADE values ('Valente', 5);
insert tblCIDADE values ('V�rzea da Ro�a', 5);
insert tblCIDADE values ('V�rzea do Po�o', 5);
insert tblCIDADE values ('V�rzea Nova', 5);
insert tblCIDADE values ('Varzedo', 5);
insert tblCIDADE values ('Vera Cruz', 5);
insert tblCIDADE values ('Vereda', 5);
insert tblCIDADE values ('Vit�ria da Conquista', 5);
insert tblCIDADE values ('Wagner', 5);
insert tblCIDADE values ('Wanderley', 5);
insert tblCIDADE values ('Wenceslau Guimar�es', 5);
insert tblCIDADE values ('Xique-Xique', 5);
insert tblCIDADE values ('Abaiara', 6);
insert tblCIDADE values ('Acarape', 6);
insert tblCIDADE values ('Acara�', 6);
insert tblCIDADE values ('Acopiara', 6);
insert tblCIDADE values ('Aiuaba', 6);
insert tblCIDADE values ('Alc�ntaras', 6);
insert tblCIDADE values ('Altaneira', 6);
insert tblCIDADE values ('Alto Santo', 6);
insert tblCIDADE values ('Amontada', 6);
insert tblCIDADE values ('Antonina do Norte', 6);
insert tblCIDADE values ('Apuiar�s', 6);
insert tblCIDADE values ('Aquiraz', 6);
insert tblCIDADE values ('Aracati', 6);
insert tblCIDADE values ('Aracoiaba', 6);
insert tblCIDADE values ('Ararend�', 6);
insert tblCIDADE values ('Araripe', 6);
insert tblCIDADE values ('Aratuba', 6);
insert tblCIDADE values ('Arneiroz', 6);
insert tblCIDADE values ('Assar�', 6);
insert tblCIDADE values ('Aurora', 6);
insert tblCIDADE values ('Baixio', 6);
insert tblCIDADE values ('Banabui�', 6);
insert tblCIDADE values ('Barbalha', 6);
insert tblCIDADE values ('Barreira', 6);
insert tblCIDADE values ('Barro', 6);
insert tblCIDADE values ('Barroquinha', 6);
insert tblCIDADE values ('Baturit�', 6);
insert tblCIDADE values ('Beberibe', 6);
insert tblCIDADE values ('Bela Cruz', 6);
insert tblCIDADE values ('Boa Viagem', 6);
insert tblCIDADE values ('Brejo Santo', 6);
insert tblCIDADE values ('Camocim', 6);
insert tblCIDADE values ('Campos Sales', 6);
insert tblCIDADE values ('Canind�', 6);
insert tblCIDADE values ('Capistrano', 6);
insert tblCIDADE values ('Caridade', 6);
insert tblCIDADE values ('Carir�', 6);
insert tblCIDADE values ('Cariria�u', 6);
insert tblCIDADE values ('Cari�s', 6);
insert tblCIDADE values ('Carnaubal', 6);
insert tblCIDADE values ('Cascavel', 6);
insert tblCIDADE values ('Catarina', 6);
insert tblCIDADE values ('Catunda', 6);
insert tblCIDADE values ('Caucaia', 6);
insert tblCIDADE values ('Cedro', 6);
insert tblCIDADE values ('Chaval', 6);
insert tblCIDADE values ('Chor�', 6);
insert tblCIDADE values ('Chorozinho', 6);
insert tblCIDADE values ('Corea�', 6);
insert tblCIDADE values ('Crate�s', 6);
insert tblCIDADE values ('Crato', 6);
insert tblCIDADE values ('Croat�', 6);
insert tblCIDADE values ('Cruz', 6);
insert tblCIDADE values ('Deputado Irapuan Pinheiro', 6);
insert tblCIDADE values ('Erer�', 6);
insert tblCIDADE values ('Eus�bio', 6);
insert tblCIDADE values ('Farias Brito', 6);
insert tblCIDADE values ('Forquilha', 6);
insert tblCIDADE values ('Fortaleza', 6);
insert tblCIDADE values ('Fortim', 6);
insert tblCIDADE values ('Frecheirinha', 6);
insert tblCIDADE values ('General Sampaio', 6);
insert tblCIDADE values ('Gra�a', 6);
insert tblCIDADE values ('Granja', 6);
insert tblCIDADE values ('Granjeiro', 6);
insert tblCIDADE values ('Groa�ras', 6);
insert tblCIDADE values ('Guai�ba', 6);
insert tblCIDADE values ('Guaraciaba do Norte', 6);
insert tblCIDADE values ('Guaramiranga', 6);
insert tblCIDADE values ('Hidrol�ndia', 6);
insert tblCIDADE values ('Horizonte', 6);
insert tblCIDADE values ('Ibaretama', 6);
insert tblCIDADE values ('Ibiapina', 6);
insert tblCIDADE values ('Ibicuitinga', 6);
insert tblCIDADE values ('Icapu�', 6);
insert tblCIDADE values ('Ic�', 6);
insert tblCIDADE values ('Iguatu', 6);
insert tblCIDADE values ('Independ�ncia', 6);
insert tblCIDADE values ('Ipaporanga', 6);
insert tblCIDADE values ('Ipaumirim', 6);
insert tblCIDADE values ('Ipu', 6);
insert tblCIDADE values ('Ipueiras', 6);
insert tblCIDADE values ('Iracema', 6);
insert tblCIDADE values ('Irau�uba', 6);
insert tblCIDADE values ('Itai�aba', 6);
insert tblCIDADE values ('Itaitinga', 6);
insert tblCIDADE values ('Itapag�', 6);
insert tblCIDADE values ('Itapipoca', 6);
insert tblCIDADE values ('Itapi�na', 6);
insert tblCIDADE values ('Itarema', 6);
insert tblCIDADE values ('Itatira', 6);
insert tblCIDADE values ('Jaguaretama', 6);
insert tblCIDADE values ('Jaguaribara', 6);
insert tblCIDADE values ('Jaguaribe', 6);
insert tblCIDADE values ('Jaguaruana', 6);
insert tblCIDADE values ('Jardim', 6);
insert tblCIDADE values ('Jati', 6);
insert tblCIDADE values ('Jijoca de Jericoacoara', 6);
insert tblCIDADE values ('Juazeiro do Norte', 6);
insert tblCIDADE values ('Juc�s', 6);
insert tblCIDADE values ('Lavras da Mangabeira', 6);
insert tblCIDADE values ('Limoeiro do Norte', 6);
insert tblCIDADE values ('Madalena', 6);
insert tblCIDADE values ('Maracana�', 6);
insert tblCIDADE values ('Maranguape', 6);
insert tblCIDADE values ('Marco', 6);
insert tblCIDADE values ('Martin�pole', 6);
insert tblCIDADE values ('Massap�', 6);
insert tblCIDADE values ('Mauriti', 6);
insert tblCIDADE values ('Meruoca', 6);
insert tblCIDADE values ('Milagres', 6);
insert tblCIDADE values ('Milh�', 6);
insert tblCIDADE values ('Mira�ma', 6);
insert tblCIDADE values ('Miss�o Velha', 6);
insert tblCIDADE values ('Momba�a', 6);
insert tblCIDADE values ('Monsenhor Tabosa', 6);
insert tblCIDADE values ('Morada Nova', 6);
insert tblCIDADE values ('Mora�jo', 6);
insert tblCIDADE values ('Morrinhos', 6);
insert tblCIDADE values ('Mucambo', 6);
insert tblCIDADE values ('Mulungu', 6);
insert tblCIDADE values ('Nova Olinda', 6);
insert tblCIDADE values ('Nova Russas', 6);
insert tblCIDADE values ('Novo Oriente', 6);
insert tblCIDADE values ('Ocara', 6);
insert tblCIDADE values ('Or�s', 6);
insert tblCIDADE values ('Pacajus', 6);
insert tblCIDADE values ('Pacatuba', 6);
insert tblCIDADE values ('Pacoti', 6);
insert tblCIDADE values ('Pacuj�', 6);
insert tblCIDADE values ('Palhano', 6);
insert tblCIDADE values ('Palm�cia', 6);
insert tblCIDADE values ('Paracuru', 6);
insert tblCIDADE values ('Paraipaba', 6);
insert tblCIDADE values ('Parambu', 6);
insert tblCIDADE values ('Paramoti', 6);
insert tblCIDADE values ('Pedra Branca', 6);
insert tblCIDADE values ('Penaforte', 6);
insert tblCIDADE values ('Pentecoste', 6);
insert tblCIDADE values ('Pereiro', 6);
insert tblCIDADE values ('Pindoretama', 6);
insert tblCIDADE values ('Piquet Carneiro', 6);
insert tblCIDADE values ('Pires Ferreira', 6);
insert tblCIDADE values ('Poranga', 6);
insert tblCIDADE values ('Porteiras', 6);
insert tblCIDADE values ('Potengi', 6);
insert tblCIDADE values ('Potiretama', 6);
insert tblCIDADE values ('Quiterian�polis', 6);
insert tblCIDADE values ('Quixad�', 6);
insert tblCIDADE values ('Quixel�', 6);
insert tblCIDADE values ('Quixeramobim', 6);
insert tblCIDADE values ('Quixer�', 6);
insert tblCIDADE values ('Reden��o', 6);
insert tblCIDADE values ('Reriutaba', 6);
insert tblCIDADE values ('Russas', 6);
insert tblCIDADE values ('Saboeiro', 6);
insert tblCIDADE values ('Salitre', 6);
insert tblCIDADE values ('Santana do Acara�', 6);
insert tblCIDADE values ('Santana do Cariri', 6);
insert tblCIDADE values ('Santa Quit�ria', 6);
insert tblCIDADE values ('S�o Benedito', 6);
insert tblCIDADE values ('S�o Gon�alo do Amarante', 6);
insert tblCIDADE values ('S�o Jo�o do Jaguaribe', 6);
insert tblCIDADE values ('S�o Lu�s do Curu', 6);
insert tblCIDADE values ('Senador Pompeu', 6);
insert tblCIDADE values ('Senador S�', 6);
insert tblCIDADE values ('Sobral', 6);
insert tblCIDADE values ('Solon�pole', 6);
insert tblCIDADE values ('Tabuleiro do Norte', 6);
insert tblCIDADE values ('Tamboril', 6);
insert tblCIDADE values ('Tarrafas', 6);
insert tblCIDADE values ('Tau�', 6);
insert tblCIDADE values ('Teju�uoca', 6);
insert tblCIDADE values ('Tiangu�', 6);
insert tblCIDADE values ('Trairi', 6);
insert tblCIDADE values ('Tururu', 6);
insert tblCIDADE values ('Ubajara', 6);
insert tblCIDADE values ('Umari', 6);
insert tblCIDADE values ('Umirim', 6);
insert tblCIDADE values ('Uruburetama', 6);
insert tblCIDADE values ('Uruoca', 6);
insert tblCIDADE values ('Varjota', 6);
insert tblCIDADE values ('V�rzea Alegre', 6);
insert tblCIDADE values ('Vi�osa do Cear�', 6);
insert tblCIDADE values ('Bras�lia', 7);
insert tblCIDADE values ('Afonso Cl�udio', 8);
insert tblCIDADE values ('�guia Branca', 8);
insert tblCIDADE values ('�gua Doce do Norte', 8);
insert tblCIDADE values ('Alegre', 8);
insert tblCIDADE values ('Alfredo Chaves', 8);
insert tblCIDADE values ('Alto Rio Novo', 8);
insert tblCIDADE values ('Anchieta', 8);
insert tblCIDADE values ('Apiac�', 8);
insert tblCIDADE values ('Aracruz', 8);
insert tblCIDADE values ('Atilio Vivacqua', 8);
insert tblCIDADE values ('Baixo Guandu', 8);
insert tblCIDADE values ('Barra de S�o Francisco', 8);
insert tblCIDADE values ('Boa Esperan�a', 8);
insert tblCIDADE values ('Bom Jesus do Norte', 8);
insert tblCIDADE values ('Brejetuba', 8);
insert tblCIDADE values ('Cachoeiro de Itapemirim', 8);
insert tblCIDADE values ('Cariacica', 8);
insert tblCIDADE values ('Castelo', 8);
insert tblCIDADE values ('Colatina', 8);
insert tblCIDADE values ('Concei��o da Barra', 8);
insert tblCIDADE values ('Concei��o do Castelo', 8);
insert tblCIDADE values ('Divino de S�o Louren�o', 8);
insert tblCIDADE values ('Domingos Martins', 8);
insert tblCIDADE values ('Dores do Rio Preto', 8);
insert tblCIDADE values ('Ecoporanga', 8);
insert tblCIDADE values ('Fund�o', 8);
insert tblCIDADE values ('Governador Lindenberg', 8);
insert tblCIDADE values ('Gua�u�', 8);
insert tblCIDADE values ('Guarapari', 8);
insert tblCIDADE values ('Ibatiba', 8);
insert tblCIDADE values ('Ibira�u', 8);
insert tblCIDADE values ('Ibitirama', 8);
insert tblCIDADE values ('Iconha', 8);
insert tblCIDADE values ('Irupi', 8);
insert tblCIDADE values ('Itagua�u', 8);
insert tblCIDADE values ('Itapemirim', 8);
insert tblCIDADE values ('Itarana', 8);
insert tblCIDADE values ('I�na', 8);
insert tblCIDADE values ('Jaguar�', 8);
insert tblCIDADE values ('Jer�nimo Monteiro', 8);
insert tblCIDADE values ('Jo�o Neiva', 8);
insert tblCIDADE values ('Laranja da Terra', 8);
insert tblCIDADE values ('Linhares', 8);
insert tblCIDADE values ('Manten�polis', 8);
insert tblCIDADE values ('Marata�zes', 8);
insert tblCIDADE values ('Marechal Floriano', 8);
insert tblCIDADE values ('Maril�ndia', 8);
insert tblCIDADE values ('Mimoso do Sul', 8);
insert tblCIDADE values ('Montanha', 8);
insert tblCIDADE values ('Mucurici', 8);
insert tblCIDADE values ('Muniz Freire', 8);
insert tblCIDADE values ('Muqui', 8);
insert tblCIDADE values ('Nova Ven�cia', 8);
insert tblCIDADE values ('Pancas', 8);
insert tblCIDADE values ('Pedro Can�rio', 8);
insert tblCIDADE values ('Pinheiros', 8);
insert tblCIDADE values ('Pi�ma', 8);
insert tblCIDADE values ('Ponto Belo', 8);
insert tblCIDADE values ('Presidente Kennedy', 8);
insert tblCIDADE values ('Rio Bananal', 8);
insert tblCIDADE values ('Rio Novo do Sul', 8);
insert tblCIDADE values ('Santa Leopoldina', 8);
insert tblCIDADE values ('Santa Maria de Jetib�', 8);
insert tblCIDADE values ('Santa Teresa', 8);
insert tblCIDADE values ('S�o Domingos do Norte', 8);
insert tblCIDADE values ('S�o Gabriel da Palha', 8);
insert tblCIDADE values ('S�o Jos� do Cal�ado', 8);
insert tblCIDADE values ('S�o Mateus', 8);
insert tblCIDADE values ('S�o Roque do Cana�', 8);
insert tblCIDADE values ('Serra', 8);
insert tblCIDADE values ('Sooretama', 8);
insert tblCIDADE values ('Vargem Alta', 8);
insert tblCIDADE values ('Venda Nova do Imigrante', 8);
insert tblCIDADE values ('Viana', 8);
insert tblCIDADE values ('Vila Pav�o', 8);
insert tblCIDADE values ('Vila Val�rio', 8);
insert tblCIDADE values ('Vila Velha', 8);
insert tblCIDADE values ('Vit�ria', 8);
insert tblCIDADE values ('Abadia de Goi�s', 9);
insert tblCIDADE values ('Abadi�nia', 9);
insert tblCIDADE values ('Acre�na', 9);
insert tblCIDADE values ('Adel�ndia', 9);
insert tblCIDADE values ('�gua Fria de Goi�s', 9);
insert tblCIDADE values ('�gua Limpa', 9);
insert tblCIDADE values ('�guas Lindas de Goi�s', 9);
insert tblCIDADE values ('Alex�nia', 9);
insert tblCIDADE values ('Alo�ndia', 9);
insert tblCIDADE values ('Alto Horizonte', 9);
insert tblCIDADE values ('Alto Para�so de Goi�s', 9);
insert tblCIDADE values ('Alvorada do Norte', 9);
insert tblCIDADE values ('Amaralina', 9);
insert tblCIDADE values ('Americano do Brasil', 9);
insert tblCIDADE values ('Amorin�polis', 9);
insert tblCIDADE values ('An�polis', 9);
insert tblCIDADE values ('Anhanguera', 9);
insert tblCIDADE values ('Anicuns', 9);
insert tblCIDADE values ('Aparecida de Goi�nia', 9);
insert tblCIDADE values ('Aparecida do Rio Doce', 9);
insert tblCIDADE values ('Apor�', 9);
insert tblCIDADE values ('Ara�u', 9);
insert tblCIDADE values ('Aragar�as', 9);
insert tblCIDADE values ('Aragoi�nia', 9);
insert tblCIDADE values ('Araguapaz', 9);
insert tblCIDADE values ('Aren�polis', 9);
insert tblCIDADE values ('Aruan�', 9);
insert tblCIDADE values ('Auril�ndia', 9);
insert tblCIDADE values ('Avelin�polis', 9);
insert tblCIDADE values ('Baliza', 9);
insert tblCIDADE values ('Barro Alto', 9);
insert tblCIDADE values ('Bela Vista de Goi�s', 9);
insert tblCIDADE values ('Bom Jardim de Goi�s', 9);
insert tblCIDADE values ('Bom Jesus de Goi�s', 9);
insert tblCIDADE values ('Bonfin�polis', 9);
insert tblCIDADE values ('Bon�polis', 9);
insert tblCIDADE values ('Brazabrantes', 9);
insert tblCIDADE values ('Brit�nia', 9);
insert tblCIDADE values ('Buriti Alegre', 9);
insert tblCIDADE values ('Buriti de Goi�s', 9);
insert tblCIDADE values ('Buritin�polis', 9);
insert tblCIDADE values ('Cabeceiras', 9);
insert tblCIDADE values ('Cachoeira Alta', 9);
insert tblCIDADE values ('Cachoeira de Goi�s', 9);
insert tblCIDADE values ('Cachoeira Dourada', 9);
insert tblCIDADE values ('Ca�u', 9);
insert tblCIDADE values ('Caiap�nia', 9);
insert tblCIDADE values ('Caldas Novas', 9);
insert tblCIDADE values ('Caldazinha', 9);
insert tblCIDADE values ('Campestre de Goi�s', 9);
insert tblCIDADE values ('Campina�u', 9);
insert tblCIDADE values ('Campinorte', 9);
insert tblCIDADE values ('Campo Alegre de Goi�s', 9);
insert tblCIDADE values ('Campo Limpo de Goi�s', 9);
insert tblCIDADE values ('Campos Belos', 9);
insert tblCIDADE values ('Campos Verdes', 9);
insert tblCIDADE values ('Carmo do Rio Verde', 9);
insert tblCIDADE values ('Castel�ndia', 9);
insert tblCIDADE values ('Catal�o', 9);
insert tblCIDADE values ('Catura�', 9);
insert tblCIDADE values ('Cavalcante', 9);
insert tblCIDADE values ('Ceres', 9);
insert tblCIDADE values ('Cezarina', 9);
insert tblCIDADE values ('Chapad�o do C�u', 9);
insert tblCIDADE values ('Cidade Ocidental', 9);
insert tblCIDADE values ('Cocalzinho de Goi�s', 9);
insert tblCIDADE values ('Colinas do Sul', 9);
insert tblCIDADE values ('C�rrego do Ouro', 9);
insert tblCIDADE values ('Corumb� de Goi�s', 9);
insert tblCIDADE values ('Corumba�ba', 9);
insert tblCIDADE values ('Cristalina', 9);
insert tblCIDADE values ('Cristian�polis', 9);
insert tblCIDADE values ('Crix�s', 9);
insert tblCIDADE values ('Crom�nia', 9);
insert tblCIDADE values ('Cumari', 9);
insert tblCIDADE values ('Damian�polis', 9);
insert tblCIDADE values ('Damol�ndia', 9);
insert tblCIDADE values ('Davin�polis', 9);
insert tblCIDADE values ('Diorama', 9);
insert tblCIDADE values ('Doverl�ndia', 9);
insert tblCIDADE values ('Edealina', 9);
insert tblCIDADE values ('Ed�ia', 9);
insert tblCIDADE values ('Estrela do Norte', 9);
insert tblCIDADE values ('Faina', 9);
insert tblCIDADE values ('Fazenda Nova', 9);
insert tblCIDADE values ('Firmin�polis', 9);
insert tblCIDADE values ('Flores de Goi�s', 9);
insert tblCIDADE values ('Formosa', 9);
insert tblCIDADE values ('Formoso', 9);
insert tblCIDADE values ('Gameleira de Goi�s', 9);
insert tblCIDADE values ('Divin�polis de Goi�s', 9);
insert tblCIDADE values ('Goian�polis', 9);
insert tblCIDADE values ('Goiandira', 9);
insert tblCIDADE values ('Goian�sia', 9);
insert tblCIDADE values ('Goi�nia', 9);
insert tblCIDADE values ('Goianira', 9);
insert tblCIDADE values ('Goi�s', 9);
insert tblCIDADE values ('Goiatuba', 9);
insert tblCIDADE values ('Gouvel�ndia', 9);
insert tblCIDADE values ('Guap�', 9);
insert tblCIDADE values ('Guara�ta', 9);
insert tblCIDADE values ('Guarani de Goi�s', 9);
insert tblCIDADE values ('Guarinos', 9);
insert tblCIDADE values ('Heitora�', 9);
insert tblCIDADE values ('Hidrol�ndia', 9);
insert tblCIDADE values ('Hidrolina', 9);
insert tblCIDADE values ('Iaciara', 9);
insert tblCIDADE values ('Inaciol�ndia', 9);
insert tblCIDADE values ('Indiara', 9);
insert tblCIDADE values ('Inhumas', 9);
insert tblCIDADE values ('Ipameri', 9);
insert tblCIDADE values ('Ipiranga de Goi�s', 9);
insert tblCIDADE values ('Ipor�', 9);
insert tblCIDADE values ('Israel�ndia', 9);
insert tblCIDADE values ('Itabera�', 9);
insert tblCIDADE values ('Itaguari', 9);
insert tblCIDADE values ('Itaguaru', 9);
insert tblCIDADE values ('Itaj�', 9);
insert tblCIDADE values ('Itapaci', 9);
insert tblCIDADE values ('Itapirapu�', 9);
insert tblCIDADE values ('Itapuranga', 9);
insert tblCIDADE values ('Itarum�', 9);
insert tblCIDADE values ('Itau�u', 9);
insert tblCIDADE values ('Itumbiara', 9);
insert tblCIDADE values ('Ivol�ndia', 9);
insert tblCIDADE values ('Jandaia', 9);
insert tblCIDADE values ('Jaragu�', 9);
insert tblCIDADE values ('Jata�', 9);
insert tblCIDADE values ('Jaupaci', 9);
insert tblCIDADE values ('Jes�polis', 9);
insert tblCIDADE values ('Jovi�nia', 9);
insert tblCIDADE values ('Jussara', 9);
insert tblCIDADE values ('Lagoa Santa', 9);
insert tblCIDADE values ('Leopoldo de Bulh�es', 9);
insert tblCIDADE values ('Luzi�nia', 9);
insert tblCIDADE values ('Mairipotaba', 9);
insert tblCIDADE values ('Mamba�', 9);
insert tblCIDADE values ('Mara Rosa', 9);
insert tblCIDADE values ('Marzag�o', 9);
insert tblCIDADE values ('Matrinch�', 9);
insert tblCIDADE values ('Mauril�ndia', 9);
insert tblCIDADE values ('Mimoso de Goi�s', 9);
insert tblCIDADE values ('Mina�u', 9);
insert tblCIDADE values ('Mineiros', 9);
insert tblCIDADE values ('Moipor�', 9);
insert tblCIDADE values ('Monte Alegre de Goi�s', 9);
insert tblCIDADE values ('Montes Claros de Goi�s', 9);
insert tblCIDADE values ('Montividiu', 9);
insert tblCIDADE values ('Montividiu do Norte', 9);
insert tblCIDADE values ('Morrinhos', 9);
insert tblCIDADE values ('Morro Agudo de Goi�s', 9);
insert tblCIDADE values ('Moss�medes', 9);
insert tblCIDADE values ('Mozarl�ndia', 9);
insert tblCIDADE values ('Mundo Novo', 9);
insert tblCIDADE values ('Mutun�polis', 9);
insert tblCIDADE values ('Naz�rio', 9);
insert tblCIDADE values ('Ner�polis', 9);
insert tblCIDADE values ('Niquel�ndia', 9);
insert tblCIDADE values ('Nova Am�rica', 9);
insert tblCIDADE values ('Nova Aurora', 9);
insert tblCIDADE values ('Nova Crix�s', 9);
insert tblCIDADE values ('Nova Gl�ria', 9);
insert tblCIDADE values ('Nova Igua�u de Goi�s', 9);
insert tblCIDADE values ('Nova Roma', 9);
insert tblCIDADE values ('Nova Veneza', 9);
insert tblCIDADE values ('Novo Brasil', 9);
insert tblCIDADE values ('Novo Gama', 9);
insert tblCIDADE values ('Novo Planalto', 9);
insert tblCIDADE values ('Orizona', 9);
insert tblCIDADE values ('Ouro Verde de Goi�s', 9);
insert tblCIDADE values ('Ouvidor', 9);
insert tblCIDADE values ('Padre Bernardo', 9);
insert tblCIDADE values ('Palestina de Goi�s', 9);
insert tblCIDADE values ('Palmeiras de Goi�s', 9);
insert tblCIDADE values ('Palmelo', 9);
insert tblCIDADE values ('Palmin�polis', 9);
insert tblCIDADE values ('Panam�', 9);
insert tblCIDADE values ('Paranaiguara', 9);
insert tblCIDADE values ('Para�na', 9);
insert tblCIDADE values ('Perol�ndia', 9);
insert tblCIDADE values ('Petrolina de Goi�s', 9);
insert tblCIDADE values ('Pilar de Goi�s', 9);
insert tblCIDADE values ('Piracanjuba', 9);
insert tblCIDADE values ('Piranhas', 9);
insert tblCIDADE values ('Piren�polis', 9);
insert tblCIDADE values ('Pires do Rio', 9);
insert tblCIDADE values ('Planaltina', 9);
insert tblCIDADE values ('Pontalina', 9);
insert tblCIDADE values ('Porangatu', 9);
insert tblCIDADE values ('Porteir�o', 9);
insert tblCIDADE values ('Portel�ndia', 9);
insert tblCIDADE values ('Posse', 9);
insert tblCIDADE values ('Professor Jamil', 9);
insert tblCIDADE values ('Quirin�polis', 9);
insert tblCIDADE values ('Rialma', 9);
insert tblCIDADE values ('Rian�polis', 9);
insert tblCIDADE values ('Rio Quente', 9);
insert tblCIDADE values ('Rio Verde', 9);
insert tblCIDADE values ('Rubiataba', 9);
insert tblCIDADE values ('Sanclerl�ndia', 9);
insert tblCIDADE values ('Santa B�rbara de Goi�s', 9);
insert tblCIDADE values ('Santa Cruz de Goi�s', 9);
insert tblCIDADE values ('Santa F� de Goi�s', 9);
insert tblCIDADE values ('Santa Helena de Goi�s', 9);
insert tblCIDADE values ('Santa Isabel', 9);
insert tblCIDADE values ('Santa Rita do Araguaia', 9);
insert tblCIDADE values ('Santa Rita do Novo Destino', 9);
insert tblCIDADE values ('Santa Rosa de Goi�s', 9);
insert tblCIDADE values ('Santa Tereza de Goi�s', 9);
insert tblCIDADE values ('Santa Terezinha de Goi�s', 9);
insert tblCIDADE values ('Santo Ant�nio da Barra', 9);
insert tblCIDADE values ('Santo Ant�nio de Goi�s', 9);
insert tblCIDADE values ('Santo Ant�nio do Descoberto', 9);
insert tblCIDADE values ('S�o Domingos', 9);
insert tblCIDADE values ('S�o Francisco de Goi�s', 9);
insert tblCIDADE values ('S�o Jo�o d''Alian�a', 9);
insert tblCIDADE values ('S�o Jo�o da Para�na', 9);
insert tblCIDADE values ('S�o Lu�s de Montes Belos', 9);
insert tblCIDADE values ('S�o Lu�z do Norte', 9);
insert tblCIDADE values ('S�o Miguel do Araguaia', 9);
insert tblCIDADE values ('S�o Miguel do Passa Quatro', 9);
insert tblCIDADE values ('S�o Patr�cio', 9);
insert tblCIDADE values ('S�o Sim�o', 9);
insert tblCIDADE values ('Senador Canedo', 9);
insert tblCIDADE values ('Serran�polis', 9);
insert tblCIDADE values ('Silv�nia', 9);
insert tblCIDADE values ('Simol�ndia', 9);
insert tblCIDADE values ('S�tio d''Abadia', 9);
insert tblCIDADE values ('Taquaral de Goi�s', 9);
insert tblCIDADE values ('Teresina de Goi�s', 9);
insert tblCIDADE values ('Terez�polis de Goi�s', 9);
insert tblCIDADE values ('Tr�s Ranchos', 9);
insert tblCIDADE values ('Trindade', 9);
insert tblCIDADE values ('Trombas', 9);
insert tblCIDADE values ('Turv�nia', 9);
insert tblCIDADE values ('Turvel�ndia', 9);
insert tblCIDADE values ('Uirapuru', 9);
insert tblCIDADE values ('Urua�u', 9);
insert tblCIDADE values ('Uruana', 9);
insert tblCIDADE values ('Uruta�', 9);
insert tblCIDADE values ('Valpara�so de Goi�s', 9);
insert tblCIDADE values ('Varj�o', 9);
insert tblCIDADE values ('Vian�polis', 9);
insert tblCIDADE values ('Vicentin�polis', 9);
insert tblCIDADE values ('Vila Boa', 9);
insert tblCIDADE values ('Vila Prop�cio', 9);
insert tblCIDADE values ('A�ail�ndia', 10);
insert tblCIDADE values ('Afonso Cunha', 10);
insert tblCIDADE values ('�gua Doce do Maranh�o', 10);
insert tblCIDADE values ('Alc�ntara', 10);
insert tblCIDADE values ('Aldeias Altas', 10);
insert tblCIDADE values ('Altamira do Maranh�o', 10);
insert tblCIDADE values ('Alto Alegre do Maranh�o', 10);
insert tblCIDADE values ('Alto Alegre do Pindar�', 10);
insert tblCIDADE values ('Alto Parna�ba', 10);
insert tblCIDADE values ('Amap� do Maranh�o', 10);
insert tblCIDADE values ('Amarante do Maranh�o', 10);
insert tblCIDADE values ('Anajatuba', 10);
insert tblCIDADE values ('Anapurus', 10);
insert tblCIDADE values ('Apicum-A�u', 10);
insert tblCIDADE values ('Araguan�', 10);
insert tblCIDADE values ('Araioses', 10);
insert tblCIDADE values ('Arame', 10);
insert tblCIDADE values ('Arari', 10);
insert tblCIDADE values ('Axix�', 10);
insert tblCIDADE values ('Bacabal', 10);
insert tblCIDADE values ('Bacabeira', 10);
insert tblCIDADE values ('Bacuri', 10);
insert tblCIDADE values ('Bacurituba', 10);
insert tblCIDADE values ('Balsas', 10);
insert tblCIDADE values ('Bar�o de Graja�', 10);
insert tblCIDADE values ('Barra do Corda', 10);
insert tblCIDADE values ('Barreirinhas', 10);
insert tblCIDADE values ('Bel�gua', 10);
insert tblCIDADE values ('Bela Vista do Maranh�o', 10);
insert tblCIDADE values ('Benedito Leite', 10);
insert tblCIDADE values ('Bequim�o', 10);
insert tblCIDADE values ('Bernardo do Mearim', 10);
insert tblCIDADE values ('Boa Vista do Gurupi', 10);
insert tblCIDADE values ('Bom Jardim', 10);
insert tblCIDADE values ('Bom Jesus das Selvas', 10);
insert tblCIDADE values ('Bom Lugar', 10);
insert tblCIDADE values ('Brejo', 10);
insert tblCIDADE values ('Brejo de Areia', 10);
insert tblCIDADE values ('Buriti', 10);
insert tblCIDADE values ('Buriti Bravo', 10);
insert tblCIDADE values ('Buriticupu', 10);
insert tblCIDADE values ('Buritirana', 10);
insert tblCIDADE values ('Cachoeira Grande', 10);
insert tblCIDADE values ('Cajapi�', 10);
insert tblCIDADE values ('Cajari', 10);
insert tblCIDADE values ('Campestre do Maranh�o', 10);
insert tblCIDADE values ('C�ndido Mendes', 10);
insert tblCIDADE values ('Cantanhede', 10);
insert tblCIDADE values ('Capinzal do Norte', 10);
insert tblCIDADE values ('Carolina', 10);
insert tblCIDADE values ('Carutapera', 10);
insert tblCIDADE values ('Caxias', 10);
insert tblCIDADE values ('Cedral', 10);
insert tblCIDADE values ('Central do Maranh�o', 10);
insert tblCIDADE values ('Centro do Guilherme', 10);
insert tblCIDADE values ('Centro Novo do Maranh�o', 10);
insert tblCIDADE values ('Chapadinha', 10);
insert tblCIDADE values ('Cidel�ndia', 10);
insert tblCIDADE values ('Cod�', 10);
insert tblCIDADE values ('Coelho Neto', 10);
insert tblCIDADE values ('Colinas', 10);
insert tblCIDADE values ('Concei��o do Lago-A�u', 10);
insert tblCIDADE values ('Coroat�', 10);
insert tblCIDADE values ('Cururupu', 10);
insert tblCIDADE values ('Davin�polis', 10);
insert tblCIDADE values ('Dom Pedro', 10);
insert tblCIDADE values ('Duque Bacelar', 10);
insert tblCIDADE values ('Esperantin�polis', 10);
insert tblCIDADE values ('Estreito', 10);
insert tblCIDADE values ('Feira Nova do Maranh�o', 10);
insert tblCIDADE values ('Fernando Falc�o', 10);
insert tblCIDADE values ('Formosa da Serra Negra', 10);
insert tblCIDADE values ('Fortaleza dos Nogueiras', 10);
insert tblCIDADE values ('Fortuna', 10);
insert tblCIDADE values ('Godofredo Viana', 10);
insert tblCIDADE values ('Gon�alves Dias', 10);
insert tblCIDADE values ('Governador Archer', 10);
insert tblCIDADE values ('Governador Edison Lob�o', 10);
insert tblCIDADE values ('Governador Eug�nio Barros', 10);
insert tblCIDADE values ('Governador Luiz Rocha', 10);
insert tblCIDADE values ('Governador Newton Bello', 10);
insert tblCIDADE values ('Governador Nunes Freire', 10);
insert tblCIDADE values ('Gra�a Aranha', 10);
insert tblCIDADE values ('Graja�', 10);
insert tblCIDADE values ('Guimar�es', 10);
insert tblCIDADE values ('Humberto de Campos', 10);
insert tblCIDADE values ('Icatu', 10);
insert tblCIDADE values ('Igarap� do Meio', 10);
insert tblCIDADE values ('Igarap� Grande', 10);
insert tblCIDADE values ('Imperatriz', 10);
insert tblCIDADE values ('Itaipava do Graja�', 10);
insert tblCIDADE values ('Itapecuru Mirim', 10);
insert tblCIDADE values ('Itinga do Maranh�o', 10);
insert tblCIDADE values ('Jatob�', 10);
insert tblCIDADE values ('Jenipapo dos Vieiras', 10);
insert tblCIDADE values ('Jo�o Lisboa', 10);
insert tblCIDADE values ('Josel�ndia', 10);
insert tblCIDADE values ('Junco do Maranh�o', 10);
insert tblCIDADE values ('Lago da Pedra', 10);
insert tblCIDADE values ('Lago do Junco', 10);
insert tblCIDADE values ('Lago Verde', 10);
insert tblCIDADE values ('Lagoa do Mato', 10);
insert tblCIDADE values ('Lago dos Rodrigues', 10);
insert tblCIDADE values ('Lagoa Grande do Maranh�o', 10);
insert tblCIDADE values ('Lajeado Novo', 10);
insert tblCIDADE values ('Lima Campos', 10);
insert tblCIDADE values ('Loreto', 10);
insert tblCIDADE values ('Lu�s Domingues', 10);
insert tblCIDADE values ('Magalh�es de Almeida', 10);
insert tblCIDADE values ('Maraca�um�', 10);
insert tblCIDADE values ('Maraj� do Sena', 10);
insert tblCIDADE values ('Maranh�ozinho', 10);
insert tblCIDADE values ('Mata Roma', 10);
insert tblCIDADE values ('Matinha', 10);
insert tblCIDADE values ('Mat�es', 10);
insert tblCIDADE values ('Mat�es do Norte', 10);
insert tblCIDADE values ('Milagres do Maranh�o', 10);
insert tblCIDADE values ('Mirador', 10);
insert tblCIDADE values ('Miranda do Norte', 10);
insert tblCIDADE values ('Mirinzal', 10);
insert tblCIDADE values ('Mon��o', 10);
insert tblCIDADE values ('Montes Altos', 10);
insert tblCIDADE values ('Morros', 10);
insert tblCIDADE values ('Nina Rodrigues', 10);
insert tblCIDADE values ('Nova Colinas', 10);
insert tblCIDADE values ('Nova Iorque', 10);
insert tblCIDADE values ('Nova Olinda do Maranh�o', 10);
insert tblCIDADE values ('Olho d''�gua das Cunh�s', 10);
insert tblCIDADE values ('Olinda Nova do Maranh�o', 10);
insert tblCIDADE values ('Pa�o do Lumiar', 10);
insert tblCIDADE values ('Palmeir�ndia', 10);
insert tblCIDADE values ('Paraibano', 10);
insert tblCIDADE values ('Parnarama', 10);
insert tblCIDADE values ('Passagem Franca', 10);
insert tblCIDADE values ('Pastos Bons', 10);
insert tblCIDADE values ('Paulino Neves', 10);
insert tblCIDADE values ('Paulo Ramos', 10);
insert tblCIDADE values ('Pedreiras', 10);
insert tblCIDADE values ('Pedro do Ros�rio', 10);
insert tblCIDADE values ('Penalva', 10);
insert tblCIDADE values ('Peri Mirim', 10);
insert tblCIDADE values ('Peritor�', 10);
insert tblCIDADE values ('Pindar�-Mirim', 10);
insert tblCIDADE values ('Pinheiro', 10);
insert tblCIDADE values ('Pio XII', 10);
insert tblCIDADE values ('Pirapemas', 10);
insert tblCIDADE values ('Po��o de Pedras', 10);
insert tblCIDADE values ('Porto Franco', 10);
insert tblCIDADE values ('Porto Rico do Maranh�o', 10);
insert tblCIDADE values ('Presidente Dutra', 10);
insert tblCIDADE values ('Presidente Juscelino', 10);
insert tblCIDADE values ('Presidente M�dici', 10);
insert tblCIDADE values ('Presidente Sarney', 10);
insert tblCIDADE values ('Presidente Vargas', 10);
insert tblCIDADE values ('Primeira Cruz', 10);
insert tblCIDADE values ('Raposa', 10);
insert tblCIDADE values ('Riach�o', 10);
insert tblCIDADE values ('Ribamar Fiquene', 10);
insert tblCIDADE values ('Ros�rio', 10);
insert tblCIDADE values ('Samba�ba', 10);
insert tblCIDADE values ('Santa Filomena do Maranh�o', 10);
insert tblCIDADE values ('Santa Helena', 10);
insert tblCIDADE values ('Santa In�s', 10);
insert tblCIDADE values ('Santa Luzia', 10);
insert tblCIDADE values ('Santa Luzia do Paru�', 10);
insert tblCIDADE values ('Santa Quit�ria do Maranh�o', 10);
insert tblCIDADE values ('Santa Rita', 10);
insert tblCIDADE values ('Santana do Maranh�o', 10);
insert tblCIDADE values ('Santo Amaro do Maranh�o', 10);
insert tblCIDADE values ('Santo Ant�nio dos Lopes', 10);
insert tblCIDADE values ('S�o Benedito do Rio Preto', 10);
insert tblCIDADE values ('S�o Bento', 10);
insert tblCIDADE values ('S�o Bernardo', 10);
insert tblCIDADE values ('S�o Domingos do Azeit�o', 10);
insert tblCIDADE values ('S�o Domingos do Maranh�o', 10);
insert tblCIDADE values ('S�o F�lix de Balsas', 10);
insert tblCIDADE values ('S�o Francisco do Brej�o', 10);
insert tblCIDADE values ('S�o Francisco do Maranh�o', 10);
insert tblCIDADE values ('S�o Jo�o Batista', 10);
insert tblCIDADE values ('S�o Jo�o do Car�', 10);
insert tblCIDADE values ('S�o Jo�o do Para�so', 10);
insert tblCIDADE values ('S�o Jo�o do Soter', 10);
insert tblCIDADE values ('S�o Jo�o dos Patos', 10);
insert tblCIDADE values ('S�o Jos� de Ribamar', 10);
insert tblCIDADE values ('S�o Jos� dos Bas�lios', 10);
insert tblCIDADE values ('S�o Lu�s', 10);
insert tblCIDADE values ('S�o Lu�s Gonzaga do Maranh�o', 10);
insert tblCIDADE values ('S�o Mateus do Maranh�o', 10);
insert tblCIDADE values ('S�o Pedro da �gua Branca', 10);
insert tblCIDADE values ('S�o Pedro dos Crentes', 10);
insert tblCIDADE values ('S�o Raimundo das Mangabeiras', 10);
insert tblCIDADE values ('S�o Raimundo do Doca Bezerra', 10);
insert tblCIDADE values ('S�o Roberto', 10);
insert tblCIDADE values ('S�o Vicente Ferrer', 10);
insert tblCIDADE values ('Satubinha', 10);
insert tblCIDADE values ('Senador Alexandre Costa', 10);
insert tblCIDADE values ('Senador La Rocque', 10);
insert tblCIDADE values ('Serrano do Maranh�o', 10);
insert tblCIDADE values ('S�tio Novo', 10);
insert tblCIDADE values ('Sucupira do Norte', 10);
insert tblCIDADE values ('Sucupira do Riach�o', 10);
insert tblCIDADE values ('Tasso Fragoso', 10);
insert tblCIDADE values ('Timbiras', 10);
insert tblCIDADE values ('Timon', 10);
insert tblCIDADE values ('Trizidela do Vale', 10);
insert tblCIDADE values ('Tufil�ndia', 10);
insert tblCIDADE values ('Tuntum', 10);
insert tblCIDADE values ('Turia�u', 10);
insert tblCIDADE values ('Turil�ndia', 10);
insert tblCIDADE values ('Tut�ia', 10);
insert tblCIDADE values ('Urbano Santos', 10);
insert tblCIDADE values ('Vargem Grande', 10);
insert tblCIDADE values ('Viana', 10);
insert tblCIDADE values ('Vila Nova dos Mart�rios', 10);
insert tblCIDADE values ('Vit�ria do Mearim', 10);
insert tblCIDADE values ('Vitorino Freire', 10);
insert tblCIDADE values ('Z� Doca', 10);
insert tblCIDADE values ('Acorizal', 11);
insert tblCIDADE values ('�gua Boa', 11);
insert tblCIDADE values ('Alta Floresta', 11);
insert tblCIDADE values ('Alto Araguaia', 11);
insert tblCIDADE values ('Alto Boa Vista', 11);
insert tblCIDADE values ('Alto Gar�as', 11);
insert tblCIDADE values ('Alto Paraguai', 11);
insert tblCIDADE values ('Alto Taquari', 11);
insert tblCIDADE values ('Apiac�s', 11);
insert tblCIDADE values ('Araguaiana', 11);
insert tblCIDADE values ('Araguainha', 11);
insert tblCIDADE values ('Araputanga', 11);
insert tblCIDADE values ('Aren�polis', 11);
insert tblCIDADE values ('Aripuan�', 11);
insert tblCIDADE values ('Bar�o de Melga�o', 11);
insert tblCIDADE values ('Barra do Bugres', 11);
insert tblCIDADE values ('Barra do Gar�as', 11);
insert tblCIDADE values ('Bom Jesus do Araguaia', 11);
insert tblCIDADE values ('Brasnorte', 11);
insert tblCIDADE values ('C�ceres', 11);
insert tblCIDADE values ('Campin�polis', 11);
insert tblCIDADE values ('Campo Novo do Parecis', 11);
insert tblCIDADE values ('Campo Verde', 11);
insert tblCIDADE values ('Campos de J�lio', 11);
insert tblCIDADE values ('Canabrava do Norte', 11);
insert tblCIDADE values ('Canarana', 11);
insert tblCIDADE values ('Carlinda', 11);
insert tblCIDADE values ('Castanheira', 11);
insert tblCIDADE values ('Chapada dos Guimar�es', 11);
insert tblCIDADE values ('Cl�udia', 11);
insert tblCIDADE values ('Cocalinho', 11);
insert tblCIDADE values ('Col�der', 11);
insert tblCIDADE values ('Colniza', 11);
insert tblCIDADE values ('Comodoro', 11);
insert tblCIDADE values ('Confresa', 11);
insert tblCIDADE values ('Conquista D''Oeste', 11);
insert tblCIDADE values ('Cotrigua�u', 11);
insert tblCIDADE values ('Cuiab�', 11);
insert tblCIDADE values ('Curvel�ndia', 11);
insert tblCIDADE values ('Denise', 11);
insert tblCIDADE values ('Diamantino', 11);
insert tblCIDADE values ('Dom Aquino', 11);
insert tblCIDADE values ('Feliz Natal', 11);
insert tblCIDADE values ('Figueir�polis D''Oeste', 11);
insert tblCIDADE values ('Ga�cha do Norte', 11);
insert tblCIDADE values ('General Carneiro', 11);
insert tblCIDADE values ('Gl�ria D''Oeste', 11);
insert tblCIDADE values ('Guarant� do Norte', 11);
insert tblCIDADE values ('Guiratinga', 11);
insert tblCIDADE values ('Indiava�', 11);
insert tblCIDADE values ('Ipiranga do Norte', 11);
insert tblCIDADE values ('Itanhang�', 11);
insert tblCIDADE values ('Ita�ba', 11);
insert tblCIDADE values ('Itiquira', 11);
insert tblCIDADE values ('Jaciara', 11);
insert tblCIDADE values ('Jangada', 11);
insert tblCIDADE values ('Jauru', 11);
insert tblCIDADE values ('Juara', 11);
insert tblCIDADE values ('Ju�na', 11);
insert tblCIDADE values ('Juruena', 11);
insert tblCIDADE values ('Juscimeira', 11);
insert tblCIDADE values ('Lambari D''Oeste', 11);
insert tblCIDADE values ('Lucas do Rio Verde', 11);
insert tblCIDADE values ('Luciara', 11);
insert tblCIDADE values ('Vila Bela da Sant�ssima Trindade', 11);
insert tblCIDADE values ('Marcel�ndia', 11);
insert tblCIDADE values ('Matup�', 11);
insert tblCIDADE values ('Mirassol d''Oeste', 11);
insert tblCIDADE values ('Nobres', 11);
insert tblCIDADE values ('Nortel�ndia', 11);
insert tblCIDADE values ('Nossa Senhora do Livramento', 11);
insert tblCIDADE values ('Nova Bandeirantes', 11);
insert tblCIDADE values ('Nova Nazar�', 11);
insert tblCIDADE values ('Nova Lacerda', 11);
insert tblCIDADE values ('Nova Santa Helena', 11);
insert tblCIDADE values ('Nova Brasil�ndia', 11);
insert tblCIDADE values ('Nova Cana� do Norte', 11);
insert tblCIDADE values ('Nova Mutum', 11);
insert tblCIDADE values ('Nova Ol�mpia', 11);
insert tblCIDADE values ('Nova Ubirat�', 11);
insert tblCIDADE values ('Nova Xavantina', 11);
insert tblCIDADE values ('Novo Mundo', 11);
insert tblCIDADE values ('Novo Horizonte do Norte', 11);
insert tblCIDADE values ('Novo S�o Joaquim', 11);
insert tblCIDADE values ('Parana�ta', 11);
insert tblCIDADE values ('Paranatinga', 11);
insert tblCIDADE values ('Novo Santo Ant�nio', 11);
insert tblCIDADE values ('Pedra Preta', 11);
insert tblCIDADE values ('Peixoto de Azevedo', 11);
insert tblCIDADE values ('Planalto da Serra', 11);
insert tblCIDADE values ('Pocon�', 11);
insert tblCIDADE values ('Pontal do Araguaia', 11);
insert tblCIDADE values ('Ponte Branca', 11);
insert tblCIDADE values ('Pontes e Lacerda', 11);
insert tblCIDADE values ('Porto Alegre do Norte', 11);
insert tblCIDADE values ('Porto dos Ga�chos', 11);
insert tblCIDADE values ('Porto Esperidi�o', 11);
insert tblCIDADE values ('Porto Estrela', 11);
insert tblCIDADE values ('Poxor�o', 11);
insert tblCIDADE values ('Primavera do Leste', 11);
insert tblCIDADE values ('Quer�ncia', 11);
insert tblCIDADE values ('S�o Jos� dos Quatro Marcos', 11);
insert tblCIDADE values ('Reserva do Caba�al', 11);
insert tblCIDADE values ('Ribeir�o Cascalheira', 11);
insert tblCIDADE values ('Ribeir�ozinho', 11);
insert tblCIDADE values ('Rio Branco', 11);
insert tblCIDADE values ('Santa Carmem', 11);
insert tblCIDADE values ('Santo Afonso', 11);
insert tblCIDADE values ('S�o Jos� do Povo', 11);
insert tblCIDADE values ('S�o Jos� do Rio Claro', 11);
insert tblCIDADE values ('S�o Jos� do Xingu', 11);
insert tblCIDADE values ('S�o Pedro da Cipa', 11);
insert tblCIDADE values ('Rondol�ndia', 11);
insert tblCIDADE values ('Rondon�polis', 11);
insert tblCIDADE values ('Ros�rio Oeste', 11);
insert tblCIDADE values ('Santa Cruz do Xingu', 11);
insert tblCIDADE values ('Salto do C�u', 11);
insert tblCIDADE values ('Santa Rita do Trivelato', 11);
insert tblCIDADE values ('Santa Terezinha', 11);
insert tblCIDADE values ('Santo Ant�nio do Leste', 11);
insert tblCIDADE values ('Santo Ant�nio do Leverger', 11);
insert tblCIDADE values ('S�o F�lix do Araguaia', 11);
insert tblCIDADE values ('Sapezal', 11);
insert tblCIDADE values ('Serra Nova Dourada', 11);
insert tblCIDADE values ('Sinop', 11);
insert tblCIDADE values ('Sorriso', 11);
insert tblCIDADE values ('Tabapor�', 11);
insert tblCIDADE values ('Tangar� da Serra', 11);
insert tblCIDADE values ('Tapurah', 11);
insert tblCIDADE values ('Terra Nova do Norte', 11);
insert tblCIDADE values ('Tesouro', 11);
insert tblCIDADE values ('Torixor�u', 11);
insert tblCIDADE values ('Uni�o do Sul', 11);
insert tblCIDADE values ('Vale de S�o Domingos', 11);
insert tblCIDADE values ('V�rzea Grande', 11);
insert tblCIDADE values ('Vera', 11);
insert tblCIDADE values ('Vila Rica', 11);
insert tblCIDADE values ('Nova Guarita', 11);
insert tblCIDADE values ('Nova Maril�ndia', 11);
insert tblCIDADE values ('Nova Maring�', 11);
insert tblCIDADE values ('Nova Monte Verde', 11);
insert tblCIDADE values ('Abadia dos Dourados', 13);
insert tblCIDADE values ('Abaet�', 13);
insert tblCIDADE values ('Abre Campo', 13);
insert tblCIDADE values ('Acaiaca', 13);
insert tblCIDADE values ('A�ucena', 13);
insert tblCIDADE values ('�gua Boa', 13);
insert tblCIDADE values ('�gua Comprida', 13);
insert tblCIDADE values ('Aguanil', 13);
insert tblCIDADE values ('�guas Formosas', 13);
insert tblCIDADE values ('�guas Vermelhas', 13);
insert tblCIDADE values ('Aimor�s', 13);
insert tblCIDADE values ('Aiuruoca', 13);
insert tblCIDADE values ('Alagoa', 13);
insert tblCIDADE values ('Albertina', 13);
insert tblCIDADE values ('Al�m Para�ba', 13);
insert tblCIDADE values ('Alfenas', 13);
insert tblCIDADE values ('Alfredo Vasconcelos', 13);
insert tblCIDADE values ('Almenara', 13);
insert tblCIDADE values ('Alpercata', 13);
insert tblCIDADE values ('Alpin�polis', 13);
insert tblCIDADE values ('Alterosa', 13);
insert tblCIDADE values ('Alto Capara�', 13);
insert tblCIDADE values ('Alto Rio Doce', 13);
insert tblCIDADE values ('Alvarenga', 13);
insert tblCIDADE values ('Alvin�polis', 13);
insert tblCIDADE values ('Alvorada de Minas', 13);
insert tblCIDADE values ('Amparo do Serra', 13);
insert tblCIDADE values ('Andradas', 13);
insert tblCIDADE values ('Cachoeira de Paje�', 13);
insert tblCIDADE values ('Andrel�ndia', 13);
insert tblCIDADE values ('Angel�ndia', 13);
insert tblCIDADE values ('Ant�nio Carlos', 13);
insert tblCIDADE values ('Ant�nio Dias', 13);
insert tblCIDADE values ('Ant�nio Prado de Minas', 13);
insert tblCIDADE values ('Ara�a�', 13);
insert tblCIDADE values ('Aracitaba', 13);
insert tblCIDADE values ('Ara�ua�', 13);
insert tblCIDADE values ('Araguari', 13);
insert tblCIDADE values ('Arantina', 13);
insert tblCIDADE values ('Araponga', 13);
insert tblCIDADE values ('Arapor�', 13);
insert tblCIDADE values ('Arapu�', 13);
insert tblCIDADE values ('Ara�jos', 13);
insert tblCIDADE values ('Arax�', 13);
insert tblCIDADE values ('Arceburgo', 13);
insert tblCIDADE values ('Arcos', 13);
insert tblCIDADE values ('Areado', 13);
insert tblCIDADE values ('Argirita', 13);
insert tblCIDADE values ('Aricanduva', 13);
insert tblCIDADE values ('Arinos', 13);
insert tblCIDADE values ('Astolfo Dutra', 13);
insert tblCIDADE values ('Atal�ia', 13);
insert tblCIDADE values ('Augusto de Lima', 13);
insert tblCIDADE values ('Baependi', 13);
insert tblCIDADE values ('Baldim', 13);
insert tblCIDADE values ('Bambu�', 13);
insert tblCIDADE values ('Bandeira', 13);
insert tblCIDADE values ('Bandeira do Sul', 13);
insert tblCIDADE values ('Bar�o de Cocais', 13);
insert tblCIDADE values ('Bar�o de Monte Alto', 13);
insert tblCIDADE values ('Barbacena', 13);
insert tblCIDADE values ('Barra Longa', 13);
insert tblCIDADE values ('Barroso', 13);
insert tblCIDADE values ('Bela Vista de Minas', 13);
insert tblCIDADE values ('Belmiro Braga', 13);
insert tblCIDADE values ('Belo Horizonte', 13);
insert tblCIDADE values ('Belo Oriente', 13);
insert tblCIDADE values ('Belo Vale', 13);
insert tblCIDADE values ('Berilo', 13);
insert tblCIDADE values ('Bert�polis', 13);
insert tblCIDADE values ('Berizal', 13);
insert tblCIDADE values ('Betim', 13);
insert tblCIDADE values ('Bias Fortes', 13);
insert tblCIDADE values ('Bicas', 13);
insert tblCIDADE values ('Biquinhas', 13);
insert tblCIDADE values ('Boa Esperan�a', 13);
insert tblCIDADE values ('Bocaina de Minas', 13);
insert tblCIDADE values ('Bocai�va', 13);
insert tblCIDADE values ('Bom Despacho', 13);
insert tblCIDADE values ('Bom Jardim de Minas', 13);
insert tblCIDADE values ('Bom Jesus da Penha', 13);
insert tblCIDADE values ('Bom Jesus do Amparo', 13);
insert tblCIDADE values ('Bom Jesus do Galho', 13);
insert tblCIDADE values ('Bom Repouso', 13);
insert tblCIDADE values ('Bom Sucesso', 13);
insert tblCIDADE values ('Bonfim', 13);
insert tblCIDADE values ('Bonfin�polis de Minas', 13);
insert tblCIDADE values ('Bonito de Minas', 13);
insert tblCIDADE values ('Borda da Mata', 13);
insert tblCIDADE values ('Botelhos', 13);
insert tblCIDADE values ('Botumirim', 13);
insert tblCIDADE values ('Brasil�ndia de Minas', 13);
insert tblCIDADE values ('Bras�lia de Minas', 13);
insert tblCIDADE values ('Br�s Pires', 13);
insert tblCIDADE values ('Bra�nas', 13);
insert tblCIDADE values ('Bras�polis', 13);
insert tblCIDADE values ('Brumadinho', 13);
insert tblCIDADE values ('Bueno Brand�o', 13);
insert tblCIDADE values ('Buen�polis', 13);
insert tblCIDADE values ('Bugre', 13);
insert tblCIDADE values ('Buritis', 13);
insert tblCIDADE values ('Buritizeiro', 13);
insert tblCIDADE values ('Cabeceira Grande', 13);
insert tblCIDADE values ('Cabo Verde', 13);
insert tblCIDADE values ('Cachoeira da Prata', 13);
insert tblCIDADE values ('Cachoeira de Minas', 13);
insert tblCIDADE values ('Cachoeira Dourada', 13);
insert tblCIDADE values ('Caetan�polis', 13);
insert tblCIDADE values ('Caet�', 13);
insert tblCIDADE values ('Caiana', 13);
insert tblCIDADE values ('Cajuri', 13);
insert tblCIDADE values ('Caldas', 13);
insert tblCIDADE values ('Camacho', 13);
insert tblCIDADE values ('Camanducaia', 13);
insert tblCIDADE values ('Cambu�', 13);
insert tblCIDADE values ('Cambuquira', 13);
insert tblCIDADE values ('Campan�rio', 13);
insert tblCIDADE values ('Campanha', 13);
insert tblCIDADE values ('Campestre', 13);
insert tblCIDADE values ('Campina Verde', 13);
insert tblCIDADE values ('Campo Azul', 13);
insert tblCIDADE values ('Campo Belo', 13);
insert tblCIDADE values ('Campo do Meio', 13);
insert tblCIDADE values ('Campo Florido', 13);
insert tblCIDADE values ('Campos Altos', 13);
insert tblCIDADE values ('Campos Gerais', 13);
insert tblCIDADE values ('Cana�', 13);
insert tblCIDADE values ('Can�polis', 13);
insert tblCIDADE values ('Cana Verde', 13);
insert tblCIDADE values ('Candeias', 13);
insert tblCIDADE values ('Cantagalo', 13);
insert tblCIDADE values ('Capara�', 13);
insert tblCIDADE values ('Capela Nova', 13);
insert tblCIDADE values ('Capelinha', 13);
insert tblCIDADE values ('Capetinga', 13);
insert tblCIDADE values ('Capim Branco', 13);
insert tblCIDADE values ('Capin�polis', 13);
insert tblCIDADE values ('Capit�o Andrade', 13);
insert tblCIDADE values ('Capit�o En�as', 13);
insert tblCIDADE values ('Capit�lio', 13);
insert tblCIDADE values ('Caputira', 13);
insert tblCIDADE values ('Cara�', 13);
insert tblCIDADE values ('Carana�ba', 13);
insert tblCIDADE values ('Caranda�', 13);
insert tblCIDADE values ('Carangola', 13);
insert tblCIDADE values ('Caratinga', 13);
insert tblCIDADE values ('Carbonita', 13);
insert tblCIDADE values ('Carea�u', 13);
insert tblCIDADE values ('Carlos Chagas', 13);
insert tblCIDADE values ('Carm�sia', 13);
insert tblCIDADE values ('Carmo da Cachoeira', 13);
insert tblCIDADE values ('Carmo da Mata', 13);
insert tblCIDADE values ('Carmo de Minas', 13);
insert tblCIDADE values ('Carmo do Cajuru', 13);
insert tblCIDADE values ('Carmo do Parana�ba', 13);
insert tblCIDADE values ('Carmo do Rio Claro', 13);
insert tblCIDADE values ('Carm�polis de Minas', 13);
insert tblCIDADE values ('Carneirinho', 13);
insert tblCIDADE values ('Carrancas', 13);
insert tblCIDADE values ('Carvalh�polis', 13);
insert tblCIDADE values ('Carvalhos', 13);
insert tblCIDADE values ('Casa Grande', 13);
insert tblCIDADE values ('Cascalho Rico', 13);
insert tblCIDADE values ('C�ssia', 13);
insert tblCIDADE values ('Concei��o da Barra de Minas', 13);
insert tblCIDADE values ('Cataguases', 13);
insert tblCIDADE values ('Catas Altas', 13);
insert tblCIDADE values ('Catas Altas da Noruega', 13);
insert tblCIDADE values ('Catuji', 13);
insert tblCIDADE values ('Catuti', 13);
insert tblCIDADE values ('Caxambu', 13);
insert tblCIDADE values ('Cedro do Abaet�', 13);
insert tblCIDADE values ('Central de Minas', 13);
insert tblCIDADE values ('Centralina', 13);
insert tblCIDADE values ('Ch�cara', 13);
insert tblCIDADE values ('Chal�', 13);
insert tblCIDADE values ('Chapada do Norte', 13);
insert tblCIDADE values ('Chapada Ga�cha', 13);
insert tblCIDADE values ('Chiador', 13);
insert tblCIDADE values ('Cipot�nea', 13);
insert tblCIDADE values ('Claraval', 13);
insert tblCIDADE values ('Claro dos Po��es', 13);
insert tblCIDADE values ('Cl�udio', 13);
insert tblCIDADE values ('Coimbra', 13);
insert tblCIDADE values ('Coluna', 13);
insert tblCIDADE values ('Comendador Gomes', 13);
insert tblCIDADE values ('Comercinho', 13);
insert tblCIDADE values ('Concei��o da Aparecida', 13);
insert tblCIDADE values ('Concei��o das Pedras', 13);
insert tblCIDADE values ('Concei��o das Alagoas', 13);
insert tblCIDADE values ('Concei��o de Ipanema', 13);
insert tblCIDADE values ('Concei��o do Mato Dentro', 13);
insert tblCIDADE values ('Concei��o do Par�', 13);
insert tblCIDADE values ('Concei��o do Rio Verde', 13);
insert tblCIDADE values ('Concei��o dos Ouros', 13);
insert tblCIDADE values ('C�nego Marinho', 13);
insert tblCIDADE values ('Confins', 13);
insert tblCIDADE values ('Congonhal', 13);
insert tblCIDADE values ('Congonhas', 13);
insert tblCIDADE values ('Congonhas do Norte', 13);
insert tblCIDADE values ('Conquista', 13);
insert tblCIDADE values ('Conselheiro Lafaiete', 13);
insert tblCIDADE values ('Conselheiro Pena', 13);
insert tblCIDADE values ('Consola��o', 13);
insert tblCIDADE values ('Contagem', 13);
insert tblCIDADE values ('Coqueiral', 13);
insert tblCIDADE values ('Cora��o de Jesus', 13);
insert tblCIDADE values ('Cordisburgo', 13);
insert tblCIDADE values ('Cordisl�ndia', 13);
insert tblCIDADE values ('Corinto', 13);
insert tblCIDADE values ('Coroaci', 13);
insert tblCIDADE values ('Coromandel', 13);
insert tblCIDADE values ('Coronel Fabriciano', 13);
insert tblCIDADE values ('Coronel Murta', 13);
insert tblCIDADE values ('Coronel Pacheco', 13);
insert tblCIDADE values ('Coronel Xavier Chaves', 13);
insert tblCIDADE values ('C�rrego Danta', 13);
insert tblCIDADE values ('C�rrego do Bom Jesus', 13);
insert tblCIDADE values ('C�rrego Fundo', 13);
insert tblCIDADE values ('C�rrego Novo', 13);
insert tblCIDADE values ('Couto de Magalh�es de Minas', 13);
insert tblCIDADE values ('Cris�lita', 13);
insert tblCIDADE values ('Cristais', 13);
insert tblCIDADE values ('Crist�lia', 13);
insert tblCIDADE values ('Cristiano Otoni', 13);
insert tblCIDADE values ('Cristina', 13);
insert tblCIDADE values ('Crucil�ndia', 13);
insert tblCIDADE values ('Cruzeiro da Fortaleza', 13);
insert tblCIDADE values ('Cruz�lia', 13);
insert tblCIDADE values ('Cuparaque', 13);
insert tblCIDADE values ('Curral de Dentro', 13);
insert tblCIDADE values ('Curvelo', 13);
insert tblCIDADE values ('Datas', 13);
insert tblCIDADE values ('Delfim Moreira', 13);
insert tblCIDADE values ('Delfin�polis', 13);
insert tblCIDADE values ('Delta', 13);
insert tblCIDADE values ('Descoberto', 13);
insert tblCIDADE values ('Desterro de Entre Rios', 13);
insert tblCIDADE values ('Desterro do Melo', 13);
insert tblCIDADE values ('Diamantina', 13);
insert tblCIDADE values ('Diogo de Vasconcelos', 13);
insert tblCIDADE values ('Dion�sio', 13);
insert tblCIDADE values ('Divin�sia', 13);
insert tblCIDADE values ('Divino', 13);
insert tblCIDADE values ('Divino das Laranjeiras', 13);
insert tblCIDADE values ('Divinol�ndia de Minas', 13);
insert tblCIDADE values ('Divin�polis', 13);
insert tblCIDADE values ('Divisa Alegre', 13);
insert tblCIDADE values ('Divisa Nova', 13);
insert tblCIDADE values ('Divis�polis', 13);
insert tblCIDADE values ('Dom Bosco', 13);
insert tblCIDADE values ('Dom Cavati', 13);
insert tblCIDADE values ('Dom Joaquim', 13);
insert tblCIDADE values ('Dom Silv�rio', 13);
insert tblCIDADE values ('Dom Vi�oso', 13);
insert tblCIDADE values ('Dona Eus�bia', 13);
insert tblCIDADE values ('Dores de Campos', 13);
insert tblCIDADE values ('Dores de Guanh�es', 13);
insert tblCIDADE values ('Dores do Indai�', 13);
insert tblCIDADE values ('Dores do Turvo', 13);
insert tblCIDADE values ('Dores�polis', 13);
insert tblCIDADE values ('Douradoquara', 13);
insert tblCIDADE values ('Durand�', 13);
insert tblCIDADE values ('El�i Mendes', 13);
insert tblCIDADE values ('Engenheiro Caldas', 13);
insert tblCIDADE values ('Engenheiro Navarro', 13);
insert tblCIDADE values ('Entre Folhas', 13);
insert tblCIDADE values ('Entre Rios de Minas', 13);
insert tblCIDADE values ('Erv�lia', 13);
insert tblCIDADE values ('Esmeraldas', 13);
insert tblCIDADE values ('Espera Feliz', 13);
insert tblCIDADE values ('Espinosa', 13);
insert tblCIDADE values ('Esp�rito Santo do Dourado', 13);
insert tblCIDADE values ('Estiva', 13);
insert tblCIDADE values ('Estrela Dalva', 13);
insert tblCIDADE values ('Estrela do Indai�', 13);
insert tblCIDADE values ('Estrela do Sul', 13);
insert tblCIDADE values ('Eugen�polis', 13);
insert tblCIDADE values ('Ewbank da C�mara', 13);
insert tblCIDADE values ('Extrema', 13);
insert tblCIDADE values ('Fama', 13);
insert tblCIDADE values ('Faria Lemos', 13);
insert tblCIDADE values ('Fel�cio dos Santos', 13);
insert tblCIDADE values ('S�o Gon�alo do Rio Preto', 13);
insert tblCIDADE values ('Felisburgo', 13);
insert tblCIDADE values ('Felixl�ndia', 13);
insert tblCIDADE values ('Fernandes Tourinho', 13);
insert tblCIDADE values ('Ferros', 13);
insert tblCIDADE values ('Fervedouro', 13);
insert tblCIDADE values ('Florestal', 13);
insert tblCIDADE values ('Formiga', 13);
insert tblCIDADE values ('Formoso', 13);
insert tblCIDADE values ('Fortaleza de Minas', 13);
insert tblCIDADE values ('Fortuna de Minas', 13);
insert tblCIDADE values ('Francisco Badar�', 13);
insert tblCIDADE values ('Francisco Dumont', 13);
insert tblCIDADE values ('Francisco S�', 13);
insert tblCIDADE values ('Francisc�polis', 13);
insert tblCIDADE values ('Frei Gaspar', 13);
insert tblCIDADE values ('Frei Inoc�ncio', 13);
insert tblCIDADE values ('Frei Lagonegro', 13);
insert tblCIDADE values ('Fronteira', 13);
insert tblCIDADE values ('Fronteira dos Vales', 13);
insert tblCIDADE values ('Fruta de Leite', 13);
insert tblCIDADE values ('Frutal', 13);
insert tblCIDADE values ('Funil�ndia', 13);
insert tblCIDADE values ('Galil�ia', 13);
insert tblCIDADE values ('Gameleiras', 13);
insert tblCIDADE values ('Glaucil�ndia', 13);
insert tblCIDADE values ('Goiabeira', 13);
insert tblCIDADE values ('Goian�', 13);
insert tblCIDADE values ('Gon�alves', 13);
insert tblCIDADE values ('Gonzaga', 13);
insert tblCIDADE values ('Gouveia', 13);
insert tblCIDADE values ('Governador Valadares', 13);
insert tblCIDADE values ('Gr�o Mogol', 13);
insert tblCIDADE values ('Grupiara', 13);
insert tblCIDADE values ('Guanh�es', 13);
insert tblCIDADE values ('Guap�', 13);
insert tblCIDADE values ('Guaraciaba', 13);
insert tblCIDADE values ('Guaraciama', 13);
insert tblCIDADE values ('Guaran�sia', 13);
insert tblCIDADE values ('Guarani', 13);
insert tblCIDADE values ('Guarar�', 13);
insert tblCIDADE values ('Guarda-Mor', 13);
insert tblCIDADE values ('Guaxup�', 13);
insert tblCIDADE values ('Guidoval', 13);
insert tblCIDADE values ('Guimar�nia', 13);
insert tblCIDADE values ('Guiricema', 13);
insert tblCIDADE values ('Gurinhat�', 13);
insert tblCIDADE values ('Heliodora', 13);
insert tblCIDADE values ('Iapu', 13);
insert tblCIDADE values ('Ibertioga', 13);
insert tblCIDADE values ('Ibi�', 13);
insert tblCIDADE values ('Ibia�', 13);
insert tblCIDADE values ('Ibiracatu', 13);
insert tblCIDADE values ('Ibiraci', 13);
insert tblCIDADE values ('Ibirit�', 13);
insert tblCIDADE values ('Ibiti�ra de Minas', 13);
insert tblCIDADE values ('Ibituruna', 13);
insert tblCIDADE values ('Icara� de Minas', 13);
insert tblCIDADE values ('Igarap�', 13);
insert tblCIDADE values ('Igaratinga', 13);
insert tblCIDADE values ('Iguatama', 13);
insert tblCIDADE values ('Ijaci', 13);
insert tblCIDADE values ('Ilic�nea', 13);
insert tblCIDADE values ('Imb� de Minas', 13);
insert tblCIDADE values ('Inconfidentes', 13);
insert tblCIDADE values ('Indaiabira', 13);
insert tblCIDADE values ('Indian�polis', 13);
insert tblCIDADE values ('Inga�', 13);
insert tblCIDADE values ('Inhapim', 13);
insert tblCIDADE values ('Inha�ma', 13);
insert tblCIDADE values ('Inimutaba', 13);
insert tblCIDADE values ('Ipaba', 13);
insert tblCIDADE values ('Ipanema', 13);
insert tblCIDADE values ('Ipatinga', 13);
insert tblCIDADE values ('Ipia�u', 13);
insert tblCIDADE values ('Ipui�na', 13);
insert tblCIDADE values ('Ira� de Minas', 13);
insert tblCIDADE values ('Itabira', 13);
insert tblCIDADE values ('Itabirinha', 13);
insert tblCIDADE values ('Itabirito', 13);
insert tblCIDADE values ('Itacambira', 13);
insert tblCIDADE values ('Itacarambi', 13);
insert tblCIDADE values ('Itaguara', 13);
insert tblCIDADE values ('Itaip�', 13);
insert tblCIDADE values ('Itajub�', 13);
insert tblCIDADE values ('Itamarandiba', 13);
insert tblCIDADE values ('Itamarati de Minas', 13);
insert tblCIDADE values ('Itambacuri', 13);
insert tblCIDADE values ('Itamb� do Mato Dentro', 13);
insert tblCIDADE values ('Itamogi', 13);
insert tblCIDADE values ('Itamonte', 13);
insert tblCIDADE values ('Itanhandu', 13);
insert tblCIDADE values ('Itanhomi', 13);
insert tblCIDADE values ('Itaobim', 13);
insert tblCIDADE values ('Itapagipe', 13);
insert tblCIDADE values ('Itapecerica', 13);
insert tblCIDADE values ('Itapeva', 13);
insert tblCIDADE values ('Itatiaiu�u', 13);
insert tblCIDADE values ('Ita� de Minas', 13);
insert tblCIDADE values ('Ita�na', 13);
insert tblCIDADE values ('Itaverava', 13);
insert tblCIDADE values ('Itinga', 13);
insert tblCIDADE values ('Itueta', 13);
insert tblCIDADE values ('Ituiutaba', 13);
insert tblCIDADE values ('Itumirim', 13);
insert tblCIDADE values ('Iturama', 13);
insert tblCIDADE values ('Itutinga', 13);
insert tblCIDADE values ('Jaboticatubas', 13);
insert tblCIDADE values ('Jacinto', 13);
insert tblCIDADE values ('Jacu�', 13);
insert tblCIDADE values ('Jacutinga', 13);
insert tblCIDADE values ('Jaguara�u', 13);
insert tblCIDADE values ('Ja�ba', 13);
insert tblCIDADE values ('Jampruca', 13);
insert tblCIDADE values ('Jana�ba', 13);
insert tblCIDADE values ('Janu�ria', 13);
insert tblCIDADE values ('Japara�ba', 13);
insert tblCIDADE values ('Japonvar', 13);
insert tblCIDADE values ('Jeceaba', 13);
insert tblCIDADE values ('Jenipapo de Minas', 13);
insert tblCIDADE values ('Jequeri', 13);
insert tblCIDADE values ('Jequita�', 13);
insert tblCIDADE values ('Jequitib�', 13);
insert tblCIDADE values ('Jequitinhonha', 13);
insert tblCIDADE values ('Jesu�nia', 13);
insert tblCIDADE values ('Joa�ma', 13);
insert tblCIDADE values ('Joan�sia', 13);
insert tblCIDADE values ('Jo�o Monlevade', 13);
insert tblCIDADE values ('Jo�o Pinheiro', 13);
insert tblCIDADE values ('Joaquim Fel�cio', 13);
insert tblCIDADE values ('Jord�nia', 13);
insert tblCIDADE values ('Jos� Gon�alves de Minas', 13);
insert tblCIDADE values ('Jos� Raydan', 13);
insert tblCIDADE values ('Josen�polis', 13);
insert tblCIDADE values ('Nova Uni�o', 13);
insert tblCIDADE values ('Juatuba', 13);
insert tblCIDADE values ('Juiz de Fora', 13);
insert tblCIDADE values ('Juramento', 13);
insert tblCIDADE values ('Juruaia', 13);
insert tblCIDADE values ('Juven�lia', 13);
insert tblCIDADE values ('Ladainha', 13);
insert tblCIDADE values ('Lagamar', 13);
insert tblCIDADE values ('Lagoa da Prata', 13);
insert tblCIDADE values ('Lagoa dos Patos', 13);
insert tblCIDADE values ('Lagoa Dourada', 13);
insert tblCIDADE values ('Lagoa Formosa', 13);
insert tblCIDADE values ('Lagoa Grande', 13);
insert tblCIDADE values ('Lagoa Santa', 13);
insert tblCIDADE values ('Lajinha', 13);
insert tblCIDADE values ('Lambari', 13);
insert tblCIDADE values ('Lamim', 13);
insert tblCIDADE values ('Laranjal', 13);
insert tblCIDADE values ('Lassance', 13);
insert tblCIDADE values ('Lavras', 13);
insert tblCIDADE values ('Leandro Ferreira', 13);
insert tblCIDADE values ('Leme do Prado', 13);
insert tblCIDADE values ('Leopoldina', 13);
insert tblCIDADE values ('Liberdade', 13);
insert tblCIDADE values ('Lima Duarte', 13);
insert tblCIDADE values ('Limeira do Oeste', 13);
insert tblCIDADE values ('Lontra', 13);
insert tblCIDADE values ('Luisburgo', 13);
insert tblCIDADE values ('Luisl�ndia', 13);
insert tblCIDADE values ('Lumin�rias', 13);
insert tblCIDADE values ('Luz', 13);
insert tblCIDADE values ('Machacalis', 13);
insert tblCIDADE values ('Machado', 13);
insert tblCIDADE values ('Madre de Deus de Minas', 13);
insert tblCIDADE values ('Malacacheta', 13);
insert tblCIDADE values ('Mamonas', 13);
insert tblCIDADE values ('Manga', 13);
insert tblCIDADE values ('Manhua�u', 13);
insert tblCIDADE values ('Manhumirim', 13);
insert tblCIDADE values ('Mantena', 13);
insert tblCIDADE values ('Maravilhas', 13);
insert tblCIDADE values ('Mar de Espanha', 13);
insert tblCIDADE values ('Maria da F�', 13);
insert tblCIDADE values ('Mariana', 13);
insert tblCIDADE values ('Marilac', 13);
insert tblCIDADE values ('M�rio Campos', 13);
insert tblCIDADE values ('Marip� de Minas', 13);
insert tblCIDADE values ('Marli�ria', 13);
insert tblCIDADE values ('Marmel�polis', 13);
insert tblCIDADE values ('Martinho Campos', 13);
insert tblCIDADE values ('Martins Soares', 13);
insert tblCIDADE values ('Mata Verde', 13);
insert tblCIDADE values ('Materl�ndia', 13);
insert tblCIDADE values ('Mateus Leme', 13);
insert tblCIDADE values ('Matias Barbosa', 13);
insert tblCIDADE values ('Matias Cardoso', 13);
insert tblCIDADE values ('Matip�', 13);
insert tblCIDADE values ('Mato Verde', 13);
insert tblCIDADE values ('Matozinhos', 13);
insert tblCIDADE values ('Matutina', 13);
insert tblCIDADE values ('Medeiros', 13);
insert tblCIDADE values ('Medina', 13);
insert tblCIDADE values ('Mendes Pimentel', 13);
insert tblCIDADE values ('Merc�s', 13);
insert tblCIDADE values ('Mesquita', 13);
insert tblCIDADE values ('Minas Novas', 13);
insert tblCIDADE values ('Minduri', 13);
insert tblCIDADE values ('Mirabela', 13);
insert tblCIDADE values ('Miradouro', 13);
insert tblCIDADE values ('Mira�', 13);
insert tblCIDADE values ('Mirav�nia', 13);
insert tblCIDADE values ('Moeda', 13);
insert tblCIDADE values ('Moema', 13);
insert tblCIDADE values ('Monjolos', 13);
insert tblCIDADE values ('Monsenhor Paulo', 13);
insert tblCIDADE values ('Montalv�nia', 13);
insert tblCIDADE values ('Monte Alegre de Minas', 13);
insert tblCIDADE values ('Monte Azul', 13);
insert tblCIDADE values ('Monte Belo', 13);
insert tblCIDADE values ('Monte Carmelo', 13);
insert tblCIDADE values ('Monte Formoso', 13);
insert tblCIDADE values ('Monte Santo de Minas', 13);
insert tblCIDADE values ('Montes Claros', 13);
insert tblCIDADE values ('Monte Si�o', 13);
insert tblCIDADE values ('Montezuma', 13);
insert tblCIDADE values ('Morada Nova de Minas', 13);
insert tblCIDADE values ('Morro da Gar�a', 13);
insert tblCIDADE values ('Morro do Pilar', 13);
insert tblCIDADE values ('Munhoz', 13);
insert tblCIDADE values ('Muria�', 13);
insert tblCIDADE values ('Mutum', 13);
insert tblCIDADE values ('Muzambinho', 13);
insert tblCIDADE values ('Nacip Raydan', 13);
insert tblCIDADE values ('Nanuque', 13);
insert tblCIDADE values ('Naque', 13);
insert tblCIDADE values ('Natal�ndia', 13);
insert tblCIDADE values ('Nat�rcia', 13);
insert tblCIDADE values ('Nazareno', 13);
insert tblCIDADE values ('Nepomuceno', 13);
insert tblCIDADE values ('Ninheira', 13);
insert tblCIDADE values ('Nova Bel�m', 13);
insert tblCIDADE values ('Nova Era', 13);
insert tblCIDADE values ('Nova Lima', 13);
insert tblCIDADE values ('Nova M�dica', 13);
insert tblCIDADE values ('Nova Ponte', 13);
insert tblCIDADE values ('Nova Porteirinha', 13);
insert tblCIDADE values ('Nova Resende', 13);
insert tblCIDADE values ('Nova Serrana', 13);
insert tblCIDADE values ('Novo Cruzeiro', 13);
insert tblCIDADE values ('Novo Oriente de Minas', 13);
insert tblCIDADE values ('Novorizonte', 13);
insert tblCIDADE values ('Olaria', 13);
insert tblCIDADE values ('Olhos-d''�gua', 13);
insert tblCIDADE values ('Ol�mpio Noronha', 13);
insert tblCIDADE values ('Oliveira', 13);
insert tblCIDADE values ('Oliveira Fortes', 13);
insert tblCIDADE values ('On�a de Pitangui', 13);
insert tblCIDADE values ('Orat�rios', 13);
insert tblCIDADE values ('Oriz�nia', 13);
insert tblCIDADE values ('Ouro Branco', 13);
insert tblCIDADE values ('Ouro Fino', 13);
insert tblCIDADE values ('Ouro Preto', 13);
insert tblCIDADE values ('Ouro Verde de Minas', 13);
insert tblCIDADE values ('Padre Carvalho', 13);
insert tblCIDADE values ('Padre Para�so', 13);
insert tblCIDADE values ('Paineiras', 13);
insert tblCIDADE values ('Pains', 13);
insert tblCIDADE values ('Pai Pedro', 13);
insert tblCIDADE values ('Paiva', 13);
insert tblCIDADE values ('Palma', 13);
insert tblCIDADE values ('Palm�polis', 13);
insert tblCIDADE values ('Papagaios', 13);
insert tblCIDADE values ('Paracatu', 13);
insert tblCIDADE values ('Par� de Minas', 13);
insert tblCIDADE values ('Paragua�u', 13);
insert tblCIDADE values ('Parais�polis', 13);
insert tblCIDADE values ('Paraopeba', 13);
insert tblCIDADE values ('Passab�m', 13);
insert tblCIDADE values ('Passa Quatro', 13);
insert tblCIDADE values ('Passa Tempo', 13);
insert tblCIDADE values ('Passa-Vinte', 13);
insert tblCIDADE values ('Passos', 13);
insert tblCIDADE values ('Patis', 13);
insert tblCIDADE values ('Patos de Minas', 13);
insert tblCIDADE values ('Patroc�nio', 13);
insert tblCIDADE values ('Patroc�nio do Muria�', 13);
insert tblCIDADE values ('Paula C�ndido', 13);
insert tblCIDADE values ('Paulistas', 13);
insert tblCIDADE values ('Pav�o', 13);
insert tblCIDADE values ('Pe�anha', 13);
insert tblCIDADE values ('Pedra Azul', 13);
insert tblCIDADE values ('Pedra Bonita', 13);
insert tblCIDADE values ('Pedra do Anta', 13);
insert tblCIDADE values ('Pedra do Indai�', 13);
insert tblCIDADE values ('Pedra Dourada', 13);
insert tblCIDADE values ('Pedralva', 13);
insert tblCIDADE values ('Pedras de Maria da Cruz', 13);
insert tblCIDADE values ('Pedrin�polis', 13);
insert tblCIDADE values ('Pedro Leopoldo', 13);
insert tblCIDADE values ('Pedro Teixeira', 13);
insert tblCIDADE values ('Pequeri', 13);
insert tblCIDADE values ('Pequi', 13);
insert tblCIDADE values ('Perdig�o', 13);
insert tblCIDADE values ('Perdizes', 13);
insert tblCIDADE values ('Perd�es', 13);
insert tblCIDADE values ('Periquito', 13);
insert tblCIDADE values ('Pescador', 13);
insert tblCIDADE values ('Piau', 13);
insert tblCIDADE values ('Piedade de Caratinga', 13);
insert tblCIDADE values ('Piedade de Ponte Nova', 13);
insert tblCIDADE values ('Piedade do Rio Grande', 13);
insert tblCIDADE values ('Piedade dos Gerais', 13);
insert tblCIDADE values ('Pimenta', 13);
insert tblCIDADE values ('Pingo-d''�gua', 13);
insert tblCIDADE values ('Pint�polis', 13);
insert tblCIDADE values ('Piracema', 13);
insert tblCIDADE values ('Pirajuba', 13);
insert tblCIDADE values ('Piranga', 13);
insert tblCIDADE values ('Pirangu�u', 13);
insert tblCIDADE values ('Piranguinho', 13);
insert tblCIDADE values ('Pirapetinga', 13);
insert tblCIDADE values ('Pirapora', 13);
insert tblCIDADE values ('Pira�ba', 13);
insert tblCIDADE values ('Pitangui', 13);
insert tblCIDADE values ('Piumhi', 13);
insert tblCIDADE values ('Planura', 13);
insert tblCIDADE values ('Po�o Fundo', 13);
insert tblCIDADE values ('Po�os de Caldas', 13);
insert tblCIDADE values ('Pocrane', 13);
insert tblCIDADE values ('Pomp�u', 13);
insert tblCIDADE values ('Ponte Nova', 13);
insert tblCIDADE values ('Ponto Chique', 13);
insert tblCIDADE values ('Ponto dos Volantes', 13);
insert tblCIDADE values ('Porteirinha', 13);
insert tblCIDADE values ('Porto Firme', 13);
insert tblCIDADE values ('Pot�', 13);
insert tblCIDADE values ('Pouso Alegre', 13);
insert tblCIDADE values ('Pouso Alto', 13);
insert tblCIDADE values ('Prados', 13);
insert tblCIDADE values ('Prata', 13);
insert tblCIDADE values ('Prat�polis', 13);
insert tblCIDADE values ('Pratinha', 13);
insert tblCIDADE values ('Presidente Bernardes', 13);
insert tblCIDADE values ('Presidente Juscelino', 13);
insert tblCIDADE values ('Presidente Kubitschek', 13);
insert tblCIDADE values ('Presidente Oleg�rio', 13);
insert tblCIDADE values ('Alto Jequitib�', 13);
insert tblCIDADE values ('Prudente de Morais', 13);
insert tblCIDADE values ('Quartel Geral', 13);
insert tblCIDADE values ('Queluzito', 13);
insert tblCIDADE values ('Raposos', 13);
insert tblCIDADE values ('Raul Soares', 13);
insert tblCIDADE values ('Recreio', 13);
insert tblCIDADE values ('Reduto', 13);
insert tblCIDADE values ('Resende Costa', 13);
insert tblCIDADE values ('Resplendor', 13);
insert tblCIDADE values ('Ressaquinha', 13);
insert tblCIDADE values ('Riachinho', 13);
insert tblCIDADE values ('Riacho dos Machados', 13);
insert tblCIDADE values ('Ribeir�o das Neves', 13);
insert tblCIDADE values ('Ribeir�o Vermelho', 13);
insert tblCIDADE values ('Rio Acima', 13);
insert tblCIDADE values ('Rio Casca', 13);
insert tblCIDADE values ('Rio Doce', 13);
insert tblCIDADE values ('Rio do Prado', 13);
insert tblCIDADE values ('Rio Espera', 13);
insert tblCIDADE values ('Rio Manso', 13);
insert tblCIDADE values ('Rio Novo', 13);
insert tblCIDADE values ('Rio Parana�ba', 13);
insert tblCIDADE values ('Rio Pardo de Minas', 13);
insert tblCIDADE values ('Rio Piracicaba', 13);
insert tblCIDADE values ('Rio Pomba', 13);
insert tblCIDADE values ('Rio Preto', 13);
insert tblCIDADE values ('Rio Vermelho', 13);
insert tblCIDADE values ('Rit�polis', 13);
insert tblCIDADE values ('Rochedo de Minas', 13);
insert tblCIDADE values ('Rodeiro', 13);
insert tblCIDADE values ('Romaria', 13);
insert tblCIDADE values ('Ros�rio da Limeira', 13);
insert tblCIDADE values ('Rubelita', 13);
insert tblCIDADE values ('Rubim', 13);
insert tblCIDADE values ('Sabar�', 13);
insert tblCIDADE values ('Sabin�polis', 13);
insert tblCIDADE values ('Sacramento', 13);
insert tblCIDADE values ('Salinas', 13);
insert tblCIDADE values ('Salto da Divisa', 13);
insert tblCIDADE values ('Santa B�rbara', 13);
insert tblCIDADE values ('Santa B�rbara do Leste', 13);
insert tblCIDADE values ('Santa B�rbara do Monte Verde', 13);
insert tblCIDADE values ('Santa B�rbara do Tug�rio', 13);
insert tblCIDADE values ('Santa Cruz de Minas', 13);
insert tblCIDADE values ('Santa Cruz de Salinas', 13);
insert tblCIDADE values ('Santa Cruz do Escalvado', 13);
insert tblCIDADE values ('Santa Efig�nia de Minas', 13);
insert tblCIDADE values ('Santa F� de Minas', 13);
insert tblCIDADE values ('Santa Helena de Minas', 13);
insert tblCIDADE values ('Santa Juliana', 13);
insert tblCIDADE values ('Santa Luzia', 13);
insert tblCIDADE values ('Santa Margarida', 13);
insert tblCIDADE values ('Santa Maria de Itabira', 13);
insert tblCIDADE values ('Santa Maria do Salto', 13);
insert tblCIDADE values ('Santa Maria do Sua�u�', 13);
insert tblCIDADE values ('Santana da Vargem', 13);
insert tblCIDADE values ('Santana de Cataguases', 13);
insert tblCIDADE values ('Santana de Pirapama', 13);
insert tblCIDADE values ('Santana do Deserto', 13);
insert tblCIDADE values ('Santana do Garamb�u', 13);
insert tblCIDADE values ('Santana do Jacar�', 13);
insert tblCIDADE values ('Santana do Manhua�u', 13);
insert tblCIDADE values ('Santana do Para�so', 13);
insert tblCIDADE values ('Santana do Riacho', 13);
insert tblCIDADE values ('Santana dos Montes', 13);
insert tblCIDADE values ('Santa Rita de Caldas', 13);
insert tblCIDADE values ('Santa Rita de Jacutinga', 13);
insert tblCIDADE values ('Santa Rita de Minas', 13);
insert tblCIDADE values ('Santa Rita de Ibitipoca', 13);
insert tblCIDADE values ('Santa Rita do Itueto', 13);
insert tblCIDADE values ('Santa Rita do Sapuca�', 13);
insert tblCIDADE values ('Santa Rosa da Serra', 13);
insert tblCIDADE values ('Santa Vit�ria', 13);
insert tblCIDADE values ('Santo Ant�nio do Amparo', 13);
insert tblCIDADE values ('Santo Ant�nio do Aventureiro', 13);
insert tblCIDADE values ('Santo Ant�nio do Grama', 13);
insert tblCIDADE values ('Santo Ant�nio do Itamb�', 13);
insert tblCIDADE values ('Santo Ant�nio do Jacinto', 13);
insert tblCIDADE values ('Santo Ant�nio do Monte', 13);
insert tblCIDADE values ('Santo Ant�nio do Retiro', 13);
insert tblCIDADE values ('Santo Ant�nio do Rio Abaixo', 13);
insert tblCIDADE values ('Santo Hip�lito', 13);
insert tblCIDADE values ('Santos Dumont', 13);
insert tblCIDADE values ('S�o Bento Abade', 13);
insert tblCIDADE values ('S�o Br�s do Sua�u�', 13);
insert tblCIDADE values ('S�o Domingos das Dores', 13);
insert tblCIDADE values ('S�o Domingos do Prata', 13);
insert tblCIDADE values ('S�o F�lix de Minas', 13);
insert tblCIDADE values ('S�o Francisco', 13);
insert tblCIDADE values ('S�o Francisco de Paula', 13);
insert tblCIDADE values ('S�o Francisco de Sales', 13);
insert tblCIDADE values ('S�o Francisco do Gl�ria', 13);
insert tblCIDADE values ('S�o Geraldo', 13);
insert tblCIDADE values ('S�o Geraldo da Piedade', 13);
insert tblCIDADE values ('S�o Geraldo do Baixio', 13);
insert tblCIDADE values ('S�o Gon�alo do Abaet�', 13);
insert tblCIDADE values ('S�o Gon�alo do Par�', 13);
insert tblCIDADE values ('S�o Gon�alo do Rio Abaixo', 13);
insert tblCIDADE values ('S�o Gon�alo do Sapuca�', 13);
insert tblCIDADE values ('S�o Gotardo', 13);
insert tblCIDADE values ('S�o Jo�o Batista do Gl�ria', 13);
insert tblCIDADE values ('S�o Jo�o da Lagoa', 13);
insert tblCIDADE values ('S�o Jo�o da Mata', 13);
insert tblCIDADE values ('S�o Jo�o da Ponte', 13);
insert tblCIDADE values ('S�o Jo�o das Miss�es', 13);
insert tblCIDADE values ('S�o Jo�o del Rei', 13);
insert tblCIDADE values ('S�o Jo�o do Manhua�u', 13);
insert tblCIDADE values ('S�o Jo�o do Manteninha', 13);
insert tblCIDADE values ('S�o Jo�o do Oriente', 13);
insert tblCIDADE values ('S�o Jo�o do Pacu�', 13);
insert tblCIDADE values ('S�o Jo�o do Para�so', 13);
insert tblCIDADE values ('S�o Jo�o Evangelista', 13);
insert tblCIDADE values ('S�o Jo�o Nepomuceno', 13);
insert tblCIDADE values ('S�o Joaquim de Bicas', 13);
insert tblCIDADE values ('S�o Jos� da Barra', 13);
insert tblCIDADE values ('S�o Jos� da Lapa', 13);
insert tblCIDADE values ('S�o Jos� da Safira', 13);
insert tblCIDADE values ('S�o Jos� da Varginha', 13);
insert tblCIDADE values ('S�o Jos� do Alegre', 13);
insert tblCIDADE values ('S�o Jos� do Divino', 13);
insert tblCIDADE values ('S�o Jos� do Goiabal', 13);
insert tblCIDADE values ('S�o Jos� do Jacuri', 13);
insert tblCIDADE values ('S�o Jos� do Mantimento', 13);
insert tblCIDADE values ('S�o Louren�o', 13);
insert tblCIDADE values ('S�o Miguel do Anta', 13);
insert tblCIDADE values ('S�o Pedro da Uni�o', 13);
insert tblCIDADE values ('S�o Pedro dos Ferros', 13);
insert tblCIDADE values ('S�o Pedro do Sua�u�', 13);
insert tblCIDADE values ('S�o Rom�o', 13);
insert tblCIDADE values ('S�o Roque de Minas', 13);
insert tblCIDADE values ('S�o Sebasti�o da Bela Vista', 13);
insert tblCIDADE values ('S�o Sebasti�o da Vargem Alegre', 13);
insert tblCIDADE values ('S�o Sebasti�o do Anta', 13);
insert tblCIDADE values ('S�o Sebasti�o do Maranh�o', 13);
insert tblCIDADE values ('S�o Sebasti�o do Oeste', 13);
insert tblCIDADE values ('S�o Sebasti�o do Para�so', 13);
insert tblCIDADE values ('S�o Sebasti�o do Rio Preto', 13);
insert tblCIDADE values ('S�o Sebasti�o do Rio Verde', 13);
insert tblCIDADE values ('S�o Tiago', 13);
insert tblCIDADE values ('S�o Tom�s de Aquino', 13);
insert tblCIDADE values ('S�o Thom� das Letras', 13);
insert tblCIDADE values ('S�o Vicente de Minas', 13);
insert tblCIDADE values ('Sapuca�-Mirim', 13);
insert tblCIDADE values ('Sardo�', 13);
insert tblCIDADE values ('Sarzedo', 13);
insert tblCIDADE values ('Setubinha', 13);
insert tblCIDADE values ('Sem-Peixe', 13);
insert tblCIDADE values ('Senador Amaral', 13);
insert tblCIDADE values ('Senador Cortes', 13);
insert tblCIDADE values ('Senador Firmino', 13);
insert tblCIDADE values ('Senador Jos� Bento', 13);
insert tblCIDADE values ('Senador Modestino Gon�alves', 13);
insert tblCIDADE values ('Senhora de Oliveira', 13);
insert tblCIDADE values ('Senhora do Porto', 13);
insert tblCIDADE values ('Senhora dos Rem�dios', 13);
insert tblCIDADE values ('Sericita', 13);
insert tblCIDADE values ('Seritinga', 13);
insert tblCIDADE values ('Serra Azul de Minas', 13);
insert tblCIDADE values ('Serra da Saudade', 13);
insert tblCIDADE values ('Serra dos Aimor�s', 13);
insert tblCIDADE values ('Serra do Salitre', 13);
insert tblCIDADE values ('Serrania', 13);
insert tblCIDADE values ('Serran�polis de Minas', 13);
insert tblCIDADE values ('Serranos', 13);
insert tblCIDADE values ('Serro', 13);
insert tblCIDADE values ('Sete Lagoas', 13);
insert tblCIDADE values ('Silveir�nia', 13);
insert tblCIDADE values ('Silvian�polis', 13);
insert tblCIDADE values ('Sim�o Pereira', 13);
insert tblCIDADE values ('Simon�sia', 13);
insert tblCIDADE values ('Sobr�lia', 13);
insert tblCIDADE values ('Soledade de Minas', 13);
insert tblCIDADE values ('Tabuleiro', 13);
insert tblCIDADE values ('Taiobeiras', 13);
insert tblCIDADE values ('Taparuba', 13);
insert tblCIDADE values ('Tapira', 13);
insert tblCIDADE values ('Tapira�', 13);
insert tblCIDADE values ('Taquara�u de Minas', 13);
insert tblCIDADE values ('Tarumirim', 13);
insert tblCIDADE values ('Teixeiras', 13);
insert tblCIDADE values ('Te�filo Otoni', 13);
insert tblCIDADE values ('Tim�teo', 13);
insert tblCIDADE values ('Tiradentes', 13);
insert tblCIDADE values ('Tiros', 13);
insert tblCIDADE values ('Tocantins', 13);
insert tblCIDADE values ('Tocos do Moji', 13);
insert tblCIDADE values ('Toledo', 13);
insert tblCIDADE values ('Tombos', 13);
insert tblCIDADE values ('Tr�s Cora��es', 13);
insert tblCIDADE values ('Tr�s Marias', 13);
insert tblCIDADE values ('Tr�s Pontas', 13);
insert tblCIDADE values ('Tumiritinga', 13);
insert tblCIDADE values ('Tupaciguara', 13);
insert tblCIDADE values ('Turmalina', 13);
insert tblCIDADE values ('Turvol�ndia', 13);
insert tblCIDADE values ('Ub�', 13);
insert tblCIDADE values ('Uba�', 13);
insert tblCIDADE values ('Ubaporanga', 13);
insert tblCIDADE values ('Uberaba', 13);
insert tblCIDADE values ('Uberl�ndia', 13);
insert tblCIDADE values ('Umburatiba', 13);
insert tblCIDADE values ('Una�', 13);
insert tblCIDADE values ('Uni�o de Minas', 13);
insert tblCIDADE values ('Uruana de Minas', 13);
insert tblCIDADE values ('Uruc�nia', 13);
insert tblCIDADE values ('Urucuia', 13);
insert tblCIDADE values ('Vargem Alegre', 13);
insert tblCIDADE values ('Vargem Bonita', 13);
insert tblCIDADE values ('Vargem Grande do Rio Pardo', 13);
insert tblCIDADE values ('Varginha', 13);
insert tblCIDADE values ('Varj�o de Minas', 13);
insert tblCIDADE values ('V�rzea da Palma', 13);
insert tblCIDADE values ('Varzel�ndia', 13);
insert tblCIDADE values ('Vazante', 13);
insert tblCIDADE values ('Verdel�ndia', 13);
insert tblCIDADE values ('Veredinha', 13);
insert tblCIDADE values ('Ver�ssimo', 13);
insert tblCIDADE values ('Vermelho Novo', 13);
insert tblCIDADE values ('Vespasiano', 13);
insert tblCIDADE values ('Vi�osa', 13);
insert tblCIDADE values ('Vieiras', 13);
insert tblCIDADE values ('Mathias Lobato', 13);
insert tblCIDADE values ('Virgem da Lapa', 13);
insert tblCIDADE values ('Virg�nia', 13);
insert tblCIDADE values ('Virgin�polis', 13);
insert tblCIDADE values ('Virgol�ndia', 13);
insert tblCIDADE values ('Visconde do Rio Branco', 13);
insert tblCIDADE values ('Volta Grande', 13);
insert tblCIDADE values ('Wenceslau Braz', 13);
insert tblCIDADE values ('Abaetetuba', 14);
insert tblCIDADE values ('Abel Figueiredo', 14);
insert tblCIDADE values ('Acar�', 14);
insert tblCIDADE values ('Afu�', 14);
insert tblCIDADE values ('�gua Azul do Norte', 14);
insert tblCIDADE values ('Alenquer', 14);
insert tblCIDADE values ('Almeirim', 14);
insert tblCIDADE values ('Altamira', 14);
insert tblCIDADE values ('Anaj�s', 14);
insert tblCIDADE values ('Ananindeua', 14);
insert tblCIDADE values ('Anapu', 14);
insert tblCIDADE values ('Augusto Corr�a', 14);
insert tblCIDADE values ('Aurora do Par�', 14);
insert tblCIDADE values ('Aveiro', 14);
insert tblCIDADE values ('Bagre', 14);
insert tblCIDADE values ('Bai�o', 14);
insert tblCIDADE values ('Bannach', 14);
insert tblCIDADE values ('Barcarena', 14);
insert tblCIDADE values ('Bel�m', 14);
insert tblCIDADE values ('Belterra', 14);
insert tblCIDADE values ('Benevides', 14);
insert tblCIDADE values ('Bom Jesus do Tocantins', 14);
insert tblCIDADE values ('Bonito', 14);
insert tblCIDADE values ('Bragan�a', 14);
insert tblCIDADE values ('Brasil Novo', 14);
insert tblCIDADE values ('Brejo Grande do Araguaia', 14);
insert tblCIDADE values ('Breu Branco', 14);
insert tblCIDADE values ('Breves', 14);
insert tblCIDADE values ('Bujaru', 14);
insert tblCIDADE values ('Cachoeira do Piri�', 14);
insert tblCIDADE values ('Cachoeira do Arari', 14);
insert tblCIDADE values ('Camet�', 14);
insert tblCIDADE values ('Cana� dos Caraj�s', 14);
insert tblCIDADE values ('Capanema', 14);
insert tblCIDADE values ('Capit�o Po�o', 14);
insert tblCIDADE values ('Castanhal', 14);
insert tblCIDADE values ('Chaves', 14);
insert tblCIDADE values ('Colares', 14);
insert tblCIDADE values ('Concei��o do Araguaia', 14);
insert tblCIDADE values ('Conc�rdia do Par�', 14);
insert tblCIDADE values ('Cumaru do Norte', 14);
insert tblCIDADE values ('Curion�polis', 14);
insert tblCIDADE values ('Curralinho', 14);
insert tblCIDADE values ('Curu�', 14);
insert tblCIDADE values ('Curu��', 14);
insert tblCIDADE values ('Dom Eliseu', 14);
insert tblCIDADE values ('Eldorado dos Caraj�s', 14);
insert tblCIDADE values ('Faro', 14);
insert tblCIDADE values ('Floresta do Araguaia', 14);
insert tblCIDADE values ('Garraf�o do Norte', 14);
insert tblCIDADE values ('Goian�sia do Par�', 14);
insert tblCIDADE values ('Gurup�', 14);
insert tblCIDADE values ('Igarap�-A�u', 14);
insert tblCIDADE values ('Igarap�-Miri', 14);
insert tblCIDADE values ('Inhangapi', 14);
insert tblCIDADE values ('Ipixuna do Par�', 14);
insert tblCIDADE values ('Irituia', 14);
insert tblCIDADE values ('Itaituba', 14);
insert tblCIDADE values ('Itupiranga', 14);
insert tblCIDADE values ('Jacareacanga', 14);
insert tblCIDADE values ('Jacund�', 14);
insert tblCIDADE values ('Juruti', 14);
insert tblCIDADE values ('Limoeiro do Ajuru', 14);
insert tblCIDADE values ('M�e do Rio', 14);
insert tblCIDADE values ('Magalh�es Barata', 14);
insert tblCIDADE values ('Marab�', 14);
insert tblCIDADE values ('Maracan�', 14);
insert tblCIDADE values ('Marapanim', 14);
insert tblCIDADE values ('Marituba', 14);
insert tblCIDADE values ('Medicil�ndia', 14);
insert tblCIDADE values ('Melga�o', 14);
insert tblCIDADE values ('Mocajuba', 14);
insert tblCIDADE values ('Moju', 14);
insert tblCIDADE values ('Monte Alegre', 14);
insert tblCIDADE values ('Muan�', 14);
insert tblCIDADE values ('Nova Esperan�a do Piri�', 14);
insert tblCIDADE values ('Nova Ipixuna', 14);
insert tblCIDADE values ('Nova Timboteua', 14);
insert tblCIDADE values ('Novo Progresso', 14);
insert tblCIDADE values ('Novo Repartimento', 14);
insert tblCIDADE values ('�bidos', 14);
insert tblCIDADE values ('Oeiras do Par�', 14);
insert tblCIDADE values ('Oriximin�', 14);
insert tblCIDADE values ('Our�m', 14);
insert tblCIDADE values ('Ouril�ndia do Norte', 14);
insert tblCIDADE values ('Pacaj�', 14);
insert tblCIDADE values ('Palestina do Par�', 14);
insert tblCIDADE values ('Paragominas', 14);
insert tblCIDADE values ('Parauapebas', 14);
insert tblCIDADE values ('Pau D''Arco', 14);
insert tblCIDADE values ('Peixe-Boi', 14);
insert tblCIDADE values ('Pi�arra', 14);
insert tblCIDADE values ('Placas', 14);
insert tblCIDADE values ('Ponta de Pedras', 14);
insert tblCIDADE values ('Portel', 14);
insert tblCIDADE values ('Porto de Moz', 14);
insert tblCIDADE values ('Prainha', 14);
insert tblCIDADE values ('Primavera', 14);
insert tblCIDADE values ('Quatipuru', 14);
insert tblCIDADE values ('Reden��o', 14);
insert tblCIDADE values ('Rio Maria', 14);
insert tblCIDADE values ('Rondon do Par�', 14);
insert tblCIDADE values ('Rur�polis', 14);
insert tblCIDADE values ('Salin�polis', 14);
insert tblCIDADE values ('Salvaterra', 14);
insert tblCIDADE values ('Santa B�rbara do Par�', 14);
insert tblCIDADE values ('Santa Cruz do Arari', 14);
insert tblCIDADE values ('Santa Isabel do Par�', 14);
insert tblCIDADE values ('Santa Luzia do Par�', 14);
insert tblCIDADE values ('Santa Maria das Barreiras', 14);
insert tblCIDADE values ('Santa Maria do Par�', 14);
insert tblCIDADE values ('Santana do Araguaia', 14);
insert tblCIDADE values ('Santar�m', 14);
insert tblCIDADE values ('Santar�m Novo', 14);
insert tblCIDADE values ('Santo Ant�nio do Tau�', 14);
insert tblCIDADE values ('S�o Caetano de Odivelas', 14);
insert tblCIDADE values ('S�o Domingos do Araguaia', 14);
insert tblCIDADE values ('S�o Domingos do Capim', 14);
insert tblCIDADE values ('S�o F�lix do Xingu', 14);
insert tblCIDADE values ('S�o Francisco do Par�', 14);
insert tblCIDADE values ('S�o Geraldo do Araguaia', 14);
insert tblCIDADE values ('S�o Jo�o da Ponta', 14);
insert tblCIDADE values ('S�o Jo�o de Pirabas', 14);
insert tblCIDADE values ('S�o Jo�o do Araguaia', 14);
insert tblCIDADE values ('S�o Miguel do Guam�', 14);
insert tblCIDADE values ('S�o Sebasti�o da Boa Vista', 14);
insert tblCIDADE values ('Sapucaia', 14);
insert tblCIDADE values ('Senador Jos� Porf�rio', 14);
insert tblCIDADE values ('Soure', 14);
insert tblCIDADE values ('Tail�ndia', 14);
insert tblCIDADE values ('Terra Alta', 14);
insert tblCIDADE values ('Terra Santa', 14);
insert tblCIDADE values ('Tom�-A�u', 14);
insert tblCIDADE values ('Tracuateua', 14);
insert tblCIDADE values ('Trair�o', 14);
insert tblCIDADE values ('Tucum�', 14);
insert tblCIDADE values ('Tucuru�', 14);
insert tblCIDADE values ('Ulian�polis', 14);
insert tblCIDADE values ('Uruar�', 14);
insert tblCIDADE values ('Vigia', 14);
insert tblCIDADE values ('Viseu', 14);
insert tblCIDADE values ('Vit�ria do Xingu', 14);
insert tblCIDADE values ('Xinguara', 14);
insert tblCIDADE values ('�gua Branca', 15);
insert tblCIDADE values ('Aguiar', 15);
insert tblCIDADE values ('Alagoa Grande', 15);
insert tblCIDADE values ('Alagoa Nova', 15);
insert tblCIDADE values ('Alagoinha', 15);
insert tblCIDADE values ('Alcantil', 15);
insert tblCIDADE values ('Algod�o de Janda�ra', 15);
insert tblCIDADE values ('Alhandra', 15);
insert tblCIDADE values ('S�o Jo�o do Rio do Peixe', 15);
insert tblCIDADE values ('Amparo', 15);
insert tblCIDADE values ('Aparecida', 15);
insert tblCIDADE values ('Ara�agi', 15);
insert tblCIDADE values ('Arara', 15);
insert tblCIDADE values ('Araruna', 15);
insert tblCIDADE values ('Areia', 15);
insert tblCIDADE values ('Areia de Bara�nas', 15);
insert tblCIDADE values ('Areial', 15);
insert tblCIDADE values ('Aroeiras', 15);
insert tblCIDADE values ('Assun��o', 15);
insert tblCIDADE values ('Ba�a da Trai��o', 15);
insert tblCIDADE values ('Bananeiras', 15);
insert tblCIDADE values ('Bara�na', 15);
insert tblCIDADE values ('Barra de Santana', 15);
insert tblCIDADE values ('Barra de Santa Rosa', 15);
insert tblCIDADE values ('Barra de S�o Miguel', 15);
insert tblCIDADE values ('Bayeux', 15);
insert tblCIDADE values ('Bel�m', 15);
insert tblCIDADE values ('Bel�m do Brejo do Cruz', 15);
insert tblCIDADE values ('Bernardino Batista', 15);
insert tblCIDADE values ('Boa Ventura', 15);
insert tblCIDADE values ('Boa Vista', 15);
insert tblCIDADE values ('Bom Jesus', 15);
insert tblCIDADE values ('Bom Sucesso', 15);
insert tblCIDADE values ('Bonito de Santa F�', 15);
insert tblCIDADE values ('Boqueir�o', 15);
insert tblCIDADE values ('Igaracy', 15);
insert tblCIDADE values ('Borborema', 15);
insert tblCIDADE values ('Brejo do Cruz', 15);
insert tblCIDADE values ('Brejo dos Santos', 15);
insert tblCIDADE values ('Caapor�', 15);
insert tblCIDADE values ('Cabaceiras', 15);
insert tblCIDADE values ('Cabedelo', 15);
insert tblCIDADE values ('Cachoeira dos �ndios', 15);
insert tblCIDADE values ('Cacimba de Areia', 15);
insert tblCIDADE values ('Cacimba de Dentro', 15);
insert tblCIDADE values ('Cacimbas', 15);
insert tblCIDADE values ('Cai�ara', 15);
insert tblCIDADE values ('Cajazeiras', 15);
insert tblCIDADE values ('Cajazeirinhas', 15);
insert tblCIDADE values ('Caldas Brand�o', 15);
insert tblCIDADE values ('Camala�', 15);
insert tblCIDADE values ('Campina Grande', 15);
insert tblCIDADE values ('Capim', 15);
insert tblCIDADE values ('Cara�bas', 15);
insert tblCIDADE values ('Carrapateira', 15);
insert tblCIDADE values ('Casserengue', 15);
insert tblCIDADE values ('Catingueira', 15);
insert tblCIDADE values ('Catol� do Rocha', 15);
insert tblCIDADE values ('Caturit�', 15);
insert tblCIDADE values ('Concei��o', 15);
insert tblCIDADE values ('Condado', 15);
insert tblCIDADE values ('Conde', 15);
insert tblCIDADE values ('Congo', 15);
insert tblCIDADE values ('Coremas', 15);
insert tblCIDADE values ('Coxixola', 15);
insert tblCIDADE values ('Cruz do Esp�rito Santo', 15);
insert tblCIDADE values ('Cubati', 15);
insert tblCIDADE values ('Cuit�', 15);
insert tblCIDADE values ('Cuitegi', 15);
insert tblCIDADE values ('Cuit� de Mamanguape', 15);
insert tblCIDADE values ('Curral de Cima', 15);
insert tblCIDADE values ('Curral Velho', 15);
insert tblCIDADE values ('Dami�o', 15);
insert tblCIDADE values ('Desterro', 15);
insert tblCIDADE values ('Vista Serrana', 15);
insert tblCIDADE values ('Diamante', 15);
insert tblCIDADE values ('Dona In�s', 15);
insert tblCIDADE values ('Duas Estradas', 15);
insert tblCIDADE values ('Emas', 15);
insert tblCIDADE values ('Esperan�a', 15);
insert tblCIDADE values ('Fagundes', 15);
insert tblCIDADE values ('Frei Martinho', 15);
insert tblCIDADE values ('Gado Bravo', 15);
insert tblCIDADE values ('Guarabira', 15);
insert tblCIDADE values ('Gurinh�m', 15);
insert tblCIDADE values ('Gurj�o', 15);
insert tblCIDADE values ('Ibiara', 15);
insert tblCIDADE values ('Imaculada', 15);
insert tblCIDADE values ('Ing�', 15);
insert tblCIDADE values ('Itabaiana', 15);
insert tblCIDADE values ('Itaporanga', 15);
insert tblCIDADE values ('Itapororoca', 15);
insert tblCIDADE values ('Itatuba', 15);
insert tblCIDADE values ('Jacara�', 15);
insert tblCIDADE values ('Jeric�', 15);
insert tblCIDADE values ('Jo�o Pessoa', 15);
insert tblCIDADE values ('Juarez T�vora', 15);
insert tblCIDADE values ('Juazeirinho', 15);
insert tblCIDADE values ('Junco do Serid�', 15);
insert tblCIDADE values ('Juripiranga', 15);
insert tblCIDADE values ('Juru', 15);
insert tblCIDADE values ('Lagoa', 15);
insert tblCIDADE values ('Lagoa de Dentro', 15);
insert tblCIDADE values ('Lagoa Seca', 15);
insert tblCIDADE values ('Lastro', 15);
insert tblCIDADE values ('Livramento', 15);
insert tblCIDADE values ('Logradouro', 15);
insert tblCIDADE values ('Lucena', 15);
insert tblCIDADE values ('M�e d''�gua', 15);
insert tblCIDADE values ('Malta', 15);
insert tblCIDADE values ('Mamanguape', 15);
insert tblCIDADE values ('Mana�ra', 15);
insert tblCIDADE values ('Marca��o', 15);
insert tblCIDADE values ('Mari', 15);
insert tblCIDADE values ('Mariz�polis', 15);
insert tblCIDADE values ('Massaranduba', 15);
insert tblCIDADE values ('Mataraca', 15);
insert tblCIDADE values ('Matinhas', 15);
insert tblCIDADE values ('Mato Grosso', 15);
insert tblCIDADE values ('Matur�ia', 15);
insert tblCIDADE values ('Mogeiro', 15);
insert tblCIDADE values ('Montadas', 15);
insert tblCIDADE values ('Monte Horebe', 15);
insert tblCIDADE values ('Monteiro', 15);
insert tblCIDADE values ('Mulungu', 15);
insert tblCIDADE values ('Natuba', 15);
insert tblCIDADE values ('Nazarezinho', 15);
insert tblCIDADE values ('Nova Floresta', 15);
insert tblCIDADE values ('Nova Olinda', 15);
insert tblCIDADE values ('Nova Palmeira', 15);
insert tblCIDADE values ('Olho d''�gua', 15);
insert tblCIDADE values ('Olivedos', 15);
insert tblCIDADE values ('Ouro Velho', 15);
insert tblCIDADE values ('Parari', 15);
insert tblCIDADE values ('Passagem', 15);
insert tblCIDADE values ('Patos', 15);
insert tblCIDADE values ('Paulista', 15);
insert tblCIDADE values ('Pedra Branca', 15);
insert tblCIDADE values ('Pedra Lavrada', 15);
insert tblCIDADE values ('Pedras de Fogo', 15);
insert tblCIDADE values ('Pianc�', 15);
insert tblCIDADE values ('Picu�', 15);
insert tblCIDADE values ('Pilar', 15);
insert tblCIDADE values ('Pil�es', 15);
insert tblCIDADE values ('Pil�ezinhos', 15);
insert tblCIDADE values ('Pirpirituba', 15);
insert tblCIDADE values ('Pitimbu', 15);
insert tblCIDADE values ('Pocinhos', 15);
insert tblCIDADE values ('Po�o Dantas', 15);
insert tblCIDADE values ('Po�o de Jos� de Moura', 15);
insert tblCIDADE values ('Pombal', 15);
insert tblCIDADE values ('Prata', 15);
insert tblCIDADE values ('Princesa Isabel', 15);
insert tblCIDADE values ('Puxinan�', 15);
insert tblCIDADE values ('Queimadas', 15);
insert tblCIDADE values ('Quixab�', 15);
insert tblCIDADE values ('Rem�gio', 15);
insert tblCIDADE values ('Pedro R�gis', 15);
insert tblCIDADE values ('Riach�o', 15);
insert tblCIDADE values ('Riach�o do Bacamarte', 15);
insert tblCIDADE values ('Riach�o do Po�o', 15);
insert tblCIDADE values ('Riacho de Santo Ant�nio', 15);
insert tblCIDADE values ('Riacho dos Cavalos', 15);
insert tblCIDADE values ('Rio Tinto', 15);
insert tblCIDADE values ('Salgadinho', 15);
insert tblCIDADE values ('Salgado de S�o F�lix', 15);
insert tblCIDADE values ('Santa Cec�lia', 15);
insert tblCIDADE values ('Santa Cruz', 15);
insert tblCIDADE values ('Santa Helena', 15);
insert tblCIDADE values ('Santa In�s', 15);
insert tblCIDADE values ('Santa Luzia', 15);
insert tblCIDADE values ('Santana de Mangueira', 15);
insert tblCIDADE values ('Santana dos Garrotes', 15);
insert tblCIDADE values ('Joca Claudino', 15);
insert tblCIDADE values ('Santa Rita', 15);
insert tblCIDADE values ('Santa Teresinha', 15);
insert tblCIDADE values ('Santo Andr�', 15);
insert tblCIDADE values ('S�o Bento', 15);
insert tblCIDADE values ('S�o Bentinho', 15);
insert tblCIDADE values ('S�o Domingos do Cariri', 15);
insert tblCIDADE values ('S�o Domingos', 15);
insert tblCIDADE values ('S�o Francisco', 15);
insert tblCIDADE values ('S�o Jo�o do Cariri', 15);
insert tblCIDADE values ('S�o Jo�o do Tigre', 15);
insert tblCIDADE values ('S�o Jos� da Lagoa Tapada', 15);
insert tblCIDADE values ('S�o Jos� de Caiana', 15);
insert tblCIDADE values ('S�o Jos� de Espinharas', 15);
insert tblCIDADE values ('S�o Jos� dos Ramos', 15);
insert tblCIDADE values ('S�o Jos� de Piranhas', 15);
insert tblCIDADE values ('S�o Jos� de Princesa', 15);
insert tblCIDADE values ('S�o Jos� do Bonfim', 15);
insert tblCIDADE values ('S�o Jos� do Brejo do Cruz', 15);
insert tblCIDADE values ('S�o Jos� do Sabugi', 15);
insert tblCIDADE values ('S�o Jos� dos Cordeiros', 15);
insert tblCIDADE values ('S�o Mamede', 15);
insert tblCIDADE values ('S�o Miguel de Taipu', 15);
insert tblCIDADE values ('S�o Sebasti�o de Lagoa de Ro�a', 15);
insert tblCIDADE values ('S�o Sebasti�o do Umbuzeiro', 15);
insert tblCIDADE values ('Sap�', 15);
insert tblCIDADE values ('Serid�', 15);
insert tblCIDADE values ('Serra Branca', 15);
insert tblCIDADE values ('Serra da Raiz', 15);
insert tblCIDADE values ('Serra Grande', 15);
insert tblCIDADE values ('Serra Redonda', 15);
insert tblCIDADE values ('Serraria', 15);
insert tblCIDADE values ('Sert�ozinho', 15);
insert tblCIDADE values ('Sobrado', 15);
insert tblCIDADE values ('Sol�nea', 15);
insert tblCIDADE values ('Soledade', 15);
insert tblCIDADE values ('Soss�go', 15);
insert tblCIDADE values ('Sousa', 15);
insert tblCIDADE values ('Sum�', 15);
insert tblCIDADE values ('Tacima', 15);
insert tblCIDADE values ('Tapero�', 15);
insert tblCIDADE values ('Tavares', 15);
insert tblCIDADE values ('Teixeira', 15);
insert tblCIDADE values ('Ten�rio', 15);
insert tblCIDADE values ('Triunfo', 15);
insert tblCIDADE values ('Uira�na', 15);
insert tblCIDADE values ('Umbuzeiro', 15);
insert tblCIDADE values ('V�rzea', 15);
insert tblCIDADE values ('Vieir�polis', 15);
insert tblCIDADE values ('Zabel�', 15);
insert tblCIDADE values ('Abati�', 16);
insert tblCIDADE values ('Adrian�polis', 16);
insert tblCIDADE values ('Agudos do Sul', 16);
insert tblCIDADE values ('Almirante Tamandar�', 16);
insert tblCIDADE values ('Altamira do Paran�', 16);
insert tblCIDADE values ('Alt�nia', 16);
insert tblCIDADE values ('Alto Paran�', 16);
insert tblCIDADE values ('Alto Piquiri', 16);
insert tblCIDADE values ('Alvorada do Sul', 16);
insert tblCIDADE values ('Amapor�', 16);
insert tblCIDADE values ('Amp�re', 16);
insert tblCIDADE values ('Anahy', 16);
insert tblCIDADE values ('Andir�', 16);
insert tblCIDADE values ('�ngulo', 16);
insert tblCIDADE values ('Antonina', 16);
insert tblCIDADE values ('Ant�nio Olinto', 16);
insert tblCIDADE values ('Apucarana', 16);
insert tblCIDADE values ('Arapongas', 16);
insert tblCIDADE values ('Arapoti', 16);
insert tblCIDADE values ('Arapu�', 16);
insert tblCIDADE values ('Araruna', 16);
insert tblCIDADE values ('Arauc�ria', 16);
insert tblCIDADE values ('Ariranha do Iva�', 16);
insert tblCIDADE values ('Assa�', 16);
insert tblCIDADE values ('Assis Chateaubriand', 16);
insert tblCIDADE values ('Astorga', 16);
insert tblCIDADE values ('Atalaia', 16);
insert tblCIDADE values ('Balsa Nova', 16);
insert tblCIDADE values ('Bandeirantes', 16);
insert tblCIDADE values ('Barbosa Ferraz', 16);
insert tblCIDADE values ('Barrac�o', 16);
insert tblCIDADE values ('Barra do Jacar�', 16);
insert tblCIDADE values ('Bela Vista da Caroba', 16);
insert tblCIDADE values ('Bela Vista do Para�so', 16);
insert tblCIDADE values ('Bituruna', 16);
insert tblCIDADE values ('Boa Esperan�a', 16);
insert tblCIDADE values ('Boa Esperan�a do Igua�u', 16);
insert tblCIDADE values ('Boa Ventura de S�o Roque', 16);
insert tblCIDADE values ('Boa Vista da Aparecida', 16);
insert tblCIDADE values ('Bocai�va do Sul', 16);
insert tblCIDADE values ('Bom Jesus do Sul', 16);
insert tblCIDADE values ('Bom Sucesso', 16);
insert tblCIDADE values ('Bom Sucesso do Sul', 16);
insert tblCIDADE values ('Borraz�polis', 16);
insert tblCIDADE values ('Braganey', 16);
insert tblCIDADE values ('Brasil�ndia do Sul', 16);
insert tblCIDADE values ('Cafeara', 16);
insert tblCIDADE values ('Cafel�ndia', 16);
insert tblCIDADE values ('Cafezal do Sul', 16);
insert tblCIDADE values ('Calif�rnia', 16);
insert tblCIDADE values ('Cambar�', 16);
insert tblCIDADE values ('Camb�', 16);
insert tblCIDADE values ('Cambira', 16);
insert tblCIDADE values ('Campina da Lagoa', 16);
insert tblCIDADE values ('Campina do Sim�o', 16);
insert tblCIDADE values ('Campina Grande do Sul', 16);
insert tblCIDADE values ('Campo Bonito', 16);
insert tblCIDADE values ('Campo do Tenente', 16);
insert tblCIDADE values ('Campo Largo', 16);
insert tblCIDADE values ('Campo Magro', 16);
insert tblCIDADE values ('Campo Mour�o', 16);
insert tblCIDADE values ('C�ndido de Abreu', 16);
insert tblCIDADE values ('Cand�i', 16);
insert tblCIDADE values ('Cantagalo', 16);
insert tblCIDADE values ('Capanema', 16);
insert tblCIDADE values ('Capit�o Le�nidas Marques', 16);
insert tblCIDADE values ('Carambe�', 16);
insert tblCIDADE values ('Carl�polis', 16);
insert tblCIDADE values ('Cascavel', 16);
insert tblCIDADE values ('Castro', 16);
insert tblCIDADE values ('Catanduvas', 16);
insert tblCIDADE values ('Centen�rio do Sul', 16);
insert tblCIDADE values ('Cerro Azul', 16);
insert tblCIDADE values ('C�u Azul', 16);
insert tblCIDADE values ('Chopinzinho', 16);
insert tblCIDADE values ('Cianorte', 16);
insert tblCIDADE values ('Cidade Ga�cha', 16);
insert tblCIDADE values ('Clevel�ndia', 16);
insert tblCIDADE values ('Colombo', 16);
insert tblCIDADE values ('Colorado', 16);
insert tblCIDADE values ('Congonhinhas', 16);
insert tblCIDADE values ('Conselheiro Mairinck', 16);
insert tblCIDADE values ('Contenda', 16);
insert tblCIDADE values ('Corb�lia', 16);
insert tblCIDADE values ('Corn�lio Proc�pio', 16);
insert tblCIDADE values ('Coronel Domingos Soares', 16);
insert tblCIDADE values ('Coronel Vivida', 16);
insert tblCIDADE values ('Corumbata� do Sul', 16);
insert tblCIDADE values ('Cruzeiro do Igua�u', 16);
insert tblCIDADE values ('Cruzeiro do Oeste', 16);
insert tblCIDADE values ('Cruzeiro do Sul', 16);
insert tblCIDADE values ('Cruz Machado', 16);
insert tblCIDADE values ('Cruzmaltina', 16);
insert tblCIDADE values ('Curitiba', 16);
insert tblCIDADE values ('Curi�va', 16);
insert tblCIDADE values ('Diamante do Norte', 16);
insert tblCIDADE values ('Diamante do Sul', 16);
insert tblCIDADE values ('Diamante D''Oeste', 16);
insert tblCIDADE values ('Dois Vizinhos', 16);
insert tblCIDADE values ('Douradina', 16);
insert tblCIDADE values ('Doutor Camargo', 16);
insert tblCIDADE values ('En�as Marques', 16);
insert tblCIDADE values ('Engenheiro Beltr�o', 16);
insert tblCIDADE values ('Esperan�a Nova', 16);
insert tblCIDADE values ('Entre Rios do Oeste', 16);
insert tblCIDADE values ('Espig�o Alto do Igua�u', 16);
insert tblCIDADE values ('Farol', 16);
insert tblCIDADE values ('Faxinal', 16);
insert tblCIDADE values ('Fazenda Rio Grande', 16);
insert tblCIDADE values ('F�nix', 16);
insert tblCIDADE values ('Fernandes Pinheiro', 16);
insert tblCIDADE values ('Figueira', 16);
insert tblCIDADE values ('Flora�', 16);
insert tblCIDADE values ('Flor da Serra do Sul', 16);
insert tblCIDADE values ('Floresta', 16);
insert tblCIDADE values ('Florest�polis', 16);
insert tblCIDADE values ('Fl�rida', 16);
insert tblCIDADE values ('Formosa do Oeste', 16);
insert tblCIDADE values ('Foz do Igua�u', 16);
insert tblCIDADE values ('Francisco Alves', 16);
insert tblCIDADE values ('Francisco Beltr�o', 16);
insert tblCIDADE values ('Foz do Jord�o', 16);
insert tblCIDADE values ('General Carneiro', 16);
insert tblCIDADE values ('Godoy Moreira', 16);
insert tblCIDADE values ('Goioer�', 16);
insert tblCIDADE values ('Goioxim', 16);
insert tblCIDADE values ('Grandes Rios', 16);
insert tblCIDADE values ('Gua�ra', 16);
insert tblCIDADE values ('Guaira��', 16);
insert tblCIDADE values ('Guamiranga', 16);
insert tblCIDADE values ('Guapirama', 16);
insert tblCIDADE values ('Guaporema', 16);
insert tblCIDADE values ('Guaraci', 16);
insert tblCIDADE values ('Guarania�u', 16);
insert tblCIDADE values ('Guarapuava', 16);
insert tblCIDADE values ('Guaraque�aba', 16);
insert tblCIDADE values ('Guaratuba', 16);
insert tblCIDADE values ('Hon�rio Serpa', 16);
insert tblCIDADE values ('Ibaiti', 16);
insert tblCIDADE values ('Ibema', 16);
insert tblCIDADE values ('Ibipor�', 16);
insert tblCIDADE values ('Icara�ma', 16);
insert tblCIDADE values ('Iguara�u', 16);
insert tblCIDADE values ('Iguatu', 16);
insert tblCIDADE values ('Imba�', 16);
insert tblCIDADE values ('Imbituva', 16);
insert tblCIDADE values ('In�cio Martins', 16);
insert tblCIDADE values ('Inaj�', 16);
insert tblCIDADE values ('Indian�polis', 16);
insert tblCIDADE values ('Ipiranga', 16);
insert tblCIDADE values ('Ipor�', 16);
insert tblCIDADE values ('Iracema do Oeste', 16);
insert tblCIDADE values ('Irati', 16);
insert tblCIDADE values ('Iretama', 16);
insert tblCIDADE values ('Itaguaj�', 16);
insert tblCIDADE values ('Itaipul�ndia', 16);
insert tblCIDADE values ('Itambarac�', 16);
insert tblCIDADE values ('Itamb�', 16);
insert tblCIDADE values ('Itapejara d''Oeste', 16);
insert tblCIDADE values ('Itaperu�u', 16);
insert tblCIDADE values ('Ita�na do Sul', 16);
insert tblCIDADE values ('Iva�', 16);
insert tblCIDADE values ('Ivaipor�', 16);
insert tblCIDADE values ('Ivat�', 16);
insert tblCIDADE values ('Ivatuba', 16);
insert tblCIDADE values ('Jaboti', 16);
insert tblCIDADE values ('Jacarezinho', 16);
insert tblCIDADE values ('Jaguapit�', 16);
insert tblCIDADE values ('Jaguaria�va', 16);
insert tblCIDADE values ('Jandaia do Sul', 16);
insert tblCIDADE values ('Jani�polis', 16);
insert tblCIDADE values ('Japira', 16);
insert tblCIDADE values ('Japur�', 16);
insert tblCIDADE values ('Jardim Alegre', 16);
insert tblCIDADE values ('Jardim Olinda', 16);
insert tblCIDADE values ('Jataizinho', 16);
insert tblCIDADE values ('Jesu�tas', 16);
insert tblCIDADE values ('Joaquim T�vora', 16);
insert tblCIDADE values ('Jundia� do Sul', 16);
insert tblCIDADE values ('Juranda', 16);
insert tblCIDADE values ('Jussara', 16);
insert tblCIDADE values ('Kalor�', 16);
insert tblCIDADE values ('Lapa', 16);
insert tblCIDADE values ('Laranjal', 16);
insert tblCIDADE values ('Laranjeiras do Sul', 16);
insert tblCIDADE values ('Le�polis', 16);
insert tblCIDADE values ('Lidian�polis', 16);
insert tblCIDADE values ('Lindoeste', 16);
insert tblCIDADE values ('Loanda', 16);
insert tblCIDADE values ('Lobato', 16);
insert tblCIDADE values ('Londrina', 16);
insert tblCIDADE values ('Luiziana', 16);
insert tblCIDADE values ('Lunardelli', 16);
insert tblCIDADE values ('Lupion�polis', 16);
insert tblCIDADE values ('Mallet', 16);
insert tblCIDADE values ('Mambor�', 16);
insert tblCIDADE values ('Mandagua�u', 16);
insert tblCIDADE values ('Mandaguari', 16);
insert tblCIDADE values ('Mandirituba', 16);
insert tblCIDADE values ('Manfrin�polis', 16);
insert tblCIDADE values ('Mangueirinha', 16);
insert tblCIDADE values ('Manoel Ribas', 16);
insert tblCIDADE values ('Marechal C�ndido Rondon', 16);
insert tblCIDADE values ('Maria Helena', 16);
insert tblCIDADE values ('Marialva', 16);
insert tblCIDADE values ('Maril�ndia do Sul', 16);
insert tblCIDADE values ('Marilena', 16);
insert tblCIDADE values ('Mariluz', 16);
insert tblCIDADE values ('Maring�', 16);
insert tblCIDADE values ('Mari�polis', 16);
insert tblCIDADE values ('Marip�', 16);
insert tblCIDADE values ('Marmeleiro', 16);
insert tblCIDADE values ('Marquinho', 16);
insert tblCIDADE values ('Marumbi', 16);
insert tblCIDADE values ('Matel�ndia', 16);
insert tblCIDADE values ('Matinhos', 16);
insert tblCIDADE values ('Mato Rico', 16);
insert tblCIDADE values ('Mau� da Serra', 16);
insert tblCIDADE values ('Medianeira', 16);
insert tblCIDADE values ('Mercedes', 16);
insert tblCIDADE values ('Mirador', 16);
insert tblCIDADE values ('Miraselva', 16);
insert tblCIDADE values ('Missal', 16);
insert tblCIDADE values ('Moreira Sales', 16);
insert tblCIDADE values ('Morretes', 16);
insert tblCIDADE values ('Munhoz de Melo', 16);
insert tblCIDADE values ('Nossa Senhora das Gra�as', 16);
insert tblCIDADE values ('Nova Alian�a do Iva�', 16);
insert tblCIDADE values ('Nova Am�rica da Colina', 16);
insert tblCIDADE values ('Nova Aurora', 16);
insert tblCIDADE values ('Nova Cantu', 16);
insert tblCIDADE values ('Nova Esperan�a', 16);
insert tblCIDADE values ('Nova Esperan�a do Sudoeste', 16);
insert tblCIDADE values ('Nova F�tima', 16);
insert tblCIDADE values ('Nova Laranjeiras', 16);
insert tblCIDADE values ('Nova Londrina', 16);
insert tblCIDADE values ('Nova Ol�mpia', 16);
insert tblCIDADE values ('Nova Santa B�rbara', 16);
insert tblCIDADE values ('Nova Santa Rosa', 16);
insert tblCIDADE values ('Nova Prata do Igua�u', 16);
insert tblCIDADE values ('Nova Tebas', 16);
insert tblCIDADE values ('Novo Itacolomi', 16);
insert tblCIDADE values ('Ortigueira', 16);
insert tblCIDADE values ('Ourizona', 16);
insert tblCIDADE values ('Ouro Verde do Oeste', 16);
insert tblCIDADE values ('Pai�andu', 16);
insert tblCIDADE values ('Palmas', 16);
insert tblCIDADE values ('Palmeira', 16);
insert tblCIDADE values ('Palmital', 16);
insert tblCIDADE values ('Palotina', 16);
insert tblCIDADE values ('Para�so do Norte', 16);
insert tblCIDADE values ('Paranacity', 16);
insert tblCIDADE values ('Paranagu�', 16);
insert tblCIDADE values ('Paranapoema', 16);
insert tblCIDADE values ('Paranava�', 16);
insert tblCIDADE values ('Pato Bragado', 16);
insert tblCIDADE values ('Pato Branco', 16);
insert tblCIDADE values ('Paula Freitas', 16);
insert tblCIDADE values ('Paulo Frontin', 16);
insert tblCIDADE values ('Peabiru', 16);
insert tblCIDADE values ('Perobal', 16);
insert tblCIDADE values ('P�rola', 16);
insert tblCIDADE values ('P�rola d''Oeste', 16);
insert tblCIDADE values ('Pi�n', 16);
insert tblCIDADE values ('Pinhais', 16);
insert tblCIDADE values ('Pinhal�o', 16);
insert tblCIDADE values ('Pinhal de S�o Bento', 16);
insert tblCIDADE values ('Pinh�o', 16);
insert tblCIDADE values ('Pira� do Sul', 16);
insert tblCIDADE values ('Piraquara', 16);
insert tblCIDADE values ('Pitanga', 16);
insert tblCIDADE values ('Pitangueiras', 16);
insert tblCIDADE values ('Planaltina do Paran�', 16);
insert tblCIDADE values ('Planalto', 16);
insert tblCIDADE values ('Ponta Grossa', 16);
insert tblCIDADE values ('Pontal do Paran�', 16);
insert tblCIDADE values ('Porecatu', 16);
insert tblCIDADE values ('Porto Amazonas', 16);
insert tblCIDADE values ('Porto Barreiro', 16);
insert tblCIDADE values ('Porto Rico', 16);
insert tblCIDADE values ('Porto Vit�ria', 16);
insert tblCIDADE values ('Prado Ferreira', 16);
insert tblCIDADE values ('Pranchita', 16);
insert tblCIDADE values ('Presidente Castelo Branco', 16);
insert tblCIDADE values ('Primeiro de Maio', 16);
insert tblCIDADE values ('Prudent�polis', 16);
insert tblCIDADE values ('Quarto Centen�rio', 16);
insert tblCIDADE values ('Quatigu�', 16);
insert tblCIDADE values ('Quatro Barras', 16);
insert tblCIDADE values ('Quatro Pontes', 16);
insert tblCIDADE values ('Quedas do Igua�u', 16);
insert tblCIDADE values ('Quer�ncia do Norte', 16);
insert tblCIDADE values ('Quinta do Sol', 16);
insert tblCIDADE values ('Quitandinha', 16);
insert tblCIDADE values ('Ramil�ndia', 16);
insert tblCIDADE values ('Rancho Alegre', 16);
insert tblCIDADE values ('Rancho Alegre D''Oeste', 16);
insert tblCIDADE values ('Realeza', 16);
insert tblCIDADE values ('Rebou�as', 16);
insert tblCIDADE values ('Renascen�a', 16);
insert tblCIDADE values ('Reserva', 16);
insert tblCIDADE values ('Reserva do Igua�u', 16);
insert tblCIDADE values ('Ribeir�o Claro', 16);
insert tblCIDADE values ('Ribeir�o do Pinhal', 16);
insert tblCIDADE values ('Rio Azul', 16);
insert tblCIDADE values ('Rio Bom', 16);
insert tblCIDADE values ('Rio Bonito do Igua�u', 16);
insert tblCIDADE values ('Rio Branco do Iva�', 16);
insert tblCIDADE values ('Rio Branco do Sul', 16);
insert tblCIDADE values ('Rio Negro', 16);
insert tblCIDADE values ('Rol�ndia', 16);
insert tblCIDADE values ('Roncador', 16);
insert tblCIDADE values ('Rondon', 16);
insert tblCIDADE values ('Ros�rio do Iva�', 16);
insert tblCIDADE values ('Sab�udia', 16);
insert tblCIDADE values ('Salgado Filho', 16);
insert tblCIDADE values ('Salto do Itarar�', 16);
insert tblCIDADE values ('Salto do Lontra', 16);
insert tblCIDADE values ('Santa Am�lia', 16);
insert tblCIDADE values ('Santa Cec�lia do Pav�o', 16);
insert tblCIDADE values ('Santa Cruz de Monte Castelo', 16);
insert tblCIDADE values ('Santa F�', 16);
insert tblCIDADE values ('Santa Helena', 16);
insert tblCIDADE values ('Santa In�s', 16);
insert tblCIDADE values ('Santa Isabel do Iva�', 16);
insert tblCIDADE values ('Santa Izabel do Oeste', 16);
insert tblCIDADE values ('Santa L�cia', 16);
insert tblCIDADE values ('Santa Maria do Oeste', 16);
insert tblCIDADE values ('Santa Mariana', 16);
insert tblCIDADE values ('Santa M�nica', 16);
insert tblCIDADE values ('Santana do Itarar�', 16);
insert tblCIDADE values ('Santa Tereza do Oeste', 16);
insert tblCIDADE values ('Santa Terezinha de Itaipu', 16);
insert tblCIDADE values ('Santo Ant�nio da Platina', 16);
insert tblCIDADE values ('Santo Ant�nio do Caiu�', 16);
insert tblCIDADE values ('Santo Ant�nio do Para�so', 16);
insert tblCIDADE values ('Santo Ant�nio do Sudoeste', 16);
insert tblCIDADE values ('Santo In�cio', 16);
insert tblCIDADE values ('S�o Carlos do Iva�', 16);
insert tblCIDADE values ('S�o Jer�nimo da Serra', 16);
insert tblCIDADE values ('S�o Jo�o', 16);
insert tblCIDADE values ('S�o Jo�o do Caiu�', 16);
insert tblCIDADE values ('S�o Jo�o do Iva�', 16);
insert tblCIDADE values ('S�o Jo�o do Triunfo', 16);
insert tblCIDADE values ('S�o Jorge d''Oeste', 16);
insert tblCIDADE values ('S�o Jorge do Iva�', 16);
insert tblCIDADE values ('S�o Jorge do Patroc�nio', 16);
insert tblCIDADE values ('S�o Jos� da Boa Vista', 16);
insert tblCIDADE values ('S�o Jos� das Palmeiras', 16);
insert tblCIDADE values ('S�o Jos� dos Pinhais', 16);
insert tblCIDADE values ('S�o Manoel do Paran�', 16);
insert tblCIDADE values ('S�o Mateus do Sul', 16);
insert tblCIDADE values ('S�o Miguel do Igua�u', 16);
insert tblCIDADE values ('S�o Pedro do Igua�u', 16);
insert tblCIDADE values ('S�o Pedro do Iva�', 16);
insert tblCIDADE values ('S�o Pedro do Paran�', 16);
insert tblCIDADE values ('S�o Sebasti�o da Amoreira', 16);
insert tblCIDADE values ('S�o Tom�', 16);
insert tblCIDADE values ('Sapopema', 16);
insert tblCIDADE values ('Sarandi', 16);
insert tblCIDADE values ('Saudade do Igua�u', 16);
insert tblCIDADE values ('Seng�s', 16);
insert tblCIDADE values ('Serran�polis do Igua�u', 16);
insert tblCIDADE values ('Sertaneja', 16);
insert tblCIDADE values ('Sertan�polis', 16);
insert tblCIDADE values ('Siqueira Campos', 16);
insert tblCIDADE values ('Sulina', 16);
insert tblCIDADE values ('Tamarana', 16);
insert tblCIDADE values ('Tamboara', 16);
insert tblCIDADE values ('Tapejara', 16);
insert tblCIDADE values ('Tapira', 16);
insert tblCIDADE values ('Teixeira Soares', 16);
insert tblCIDADE values ('Tel�maco Borba', 16);
insert tblCIDADE values ('Terra Boa', 16);
insert tblCIDADE values ('Terra Rica', 16);
insert tblCIDADE values ('Terra Roxa', 16);
insert tblCIDADE values ('Tibagi', 16);
insert tblCIDADE values ('Tijucas do Sul', 16);
insert tblCIDADE values ('Toledo', 16);
insert tblCIDADE values ('Tomazina', 16);
insert tblCIDADE values ('Tr�s Barras do Paran�', 16);
insert tblCIDADE values ('Tunas do Paran�', 16);
insert tblCIDADE values ('Tuneiras do Oeste', 16);
insert tblCIDADE values ('Tup�ssi', 16);
insert tblCIDADE values ('Turvo', 16);
insert tblCIDADE values ('Ubirat�', 16);
insert tblCIDADE values ('Umuarama', 16);
insert tblCIDADE values ('Uni�o da Vit�ria', 16);
insert tblCIDADE values ('Uniflor', 16);
insert tblCIDADE values ('Ura�', 16);
insert tblCIDADE values ('Wenceslau Braz', 16);
insert tblCIDADE values ('Ventania', 16);
insert tblCIDADE values ('Vera Cruz do Oeste', 16);
insert tblCIDADE values ('Ver�', 16);
insert tblCIDADE values ('Alto Para�so', 16);
insert tblCIDADE values ('Doutor Ulysses', 16);
insert tblCIDADE values ('Virmond', 16);
insert tblCIDADE values ('Vitorino', 16);
insert tblCIDADE values ('Xambr�', 16);
insert tblCIDADE values ('Abreu e Lima', 17);
insert tblCIDADE values ('Afogados da Ingazeira', 17);
insert tblCIDADE values ('Afr�nio', 17);
insert tblCIDADE values ('Agrestina', 17);
insert tblCIDADE values ('�gua Preta', 17);
insert tblCIDADE values ('�guas Belas', 17);
insert tblCIDADE values ('Alagoinha', 17);
insert tblCIDADE values ('Alian�a', 17);
insert tblCIDADE values ('Altinho', 17);
insert tblCIDADE values ('Amaraji', 17);
insert tblCIDADE values ('Angelim', 17);
insert tblCIDADE values ('Ara�oiaba', 17);
insert tblCIDADE values ('Araripina', 17);
insert tblCIDADE values ('Arcoverde', 17);
insert tblCIDADE values ('Barra de Guabiraba', 17);
insert tblCIDADE values ('Barreiros', 17);
insert tblCIDADE values ('Bel�m de Maria', 17);
insert tblCIDADE values ('Bel�m do S�o Francisco', 17);
insert tblCIDADE values ('Belo Jardim', 17);
insert tblCIDADE values ('Bet�nia', 17);
insert tblCIDADE values ('Bezerros', 17);
insert tblCIDADE values ('Bodoc�', 17);
insert tblCIDADE values ('Bom Conselho', 17);
insert tblCIDADE values ('Bom Jardim', 17);
insert tblCIDADE values ('Bonito', 17);
insert tblCIDADE values ('Brej�o', 17);
insert tblCIDADE values ('Brejinho', 17);
insert tblCIDADE values ('Brejo da Madre de Deus', 17);
insert tblCIDADE values ('Buenos Aires', 17);
insert tblCIDADE values ('Bu�que', 17);
insert tblCIDADE values ('Cabo de Santo Agostinho', 17);
insert tblCIDADE values ('Cabrob�', 17);
insert tblCIDADE values ('Cachoeirinha', 17);
insert tblCIDADE values ('Caet�s', 17);
insert tblCIDADE values ('Cal�ado', 17);
insert tblCIDADE values ('Calumbi', 17);
insert tblCIDADE values ('Camaragibe', 17);
insert tblCIDADE values ('Camocim de S�o F�lix', 17);
insert tblCIDADE values ('Camutanga', 17);
insert tblCIDADE values ('Canhotinho', 17);
insert tblCIDADE values ('Capoeiras', 17);
insert tblCIDADE values ('Carna�ba', 17);
insert tblCIDADE values ('Carnaubeira da Penha', 17);
insert tblCIDADE values ('Carpina', 17);
insert tblCIDADE values ('Caruaru', 17);
insert tblCIDADE values ('Casinhas', 17);
insert tblCIDADE values ('Catende', 17);
insert tblCIDADE values ('Cedro', 17);
insert tblCIDADE values ('Ch� de Alegria', 17);
insert tblCIDADE values ('Ch� Grande', 17);
insert tblCIDADE values ('Condado', 17);
insert tblCIDADE values ('Correntes', 17);
insert tblCIDADE values ('Cort�s', 17);
insert tblCIDADE values ('Cumaru', 17);
insert tblCIDADE values ('Cupira', 17);
insert tblCIDADE values ('Cust�dia', 17);
insert tblCIDADE values ('Dormentes', 17);
insert tblCIDADE values ('Escada', 17);
insert tblCIDADE values ('Exu', 17);
insert tblCIDADE values ('Feira Nova', 17);
insert tblCIDADE values ('Fernando de Noronha', 17);
insert tblCIDADE values ('Ferreiros', 17);
insert tblCIDADE values ('Flores', 17);
insert tblCIDADE values ('Floresta', 17);
insert tblCIDADE values ('Frei Miguelinho', 17);
insert tblCIDADE values ('Gameleira', 17);
insert tblCIDADE values ('Garanhuns', 17);
insert tblCIDADE values ('Gl�ria do Goit�', 17);
insert tblCIDADE values ('Goiana', 17);
insert tblCIDADE values ('Granito', 17);
insert tblCIDADE values ('Gravat�', 17);
insert tblCIDADE values ('Iati', 17);
insert tblCIDADE values ('Ibimirim', 17);
insert tblCIDADE values ('Ibirajuba', 17);
insert tblCIDADE values ('Igarassu', 17);
insert tblCIDADE values ('Iguaraci', 17);
insert tblCIDADE values ('Inaj�', 17);
insert tblCIDADE values ('Ingazeira', 17);
insert tblCIDADE values ('Ipojuca', 17);
insert tblCIDADE values ('Ipubi', 17);
insert tblCIDADE values ('Itacuruba', 17);
insert tblCIDADE values ('Ita�ba', 17);
insert tblCIDADE values ('Ilha de Itamarac�', 17);
insert tblCIDADE values ('Itamb�', 17);
insert tblCIDADE values ('Itapetim', 17);
insert tblCIDADE values ('Itapissuma', 17);
insert tblCIDADE values ('Itaquitinga', 17);
insert tblCIDADE values ('Jaboat�o dos Guararapes', 17);
insert tblCIDADE values ('Jaqueira', 17);
insert tblCIDADE values ('Jata�ba', 17);
insert tblCIDADE values ('Jatob�', 17);
insert tblCIDADE values ('Jo�o Alfredo', 17);
insert tblCIDADE values ('Joaquim Nabuco', 17);
insert tblCIDADE values ('Jucati', 17);
insert tblCIDADE values ('Jupi', 17);
insert tblCIDADE values ('Jurema', 17);
insert tblCIDADE values ('Lagoa do Carro', 17);
insert tblCIDADE values ('Lagoa de Itaenga', 17);
insert tblCIDADE values ('Lagoa do Ouro', 17);
insert tblCIDADE values ('Lagoa dos Gatos', 17);
insert tblCIDADE values ('Lagoa Grande', 17);
insert tblCIDADE values ('Lajedo', 17);
insert tblCIDADE values ('Limoeiro', 17);
insert tblCIDADE values ('Macaparana', 17);
insert tblCIDADE values ('Machados', 17);
insert tblCIDADE values ('Manari', 17);
insert tblCIDADE values ('Maraial', 17);
insert tblCIDADE values ('Mirandiba', 17);
insert tblCIDADE values ('Moreno', 17);
insert tblCIDADE values ('Nazar� da Mata', 17);
insert tblCIDADE values ('Olinda', 17);
insert tblCIDADE values ('Orob�', 17);
insert tblCIDADE values ('Oroc�', 17);
insert tblCIDADE values ('Ouricuri', 17);
insert tblCIDADE values ('Palmares', 17);
insert tblCIDADE values ('Palmeirina', 17);
insert tblCIDADE values ('Panelas', 17);
insert tblCIDADE values ('Paranatama', 17);
insert tblCIDADE values ('Parnamirim', 17);
insert tblCIDADE values ('Passira', 17);
insert tblCIDADE values ('Paudalho', 17);
insert tblCIDADE values ('Paulista', 17);
insert tblCIDADE values ('Pedra', 17);
insert tblCIDADE values ('Pesqueira', 17);
insert tblCIDADE values ('Petrol�ndia', 17);
insert tblCIDADE values ('Petrolina', 17);
insert tblCIDADE values ('Po��o', 17);
insert tblCIDADE values ('Pombos', 17);
insert tblCIDADE values ('Primavera', 17);
insert tblCIDADE values ('Quipap�', 17);
insert tblCIDADE values ('Quixaba', 17);
insert tblCIDADE values ('Recife', 17);
insert tblCIDADE values ('Riacho das Almas', 17);
insert tblCIDADE values ('Ribeir�o', 17);
insert tblCIDADE values ('Rio Formoso', 17);
insert tblCIDADE values ('Sair�', 17);
insert tblCIDADE values ('Salgadinho', 17);
insert tblCIDADE values ('Salgueiro', 17);
insert tblCIDADE values ('Salo�', 17);
insert tblCIDADE values ('Sanhar�', 17);
insert tblCIDADE values ('Santa Cruz', 17);
insert tblCIDADE values ('Santa Cruz da Baixa Verde', 17);
insert tblCIDADE values ('Santa Cruz do Capibaribe', 17);
insert tblCIDADE values ('Santa Filomena', 17);
insert tblCIDADE values ('Santa Maria da Boa Vista', 17);
insert tblCIDADE values ('Santa Maria do Cambuc�', 17);
insert tblCIDADE values ('Santa Terezinha', 17);
insert tblCIDADE values ('S�o Benedito do Sul', 17);
insert tblCIDADE values ('S�o Bento do Una', 17);
insert tblCIDADE values ('S�o Caitano', 17);
insert tblCIDADE values ('S�o Jo�o', 17);
insert tblCIDADE values ('S�o Joaquim do Monte', 17);
insert tblCIDADE values ('S�o Jos� da Coroa Grande', 17);
insert tblCIDADE values ('S�o Jos� do Belmonte', 17);
insert tblCIDADE values ('S�o Jos� do Egito', 17);
insert tblCIDADE values ('S�o Louren�o da Mata', 17);
insert tblCIDADE values ('S�o Vicente Ferrer', 17);
insert tblCIDADE values ('Serra Talhada', 17);
insert tblCIDADE values ('Serrita', 17);
insert tblCIDADE values ('Sert�nia', 17);
insert tblCIDADE values ('Sirinha�m', 17);
insert tblCIDADE values ('Moreil�ndia', 17);
insert tblCIDADE values ('Solid�o', 17);
insert tblCIDADE values ('Surubim', 17);
insert tblCIDADE values ('Tabira', 17);
insert tblCIDADE values ('Tacaimb�', 17);
insert tblCIDADE values ('Tacaratu', 17);
insert tblCIDADE values ('Tamandar�', 17);
insert tblCIDADE values ('Taquaritinga do Norte', 17);
insert tblCIDADE values ('Terezinha', 17);
insert tblCIDADE values ('Terra Nova', 17);
insert tblCIDADE values ('Timba�ba', 17);
insert tblCIDADE values ('Toritama', 17);
insert tblCIDADE values ('Tracunha�m', 17);
insert tblCIDADE values ('Trindade', 17);
insert tblCIDADE values ('Triunfo', 17);
insert tblCIDADE values ('Tupanatinga', 17);
insert tblCIDADE values ('Tuparetama', 17);
insert tblCIDADE values ('Venturosa', 17);
insert tblCIDADE values ('Verdejante', 17);
insert tblCIDADE values ('Vertente do L�rio', 17);
insert tblCIDADE values ('Vertentes', 17);
insert tblCIDADE values ('Vic�ncia', 17);
insert tblCIDADE values ('Vit�ria de Santo Ant�o', 17);
insert tblCIDADE values ('Xex�u', 17);
insert tblCIDADE values ('Acau�', 18);
insert tblCIDADE values ('Agricol�ndia', 18);
insert tblCIDADE values ('�gua Branca', 18);
insert tblCIDADE values ('Alagoinha do Piau�', 18);
insert tblCIDADE values ('Alegrete do Piau�', 18);
insert tblCIDADE values ('Alto Long�', 18);
insert tblCIDADE values ('Altos', 18);
insert tblCIDADE values ('Alvorada do Gurgu�ia', 18);
insert tblCIDADE values ('Amarante', 18);
insert tblCIDADE values ('Angical do Piau�', 18);
insert tblCIDADE values ('An�sio de Abreu', 18);
insert tblCIDADE values ('Ant�nio Almeida', 18);
insert tblCIDADE values ('Aroazes', 18);
insert tblCIDADE values ('Aroeiras do Itaim', 18);
insert tblCIDADE values ('Arraial', 18);
insert tblCIDADE values ('Assun��o do Piau�', 18);
insert tblCIDADE values ('Avelino Lopes', 18);
insert tblCIDADE values ('Baixa Grande do Ribeiro', 18);
insert tblCIDADE values ('Barra D''Alc�ntara', 18);
insert tblCIDADE values ('Barras', 18);
insert tblCIDADE values ('Barreiras do Piau�', 18);
insert tblCIDADE values ('Barro Duro', 18);
insert tblCIDADE values ('Batalha', 18);
insert tblCIDADE values ('Bela Vista do Piau�', 18);
insert tblCIDADE values ('Bel�m do Piau�', 18);
insert tblCIDADE values ('Beneditinos', 18);
insert tblCIDADE values ('Bertol�nia', 18);
insert tblCIDADE values ('Bet�nia do Piau�', 18);
insert tblCIDADE values ('Boa Hora', 18);
insert tblCIDADE values ('Bocaina', 18);
insert tblCIDADE values ('Bom Jesus', 18);
insert tblCIDADE values ('Bom Princ�pio do Piau�', 18);
insert tblCIDADE values ('Bonfim do Piau�', 18);
insert tblCIDADE values ('Boqueir�o do Piau�', 18);
insert tblCIDADE values ('Brasileira', 18);
insert tblCIDADE values ('Brejo do Piau�', 18);
insert tblCIDADE values ('Buriti dos Lopes', 18);
insert tblCIDADE values ('Buriti dos Montes', 18);
insert tblCIDADE values ('Cabeceiras do Piau�', 18);
insert tblCIDADE values ('Cajazeiras do Piau�', 18);
insert tblCIDADE values ('Cajueiro da Praia', 18);
insert tblCIDADE values ('Caldeir�o Grande do Piau�', 18);
insert tblCIDADE values ('Campinas do Piau�', 18);
insert tblCIDADE values ('Campo Alegre do Fidalgo', 18);
insert tblCIDADE values ('Campo Grande do Piau�', 18);
insert tblCIDADE values ('Campo Largo do Piau�', 18);
insert tblCIDADE values ('Campo Maior', 18);
insert tblCIDADE values ('Canavieira', 18);
insert tblCIDADE values ('Canto do Buriti', 18);
insert tblCIDADE values ('Capit�o de Campos', 18);
insert tblCIDADE values ('Capit�o Gerv�sio Oliveira', 18);
insert tblCIDADE values ('Caracol', 18);
insert tblCIDADE values ('Cara�bas do Piau�', 18);
insert tblCIDADE values ('Caridade do Piau�', 18);
insert tblCIDADE values ('Castelo do Piau�', 18);
insert tblCIDADE values ('Caxing�', 18);
insert tblCIDADE values ('Cocal', 18);
insert tblCIDADE values ('Cocal de Telha', 18);
insert tblCIDADE values ('Cocal dos Alves', 18);
insert tblCIDADE values ('Coivaras', 18);
insert tblCIDADE values ('Col�nia do Gurgu�ia', 18);
insert tblCIDADE values ('Col�nia do Piau�', 18);
insert tblCIDADE values ('Concei��o do Canind�', 18);
insert tblCIDADE values ('Coronel Jos� Dias', 18);
insert tblCIDADE values ('Corrente', 18);
insert tblCIDADE values ('Cristal�ndia do Piau�', 18);
insert tblCIDADE values ('Cristino Castro', 18);
insert tblCIDADE values ('Curimat�', 18);
insert tblCIDADE values ('Currais', 18);
insert tblCIDADE values ('Curralinhos', 18);
insert tblCIDADE values ('Curral Novo do Piau�', 18);
insert tblCIDADE values ('Demerval Lob�o', 18);
insert tblCIDADE values ('Dirceu Arcoverde', 18);
insert tblCIDADE values ('Dom Expedito Lopes', 18);
insert tblCIDADE values ('Domingos Mour�o', 18);
insert tblCIDADE values ('Dom Inoc�ncio', 18);
insert tblCIDADE values ('Elesb�o Veloso', 18);
insert tblCIDADE values ('Eliseu Martins', 18);
insert tblCIDADE values ('Esperantina', 18);
insert tblCIDADE values ('Fartura do Piau�', 18);
insert tblCIDADE values ('Flores do Piau�', 18);
insert tblCIDADE values ('Floresta do Piau�', 18);
insert tblCIDADE values ('Floriano', 18);
insert tblCIDADE values ('Francin�polis', 18);
insert tblCIDADE values ('Francisco Ayres', 18);
insert tblCIDADE values ('Francisco Macedo', 18);
insert tblCIDADE values ('Francisco Santos', 18);
insert tblCIDADE values ('Fronteiras', 18);
insert tblCIDADE values ('Geminiano', 18);
insert tblCIDADE values ('Gilbu�s', 18);
insert tblCIDADE values ('Guadalupe', 18);
insert tblCIDADE values ('Guaribas', 18);
insert tblCIDADE values ('Hugo Napole�o', 18);
insert tblCIDADE values ('Ilha Grande', 18);
insert tblCIDADE values ('Inhuma', 18);
insert tblCIDADE values ('Ipiranga do Piau�', 18);
insert tblCIDADE values ('Isa�as Coelho', 18);
insert tblCIDADE values ('Itain�polis', 18);
insert tblCIDADE values ('Itaueira', 18);
insert tblCIDADE values ('Jacobina do Piau�', 18);
insert tblCIDADE values ('Jaic�s', 18);
insert tblCIDADE values ('Jardim do Mulato', 18);
insert tblCIDADE values ('Jatob� do Piau�', 18);
insert tblCIDADE values ('Jerumenha', 18);
insert tblCIDADE values ('Jo�o Costa', 18);
insert tblCIDADE values ('Joaquim Pires', 18);
insert tblCIDADE values ('Joca Marques', 18);
insert tblCIDADE values ('Jos� de Freitas', 18);
insert tblCIDADE values ('Juazeiro do Piau�', 18);
insert tblCIDADE values ('J�lio Borges', 18);
insert tblCIDADE values ('Jurema', 18);
insert tblCIDADE values ('Lagoinha do Piau�', 18);
insert tblCIDADE values ('Lagoa Alegre', 18);
insert tblCIDADE values ('Lagoa do Barro do Piau�', 18);
insert tblCIDADE values ('Lagoa de S�o Francisco', 18);
insert tblCIDADE values ('Lagoa do Piau�', 18);
insert tblCIDADE values ('Lagoa do S�tio', 18);
insert tblCIDADE values ('Landri Sales', 18);
insert tblCIDADE values ('Lu�s Correia', 18);
insert tblCIDADE values ('Luzil�ndia', 18);
insert tblCIDADE values ('Madeiro', 18);
insert tblCIDADE values ('Manoel Em�dio', 18);
insert tblCIDADE values ('Marcol�ndia', 18);
insert tblCIDADE values ('Marcos Parente', 18);
insert tblCIDADE values ('Massap� do Piau�', 18);
insert tblCIDADE values ('Matias Ol�mpio', 18);
insert tblCIDADE values ('Miguel Alves', 18);
insert tblCIDADE values ('Miguel Le�o', 18);
insert tblCIDADE values ('Milton Brand�o', 18);
insert tblCIDADE values ('Monsenhor Gil', 18);
insert tblCIDADE values ('Monsenhor Hip�lito', 18);
insert tblCIDADE values ('Monte Alegre do Piau�', 18);
insert tblCIDADE values ('Morro Cabe�a no Tempo', 18);
insert tblCIDADE values ('Morro do Chap�u do Piau�', 18);
insert tblCIDADE values ('Murici dos Portelas', 18);
insert tblCIDADE values ('Nazar� do Piau�', 18);
insert tblCIDADE values ('Naz�ria', 18);
insert tblCIDADE values ('Nossa Senhora de Nazar�', 18);
insert tblCIDADE values ('Nossa Senhora dos Rem�dios', 18);
insert tblCIDADE values ('Novo Oriente do Piau�', 18);
insert tblCIDADE values ('Novo Santo Ant�nio', 18);
insert tblCIDADE values ('Oeiras', 18);
insert tblCIDADE values ('Olho D''�gua do Piau�', 18);
insert tblCIDADE values ('Padre Marcos', 18);
insert tblCIDADE values ('Paes Landim', 18);
insert tblCIDADE values ('Paje� do Piau�', 18);
insert tblCIDADE values ('Palmeira do Piau�', 18);
insert tblCIDADE values ('Palmeirais', 18);
insert tblCIDADE values ('Paquet�', 18);
insert tblCIDADE values ('Parnagu�', 18);
insert tblCIDADE values ('Parna�ba', 18);
insert tblCIDADE values ('Passagem Franca do Piau�', 18);
insert tblCIDADE values ('Patos do Piau�', 18);
insert tblCIDADE values ('Pau D''Arco do Piau�', 18);
insert tblCIDADE values ('Paulistana', 18);
insert tblCIDADE values ('Pavussu', 18);
insert tblCIDADE values ('Pedro II', 18);
insert tblCIDADE values ('Pedro Laurentino', 18);
insert tblCIDADE values ('Nova Santa Rita', 18);
insert tblCIDADE values ('Picos', 18);
insert tblCIDADE values ('Pimenteiras', 18);
insert tblCIDADE values ('Pio IX', 18);
insert tblCIDADE values ('Piracuruca', 18);
insert tblCIDADE values ('Piripiri', 18);
insert tblCIDADE values ('Porto', 18);
insert tblCIDADE values ('Porto Alegre do Piau�', 18);
insert tblCIDADE values ('Prata do Piau�', 18);
insert tblCIDADE values ('Queimada Nova', 18);
insert tblCIDADE values ('Reden��o do Gurgu�ia', 18);
insert tblCIDADE values ('Regenera��o', 18);
insert tblCIDADE values ('Riacho Frio', 18);
insert tblCIDADE values ('Ribeira do Piau�', 18);
insert tblCIDADE values ('Ribeiro Gon�alves', 18);
insert tblCIDADE values ('Rio Grande do Piau�', 18);
insert tblCIDADE values ('Santa Cruz do Piau�', 18);
insert tblCIDADE values ('Santa Cruz dos Milagres', 18);
insert tblCIDADE values ('Santa Filomena', 18);
insert tblCIDADE values ('Santa Luz', 18);
insert tblCIDADE values ('Santana do Piau�', 18);
insert tblCIDADE values ('Santa Rosa do Piau�', 18);
insert tblCIDADE values ('Santo Ant�nio de Lisboa', 18);
insert tblCIDADE values ('Santo Ant�nio dos Milagres', 18);
insert tblCIDADE values ('Santo In�cio do Piau�', 18);
insert tblCIDADE values ('S�o Braz do Piau�', 18);
insert tblCIDADE values ('S�o F�lix do Piau�', 18);
insert tblCIDADE values ('S�o Francisco de Assis do Piau�', 18);
insert tblCIDADE values ('S�o Francisco do Piau�', 18);
insert tblCIDADE values ('S�o Gon�alo do Gurgu�ia', 18);
insert tblCIDADE values ('S�o Gon�alo do Piau�', 18);
insert tblCIDADE values ('S�o Jo�o da Canabrava', 18);
insert tblCIDADE values ('S�o Jo�o da Fronteira', 18);
insert tblCIDADE values ('S�o Jo�o da Serra', 18);
insert tblCIDADE values ('S�o Jo�o da Varjota', 18);
insert tblCIDADE values ('S�o Jo�o do Arraial', 18);
insert tblCIDADE values ('S�o Jo�o do Piau�', 18);
insert tblCIDADE values ('S�o Jos� do Divino', 18);
insert tblCIDADE values ('S�o Jos� do Peixe', 18);
insert tblCIDADE values ('S�o Jos� do Piau�', 18);
insert tblCIDADE values ('S�o Juli�o', 18);
insert tblCIDADE values ('S�o Louren�o do Piau�', 18);
insert tblCIDADE values ('S�o Luis do Piau�', 18);
insert tblCIDADE values ('S�o Miguel da Baixa Grande', 18);
insert tblCIDADE values ('S�o Miguel do Fidalgo', 18);
insert tblCIDADE values ('S�o Miguel do Tapuio', 18);
insert tblCIDADE values ('S�o Pedro do Piau�', 18);
insert tblCIDADE values ('S�o Raimundo Nonato', 18);
insert tblCIDADE values ('Sebasti�o Barros', 18);
insert tblCIDADE values ('Sebasti�o Leal', 18);
insert tblCIDADE values ('Sigefredo Pacheco', 18);
insert tblCIDADE values ('Sim�es', 18);
insert tblCIDADE values ('Simpl�cio Mendes', 18);
insert tblCIDADE values ('Socorro do Piau�', 18);
insert tblCIDADE values ('Sussuapara', 18);
insert tblCIDADE values ('Tamboril do Piau�', 18);
insert tblCIDADE values ('Tanque do Piau�', 18);
insert tblCIDADE values ('Teresina', 18);
insert tblCIDADE values ('Uni�o', 18);
insert tblCIDADE values ('Uru�u�', 18);
insert tblCIDADE values ('Valen�a do Piau�', 18);
insert tblCIDADE values ('V�rzea Branca', 18);
insert tblCIDADE values ('V�rzea Grande', 18);
insert tblCIDADE values ('Vera Mendes', 18);
insert tblCIDADE values ('Vila Nova do Piau�', 18);
insert tblCIDADE values ('Wall Ferraz', 18);
insert tblCIDADE values ('Angra dos Reis', 19);
insert tblCIDADE values ('Aperib�', 19);
insert tblCIDADE values ('Araruama', 19);
insert tblCIDADE values ('Areal', 19);
insert tblCIDADE values ('Arma��o dos B�zios', 19);
insert tblCIDADE values ('Arraial do Cabo', 19);
insert tblCIDADE values ('Barra do Pira�', 19);
insert tblCIDADE values ('Barra Mansa', 19);
insert tblCIDADE values ('Belford Roxo', 19);
insert tblCIDADE values ('Bom Jardim', 19);
insert tblCIDADE values ('Bom Jesus do Itabapoana', 19);
insert tblCIDADE values ('Cabo Frio', 19);
insert tblCIDADE values ('Cachoeiras de Macacu', 19);
insert tblCIDADE values ('Cambuci', 19);
insert tblCIDADE values ('Carapebus', 19);
insert tblCIDADE values ('Comendador Levy Gasparian', 19);
insert tblCIDADE values ('Campos dos Goytacazes', 19);
insert tblCIDADE values ('Cantagalo', 19);
insert tblCIDADE values ('Cardoso Moreira', 19);
insert tblCIDADE values ('Carmo', 19);
insert tblCIDADE values ('Casimiro de Abreu', 19);
insert tblCIDADE values ('Concei��o de Macabu', 19);
insert tblCIDADE values ('Cordeiro', 19);
insert tblCIDADE values ('Duas Barras', 19);
insert tblCIDADE values ('Duque de Caxias', 19);
insert tblCIDADE values ('Engenheiro Paulo de Frontin', 19);
insert tblCIDADE values ('Guapimirim', 19);
insert tblCIDADE values ('Iguaba Grande', 19);
insert tblCIDADE values ('Itabora�', 19);
insert tblCIDADE values ('Itagua�', 19);
insert tblCIDADE values ('Italva', 19);
insert tblCIDADE values ('Itaocara', 19);
insert tblCIDADE values ('Itaperuna', 19);
insert tblCIDADE values ('Itatiaia', 19);
insert tblCIDADE values ('Japeri', 19);
insert tblCIDADE values ('Laje do Muria�', 19);
insert tblCIDADE values ('Maca�', 19);
insert tblCIDADE values ('Macuco', 19);
insert tblCIDADE values ('Mag�', 19);
insert tblCIDADE values ('Mangaratiba', 19);
insert tblCIDADE values ('Maric�', 19);
insert tblCIDADE values ('Mendes', 19);
insert tblCIDADE values ('Mesquita', 19);
insert tblCIDADE values ('Miguel Pereira', 19);
insert tblCIDADE values ('Miracema', 19);
insert tblCIDADE values ('Natividade', 19);
insert tblCIDADE values ('Nil�polis', 19);
insert tblCIDADE values ('Niter�i', 19);
insert tblCIDADE values ('Nova Friburgo', 19);
insert tblCIDADE values ('Nova Igua�u', 19);
insert tblCIDADE values ('Paracambi', 19);
insert tblCIDADE values ('Para�ba do Sul', 19);
insert tblCIDADE values ('Paraty', 19);
insert tblCIDADE values ('Paty do Alferes', 19);
insert tblCIDADE values ('Petr�polis', 19);
insert tblCIDADE values ('Pinheiral', 19);
insert tblCIDADE values ('Pira�', 19);
insert tblCIDADE values ('Porci�ncula', 19);
insert tblCIDADE values ('Porto Real', 19);
insert tblCIDADE values ('Quatis', 19);
insert tblCIDADE values ('Queimados', 19);
insert tblCIDADE values ('Quissam�', 19);
insert tblCIDADE values ('Resende', 19);
insert tblCIDADE values ('Rio Bonito', 19);
insert tblCIDADE values ('Rio Claro', 19);
insert tblCIDADE values ('Rio das Flores', 19);
insert tblCIDADE values ('Rio das Ostras', 19);
insert tblCIDADE values ('Rio de Janeiro', 19);
insert tblCIDADE values ('Santa Maria Madalena', 19);
insert tblCIDADE values ('Santo Ant�nio de P�dua', 19);
insert tblCIDADE values ('S�o Francisco de Itabapoana', 19);
insert tblCIDADE values ('S�o Fid�lis', 19);
insert tblCIDADE values ('S�o Gon�alo', 19);
insert tblCIDADE values ('S�o Jo�o da Barra', 19);
insert tblCIDADE values ('S�o Jo�o de Meriti', 19);
insert tblCIDADE values ('S�o Jos� de Ub�', 19);
insert tblCIDADE values ('S�o Jos� do Vale do Rio Preto', 19);
insert tblCIDADE values ('S�o Pedro da Aldeia', 19);
insert tblCIDADE values ('S�o Sebasti�o do Alto', 19);
insert tblCIDADE values ('Sapucaia', 19);
insert tblCIDADE values ('Saquarema', 19);
insert tblCIDADE values ('Serop�dica', 19);
insert tblCIDADE values ('Silva Jardim', 19);
insert tblCIDADE values ('Sumidouro', 19);
insert tblCIDADE values ('Tangu�', 19);
insert tblCIDADE values ('Teres�polis', 19);
insert tblCIDADE values ('Trajano de Moraes', 19);
insert tblCIDADE values ('Tr�s Rios', 19);
insert tblCIDADE values ('Valen�a', 19);
insert tblCIDADE values ('Varre-Sai', 19);
insert tblCIDADE values ('Vassouras', 19);
insert tblCIDADE values ('Volta Redonda', 19);
insert tblCIDADE values ('Acari', 20);
insert tblCIDADE values ('A�u', 20);
insert tblCIDADE values ('Afonso Bezerra', 20);
insert tblCIDADE values ('�gua Nova', 20);
insert tblCIDADE values ('Alexandria', 20);
insert tblCIDADE values ('Almino Afonso', 20);
insert tblCIDADE values ('Alto do Rodrigues', 20);
insert tblCIDADE values ('Angicos', 20);
insert tblCIDADE values ('Ant�nio Martins', 20);
insert tblCIDADE values ('Apodi', 20);
insert tblCIDADE values ('Areia Branca', 20);
insert tblCIDADE values ('Ar�s', 20);
insert tblCIDADE values ('Augusto Severo', 20);
insert tblCIDADE values ('Ba�a Formosa', 20);
insert tblCIDADE values ('Bara�na', 20);
insert tblCIDADE values ('Barcelona', 20);
insert tblCIDADE values ('Bento Fernandes', 20);
insert tblCIDADE values ('Bod�', 20);
insert tblCIDADE values ('Bom Jesus', 20);
insert tblCIDADE values ('Brejinho', 20);
insert tblCIDADE values ('Cai�ara do Norte', 20);
insert tblCIDADE values ('Cai�ara do Rio do Vento', 20);
insert tblCIDADE values ('Caic�', 20);
insert tblCIDADE values ('Campo Redondo', 20);
insert tblCIDADE values ('Canguaretama', 20);
insert tblCIDADE values ('Cara�bas', 20);
insert tblCIDADE values ('Carna�ba dos Dantas', 20);
insert tblCIDADE values ('Carnaubais', 20);
insert tblCIDADE values ('Cear�-Mirim', 20);
insert tblCIDADE values ('Cerro Cor�', 20);
insert tblCIDADE values ('Coronel Ezequiel', 20);
insert tblCIDADE values ('Coronel Jo�o Pessoa', 20);
insert tblCIDADE values ('Cruzeta', 20);
insert tblCIDADE values ('Currais Novos', 20);
insert tblCIDADE values ('Doutor Severiano', 20);
insert tblCIDADE values ('Parnamirim', 20);
insert tblCIDADE values ('Encanto', 20);
insert tblCIDADE values ('Equador', 20);
insert tblCIDADE values ('Esp�rito Santo', 20);
insert tblCIDADE values ('Extremoz', 20);
insert tblCIDADE values ('Felipe Guerra', 20);
insert tblCIDADE values ('Fernando Pedroza', 20);
insert tblCIDADE values ('Flor�nia', 20);
insert tblCIDADE values ('Francisco Dantas', 20);
insert tblCIDADE values ('Frutuoso Gomes', 20);
insert tblCIDADE values ('Galinhos', 20);
insert tblCIDADE values ('Goianinha', 20);
insert tblCIDADE values ('Governador Dix-Sept Rosado', 20);
insert tblCIDADE values ('Grossos', 20);
insert tblCIDADE values ('Guamar�', 20);
insert tblCIDADE values ('Ielmo Marinho', 20);
insert tblCIDADE values ('Ipangua�u', 20);
insert tblCIDADE values ('Ipueira', 20);
insert tblCIDADE values ('Itaj�', 20);
insert tblCIDADE values ('Ita�', 20);
insert tblCIDADE values ('Ja�an�', 20);
insert tblCIDADE values ('Janda�ra', 20);
insert tblCIDADE values ('Jandu�s', 20);
insert tblCIDADE values ('Janu�rio Cicco', 20);
insert tblCIDADE values ('Japi', 20);
insert tblCIDADE values ('Jardim de Angicos', 20);
insert tblCIDADE values ('Jardim de Piranhas', 20);
insert tblCIDADE values ('Jardim do Serid�', 20);
insert tblCIDADE values ('Jo�o C�mara', 20);
insert tblCIDADE values ('Jo�o Dias', 20);
insert tblCIDADE values ('Jos� da Penha', 20);
insert tblCIDADE values ('Jucurutu', 20);
insert tblCIDADE values ('Jundi�', 20);
insert tblCIDADE values ('Lagoa d''Anta', 20);
insert tblCIDADE values ('Lagoa de Pedras', 20);
insert tblCIDADE values ('Lagoa de Velhos', 20);
insert tblCIDADE values ('Lagoa Nova', 20);
insert tblCIDADE values ('Lagoa Salgada', 20);
insert tblCIDADE values ('Lajes', 20);
insert tblCIDADE values ('Lajes Pintadas', 20);
insert tblCIDADE values ('Lucr�cia', 20);
insert tblCIDADE values ('Lu�s Gomes', 20);
insert tblCIDADE values ('Maca�ba', 20);
insert tblCIDADE values ('Macau', 20);
insert tblCIDADE values ('Major Sales', 20);
insert tblCIDADE values ('Marcelino Vieira', 20);
insert tblCIDADE values ('Martins', 20);
insert tblCIDADE values ('Maxaranguape', 20);
insert tblCIDADE values ('Messias Targino', 20);
insert tblCIDADE values ('Montanhas', 20);
insert tblCIDADE values ('Monte Alegre', 20);
insert tblCIDADE values ('Monte das Gameleiras', 20);
insert tblCIDADE values ('Mossor�', 20);
insert tblCIDADE values ('Natal', 20);
insert tblCIDADE values ('N�sia Floresta', 20);
insert tblCIDADE values ('Nova Cruz', 20);
insert tblCIDADE values ('Olho-d''�gua do Borges', 20);
insert tblCIDADE values ('Ouro Branco', 20);
insert tblCIDADE values ('Paran�', 20);
insert tblCIDADE values ('Para�', 20);
insert tblCIDADE values ('Parazinho', 20);
insert tblCIDADE values ('Parelhas', 20);
insert tblCIDADE values ('Rio do Fogo', 20);
insert tblCIDADE values ('Passa e Fica', 20);
insert tblCIDADE values ('Passagem', 20);
insert tblCIDADE values ('Patu', 20);
insert tblCIDADE values ('Santa Maria', 20);
insert tblCIDADE values ('Pau dos Ferros', 20);
insert tblCIDADE values ('Pedra Grande', 20);
insert tblCIDADE values ('Pedra Preta', 20);
insert tblCIDADE values ('Pedro Avelino', 20);
insert tblCIDADE values ('Pedro Velho', 20);
insert tblCIDADE values ('Pend�ncias', 20);
insert tblCIDADE values ('Pil�es', 20);
insert tblCIDADE values ('Po�o Branco', 20);
insert tblCIDADE values ('Portalegre', 20);
insert tblCIDADE values ('Porto do Mangue', 20);
insert tblCIDADE values ('Presidente Juscelino', 20);
insert tblCIDADE values ('Pureza', 20);
insert tblCIDADE values ('Rafael Fernandes', 20);
insert tblCIDADE values ('Rafael Godeiro', 20);
insert tblCIDADE values ('Riacho da Cruz', 20);
insert tblCIDADE values ('Riacho de Santana', 20);
insert tblCIDADE values ('Riachuelo', 20);
insert tblCIDADE values ('Rodolfo Fernandes', 20);
insert tblCIDADE values ('Tibau', 20);
insert tblCIDADE values ('Ruy Barbosa', 20);
insert tblCIDADE values ('Santa Cruz', 20);
insert tblCIDADE values ('Santana do Matos', 20);
insert tblCIDADE values ('Santana do Serid�', 20);
insert tblCIDADE values ('Santo Ant�nio', 20);
insert tblCIDADE values ('S�o Bento do Norte', 20);
insert tblCIDADE values ('S�o Bento do Trair�', 20);
insert tblCIDADE values ('S�o Fernando', 20);
insert tblCIDADE values ('S�o Francisco do Oeste', 20);
insert tblCIDADE values ('S�o Gon�alo do Amarante', 20);
insert tblCIDADE values ('S�o Jo�o do Sabugi', 20);
insert tblCIDADE values ('S�o Jos� de Mipibu', 20);
insert tblCIDADE values ('S�o Jos� do Campestre', 20);
insert tblCIDADE values ('S�o Jos� do Serid�', 20);
insert tblCIDADE values ('S�o Miguel', 20);
insert tblCIDADE values ('S�o Miguel do Gostoso', 20);
insert tblCIDADE values ('S�o Paulo do Potengi', 20);
insert tblCIDADE values ('S�o Pedro', 20);
insert tblCIDADE values ('S�o Rafael', 20);
insert tblCIDADE values ('S�o Tom�', 20);
insert tblCIDADE values ('S�o Vicente', 20);
insert tblCIDADE values ('Senador El�i de Souza', 20);
insert tblCIDADE values ('Senador Georgino Avelino', 20);
insert tblCIDADE values ('Serra de S�o Bento', 20);
insert tblCIDADE values ('Serra do Mel', 20);
insert tblCIDADE values ('Serra Negra do Norte', 20);
insert tblCIDADE values ('Serrinha', 20);
insert tblCIDADE values ('Serrinha dos Pintos', 20);
insert tblCIDADE values ('Severiano Melo', 20);
insert tblCIDADE values ('S�tio Novo', 20);
insert tblCIDADE values ('Taboleiro Grande', 20);
insert tblCIDADE values ('Taipu', 20);
insert tblCIDADE values ('Tangar�', 20);
insert tblCIDADE values ('Tenente Ananias', 20);
insert tblCIDADE values ('Tenente Laurentino Cruz', 20);
insert tblCIDADE values ('Tibau do Sul', 20);
insert tblCIDADE values ('Timba�ba dos Batistas', 20);
insert tblCIDADE values ('Touros', 20);
insert tblCIDADE values ('Triunfo Potiguar', 20);
insert tblCIDADE values ('Umarizal', 20);
insert tblCIDADE values ('Upanema', 20);
insert tblCIDADE values ('V�rzea', 20);
insert tblCIDADE values ('Venha-Ver', 20);
insert tblCIDADE values ('Vera Cruz', 20);
insert tblCIDADE values ('Vi�osa', 20);
insert tblCIDADE values ('Vila Flor', 20);
insert tblCIDADE values ('Acegu�', 21);
insert tblCIDADE values ('�gua Santa', 21);
insert tblCIDADE values ('Agudo', 21);
insert tblCIDADE values ('Ajuricaba', 21);
insert tblCIDADE values ('Alecrim', 21);
insert tblCIDADE values ('Alegrete', 21);
insert tblCIDADE values ('Alegria', 21);
insert tblCIDADE values ('Almirante Tamandar� do Sul', 21);
insert tblCIDADE values ('Alpestre', 21);
insert tblCIDADE values ('Alto Alegre', 21);
insert tblCIDADE values ('Alto Feliz', 21);
insert tblCIDADE values ('Alvorada', 21);
insert tblCIDADE values ('Amaral Ferrador', 21);
insert tblCIDADE values ('Ametista do Sul', 21);
insert tblCIDADE values ('Andr� da Rocha', 21);
insert tblCIDADE values ('Anta Gorda', 21);
insert tblCIDADE values ('Ant�nio Prado', 21);
insert tblCIDADE values ('Arambar�', 21);
insert tblCIDADE values ('Araric�', 21);
insert tblCIDADE values ('Aratiba', 21);
insert tblCIDADE values ('Arroio do Meio', 21);
insert tblCIDADE values ('Arroio do Sal', 21);
insert tblCIDADE values ('Arroio do Padre', 21);
insert tblCIDADE values ('Arroio dos Ratos', 21);
insert tblCIDADE values ('Arroio do Tigre', 21);
insert tblCIDADE values ('Arroio Grande', 21);
insert tblCIDADE values ('Arvorezinha', 21);
insert tblCIDADE values ('Augusto Pestana', 21);
insert tblCIDADE values ('�urea', 21);
insert tblCIDADE values ('Bag�', 21);
insert tblCIDADE values ('Balne�rio Pinhal', 21);
insert tblCIDADE values ('Bar�o', 21);
insert tblCIDADE values ('Bar�o de Cotegipe', 21);
insert tblCIDADE values ('Bar�o do Triunfo', 21);
insert tblCIDADE values ('Barrac�o', 21);
insert tblCIDADE values ('Barra do Guarita', 21);
insert tblCIDADE values ('Barra do Quara�', 21);
insert tblCIDADE values ('Barra do Ribeiro', 21);
insert tblCIDADE values ('Barra do Rio Azul', 21);
insert tblCIDADE values ('Barra Funda', 21);
insert tblCIDADE values ('Barros Cassal', 21);
insert tblCIDADE values ('Benjamin Constant do Sul', 21);
insert tblCIDADE values ('Bento Gon�alves', 21);
insert tblCIDADE values ('Boa Vista das Miss�es', 21);
insert tblCIDADE values ('Boa Vista do Buric�', 21);
insert tblCIDADE values ('Boa Vista do Cadeado', 21);
insert tblCIDADE values ('Boa Vista do Incra', 21);
insert tblCIDADE values ('Boa Vista do Sul', 21);
insert tblCIDADE values ('Bom Jesus', 21);
insert tblCIDADE values ('Bom Princ�pio', 21);
insert tblCIDADE values ('Bom Progresso', 21);
insert tblCIDADE values ('Bom Retiro do Sul', 21);
insert tblCIDADE values ('Boqueir�o do Le�o', 21);
insert tblCIDADE values ('Bossoroca', 21);
insert tblCIDADE values ('Bozano', 21);
insert tblCIDADE values ('Braga', 21);
insert tblCIDADE values ('Brochier', 21);
insert tblCIDADE values ('Buti�', 21);
insert tblCIDADE values ('Ca�apava do Sul', 21);
insert tblCIDADE values ('Cacequi', 21);
insert tblCIDADE values ('Cachoeira do Sul', 21);
insert tblCIDADE values ('Cachoeirinha', 21);
insert tblCIDADE values ('Cacique Doble', 21);
insert tblCIDADE values ('Caibat�', 21);
insert tblCIDADE values ('Cai�ara', 21);
insert tblCIDADE values ('Camaqu�', 21);
insert tblCIDADE values ('Camargo', 21);
insert tblCIDADE values ('Cambar� do Sul', 21);
insert tblCIDADE values ('Campestre da Serra', 21);
insert tblCIDADE values ('Campina das Miss�es', 21);
insert tblCIDADE values ('Campinas do Sul', 21);
insert tblCIDADE values ('Campo Bom', 21);
insert tblCIDADE values ('Campo Novo', 21);
insert tblCIDADE values ('Campos Borges', 21);
insert tblCIDADE values ('Candel�ria', 21);
insert tblCIDADE values ('C�ndido God�i', 21);
insert tblCIDADE values ('Candiota', 21);
insert tblCIDADE values ('Canela', 21);
insert tblCIDADE values ('Cangu�u', 21);
insert tblCIDADE values ('Canoas', 21);
insert tblCIDADE values ('Canudos do Vale', 21);
insert tblCIDADE values ('Cap�o Bonito do Sul', 21);
insert tblCIDADE values ('Cap�o da Canoa', 21);
insert tblCIDADE values ('Cap�o do Cip�', 21);
insert tblCIDADE values ('Cap�o do Le�o', 21);
insert tblCIDADE values ('Capivari do Sul', 21);
insert tblCIDADE values ('Capela de Santana', 21);
insert tblCIDADE values ('Capit�o', 21);
insert tblCIDADE values ('Carazinho', 21);
insert tblCIDADE values ('Cara�', 21);
insert tblCIDADE values ('Carlos Barbosa', 21);
insert tblCIDADE values ('Carlos Gomes', 21);
insert tblCIDADE values ('Casca', 21);
insert tblCIDADE values ('Caseiros', 21);
insert tblCIDADE values ('Catu�pe', 21);
insert tblCIDADE values ('Caxias do Sul', 21);
insert tblCIDADE values ('Centen�rio', 21);
insert tblCIDADE values ('Cerrito', 21);
insert tblCIDADE values ('Cerro Branco', 21);
insert tblCIDADE values ('Cerro Grande', 21);
insert tblCIDADE values ('Cerro Grande do Sul', 21);
insert tblCIDADE values ('Cerro Largo', 21);
insert tblCIDADE values ('Chapada', 21);
insert tblCIDADE values ('Charqueadas', 21);
insert tblCIDADE values ('Charrua', 21);
insert tblCIDADE values ('Chiapetta', 21);
insert tblCIDADE values ('Chu�', 21);
insert tblCIDADE values ('Chuvisca', 21);
insert tblCIDADE values ('Cidreira', 21);
insert tblCIDADE values ('Cir�aco', 21);
insert tblCIDADE values ('Colinas', 21);
insert tblCIDADE values ('Colorado', 21);
insert tblCIDADE values ('Condor', 21);
insert tblCIDADE values ('Constantina', 21);
insert tblCIDADE values ('Coqueiro Baixo', 21);
insert tblCIDADE values ('Coqueiros do Sul', 21);
insert tblCIDADE values ('Coronel Barros', 21);
insert tblCIDADE values ('Coronel Bicaco', 21);
insert tblCIDADE values ('Coronel Pilar', 21);
insert tblCIDADE values ('Cotipor�', 21);
insert tblCIDADE values ('Coxilha', 21);
insert tblCIDADE values ('Crissiumal', 21);
insert tblCIDADE values ('Cristal', 21);
insert tblCIDADE values ('Cristal do Sul', 21);
insert tblCIDADE values ('Cruz Alta', 21);
insert tblCIDADE values ('Cruzaltense', 21);
insert tblCIDADE values ('Cruzeiro do Sul', 21);
insert tblCIDADE values ('David Canabarro', 21);
insert tblCIDADE values ('Derrubadas', 21);
insert tblCIDADE values ('Dezesseis de Novembro', 21);
insert tblCIDADE values ('Dilermando de Aguiar', 21);
insert tblCIDADE values ('Dois Irm�os', 21);
insert tblCIDADE values ('Dois Irm�os das Miss�es', 21);
insert tblCIDADE values ('Dois Lajeados', 21);
insert tblCIDADE values ('Dom Feliciano', 21);
insert tblCIDADE values ('Dom Pedro de Alc�ntara', 21);
insert tblCIDADE values ('Dom Pedrito', 21);
insert tblCIDADE values ('Dona Francisca', 21);
insert tblCIDADE values ('Doutor Maur�cio Cardoso', 21);
insert tblCIDADE values ('Doutor Ricardo', 21);
insert tblCIDADE values ('Eldorado do Sul', 21);
insert tblCIDADE values ('Encantado', 21);
insert tblCIDADE values ('Encruzilhada do Sul', 21);
insert tblCIDADE values ('Engenho Velho', 21);
insert tblCIDADE values ('Entre-Iju�s', 21);
insert tblCIDADE values ('Entre Rios do Sul', 21);
insert tblCIDADE values ('Erebango', 21);
insert tblCIDADE values ('Erechim', 21);
insert tblCIDADE values ('Ernestina', 21);
insert tblCIDADE values ('Herval', 21);
insert tblCIDADE values ('Erval Grande', 21);
insert tblCIDADE values ('Erval Seco', 21);
insert tblCIDADE values ('Esmeralda', 21);
insert tblCIDADE values ('Esperan�a do Sul', 21);
insert tblCIDADE values ('Espumoso', 21);
insert tblCIDADE values ('Esta��o', 21);
insert tblCIDADE values ('Est�ncia Velha', 21);
insert tblCIDADE values ('Esteio', 21);
insert tblCIDADE values ('Estrela', 21);
insert tblCIDADE values ('Estrela Velha', 21);
insert tblCIDADE values ('Eug�nio de Castro', 21);
insert tblCIDADE values ('Fagundes Varela', 21);
insert tblCIDADE values ('Farroupilha', 21);
insert tblCIDADE values ('Faxinal do Soturno', 21);
insert tblCIDADE values ('Faxinalzinho', 21);
insert tblCIDADE values ('Fazenda Vilanova', 21);
insert tblCIDADE values ('Feliz', 21);
insert tblCIDADE values ('Flores da Cunha', 21);
insert tblCIDADE values ('Floriano Peixoto', 21);
insert tblCIDADE values ('Fontoura Xavier', 21);
insert tblCIDADE values ('Formigueiro', 21);
insert tblCIDADE values ('Forquetinha', 21);
insert tblCIDADE values ('Fortaleza dos Valos', 21);
insert tblCIDADE values ('Frederico Westphalen', 21);
insert tblCIDADE values ('Garibaldi', 21);
insert tblCIDADE values ('Garruchos', 21);
insert tblCIDADE values ('Gaurama', 21);
insert tblCIDADE values ('General C�mara', 21);
insert tblCIDADE values ('Gentil', 21);
insert tblCIDADE values ('Get�lio Vargas', 21);
insert tblCIDADE values ('Giru�', 21);
insert tblCIDADE values ('Glorinha', 21);
insert tblCIDADE values ('Gramado', 21);
insert tblCIDADE values ('Gramado dos Loureiros', 21);
insert tblCIDADE values ('Gramado Xavier', 21);
insert tblCIDADE values ('Gravata�', 21);
insert tblCIDADE values ('Guabiju', 21);
insert tblCIDADE values ('Gua�ba', 21);
insert tblCIDADE values ('Guapor�', 21);
insert tblCIDADE values ('Guarani das Miss�es', 21);
insert tblCIDADE values ('Harmonia', 21);
insert tblCIDADE values ('Herveiras', 21);
insert tblCIDADE values ('Horizontina', 21);
insert tblCIDADE values ('Hulha Negra', 21);
insert tblCIDADE values ('Humait�', 21);
insert tblCIDADE values ('Ibarama', 21);
insert tblCIDADE values ('Ibia��', 21);
insert tblCIDADE values ('Ibiraiaras', 21);
insert tblCIDADE values ('Ibirapuit�', 21);
insert tblCIDADE values ('Ibirub�', 21);
insert tblCIDADE values ('Igrejinha', 21);
insert tblCIDADE values ('Iju�', 21);
insert tblCIDADE values ('Il�polis', 21);
insert tblCIDADE values ('Imb�', 21);
insert tblCIDADE values ('Imigrante', 21);
insert tblCIDADE values ('Independ�ncia', 21);
insert tblCIDADE values ('Inhacor�', 21);
insert tblCIDADE values ('Ip�', 21);
insert tblCIDADE values ('Ipiranga do Sul', 21);
insert tblCIDADE values ('Ira�', 21);
insert tblCIDADE values ('Itaara', 21);
insert tblCIDADE values ('Itacurubi', 21);
insert tblCIDADE values ('Itapuca', 21);
insert tblCIDADE values ('Itaqui', 21);
insert tblCIDADE values ('Itati', 21);
insert tblCIDADE values ('Itatiba do Sul', 21);
insert tblCIDADE values ('Ivor�', 21);
insert tblCIDADE values ('Ivoti', 21);
insert tblCIDADE values ('Jaboticaba', 21);
insert tblCIDADE values ('Jacuizinho', 21);
insert tblCIDADE values ('Jacutinga', 21);
insert tblCIDADE values ('Jaguar�o', 21);
insert tblCIDADE values ('Jaguari', 21);
insert tblCIDADE values ('Jaquirana', 21);
insert tblCIDADE values ('Jari', 21);
insert tblCIDADE values ('J�ia', 21);
insert tblCIDADE values ('J�lio de Castilhos', 21);
insert tblCIDADE values ('Lagoa Bonita do Sul', 21);
insert tblCIDADE values ('Lago�o', 21);
insert tblCIDADE values ('Lagoa dos Tr�s Cantos', 21);
insert tblCIDADE values ('Lagoa Vermelha', 21);
insert tblCIDADE values ('Lajeado', 21);
insert tblCIDADE values ('Lajeado do Bugre', 21);
insert tblCIDADE values ('Lavras do Sul', 21);
insert tblCIDADE values ('Liberato Salzano', 21);
insert tblCIDADE values ('Lindolfo Collor', 21);
insert tblCIDADE values ('Linha Nova', 21);
insert tblCIDADE values ('Machadinho', 21);
insert tblCIDADE values ('Ma�ambar�', 21);
insert tblCIDADE values ('Mampituba', 21);
insert tblCIDADE values ('Manoel Viana', 21);
insert tblCIDADE values ('Maquin�', 21);
insert tblCIDADE values ('Marat�', 21);
insert tblCIDADE values ('Marau', 21);
insert tblCIDADE values ('Marcelino Ramos', 21);
insert tblCIDADE values ('Mariana Pimentel', 21);
insert tblCIDADE values ('Mariano Moro', 21);
insert tblCIDADE values ('Marques de Souza', 21);
insert tblCIDADE values ('Mata', 21);
insert tblCIDADE values ('Mato Castelhano', 21);
insert tblCIDADE values ('Mato Leit�o', 21);
insert tblCIDADE values ('Mato Queimado', 21);
insert tblCIDADE values ('Maximiliano de Almeida', 21);
insert tblCIDADE values ('Minas do Le�o', 21);
insert tblCIDADE values ('Miragua�', 21);
insert tblCIDADE values ('Montauri', 21);
insert tblCIDADE values ('Monte Alegre dos Campos', 21);
insert tblCIDADE values ('Monte Belo do Sul', 21);
insert tblCIDADE values ('Montenegro', 21);
insert tblCIDADE values ('Morma�o', 21);
insert tblCIDADE values ('Morrinhos do Sul', 21);
insert tblCIDADE values ('Morro Redondo', 21);
insert tblCIDADE values ('Morro Reuter', 21);
insert tblCIDADE values ('Mostardas', 21);
insert tblCIDADE values ('Mu�um', 21);
insert tblCIDADE values ('Muitos Cap�es', 21);
insert tblCIDADE values ('Muliterno', 21);
insert tblCIDADE values ('N�o-Me-Toque', 21);
insert tblCIDADE values ('Nicolau Vergueiro', 21);
insert tblCIDADE values ('Nonoai', 21);
insert tblCIDADE values ('Nova Alvorada', 21);
insert tblCIDADE values ('Nova Ara��', 21);
insert tblCIDADE values ('Nova Bassano', 21);
insert tblCIDADE values ('Nova Boa Vista', 21);
insert tblCIDADE values ('Nova Br�scia', 21);
insert tblCIDADE values ('Nova Candel�ria', 21);
insert tblCIDADE values ('Nova Esperan�a do Sul', 21);
insert tblCIDADE values ('Nova Hartz', 21);
insert tblCIDADE values ('Nova P�dua', 21);
insert tblCIDADE values ('Nova Palma', 21);
insert tblCIDADE values ('Nova Petr�polis', 21);
insert tblCIDADE values ('Nova Prata', 21);
insert tblCIDADE values ('Nova Ramada', 21);
insert tblCIDADE values ('Nova Roma do Sul', 21);
insert tblCIDADE values ('Nova Santa Rita', 21);
insert tblCIDADE values ('Novo Cabrais', 21);
insert tblCIDADE values ('Novo Hamburgo', 21);
insert tblCIDADE values ('Novo Machado', 21);
insert tblCIDADE values ('Novo Tiradentes', 21);
insert tblCIDADE values ('Novo Xingu', 21);
insert tblCIDADE values ('Novo Barreiro', 21);
insert tblCIDADE values ('Os�rio', 21);
insert tblCIDADE values ('Paim Filho', 21);
insert tblCIDADE values ('Palmares do Sul', 21);
insert tblCIDADE values ('Palmeira das Miss�es', 21);
insert tblCIDADE values ('Palmitinho', 21);
insert tblCIDADE values ('Panambi', 21);
insert tblCIDADE values ('Pantano Grande', 21);
insert tblCIDADE values ('Para�', 21);
insert tblCIDADE values ('Para�so do Sul', 21);
insert tblCIDADE values ('Pareci Novo', 21);
insert tblCIDADE values ('Parob�', 21);
insert tblCIDADE values ('Passa Sete', 21);
insert tblCIDADE values ('Passo do Sobrado', 21);
insert tblCIDADE values ('Passo Fundo', 21);
insert tblCIDADE values ('Paulo Bento', 21);
insert tblCIDADE values ('Paverama', 21);
insert tblCIDADE values ('Pedras Altas', 21);
insert tblCIDADE values ('Pedro Os�rio', 21);
insert tblCIDADE values ('Peju�ara', 21);
insert tblCIDADE values ('Pelotas', 21);
insert tblCIDADE values ('Picada Caf�', 21);
insert tblCIDADE values ('Pinhal', 21);
insert tblCIDADE values ('Pinhal da Serra', 21);
insert tblCIDADE values ('Pinhal Grande', 21);
insert tblCIDADE values ('Pinheirinho do Vale', 21);
insert tblCIDADE values ('Pinheiro Machado', 21);
insert tblCIDADE values ('Pirap�', 21);
insert tblCIDADE values ('Piratini', 21);
insert tblCIDADE values ('Planalto', 21);
insert tblCIDADE values ('Po�o das Antas', 21);
insert tblCIDADE values ('Pont�o', 21);
insert tblCIDADE values ('Ponte Preta', 21);
insert tblCIDADE values ('Port�o', 21);
insert tblCIDADE values ('Porto Alegre', 21);
insert tblCIDADE values ('Porto Lucena', 21);
insert tblCIDADE values ('Porto Mau�', 21);
insert tblCIDADE values ('Porto Vera Cruz', 21);
insert tblCIDADE values ('Porto Xavier', 21);
insert tblCIDADE values ('Pouso Novo', 21);
insert tblCIDADE values ('Presidente Lucena', 21);
insert tblCIDADE values ('Progresso', 21);
insert tblCIDADE values ('Prot�sio Alves', 21);
insert tblCIDADE values ('Putinga', 21);
insert tblCIDADE values ('Quara�', 21);
insert tblCIDADE values ('Quatro Irm�os', 21);
insert tblCIDADE values ('Quevedos', 21);
insert tblCIDADE values ('Quinze de Novembro', 21);
insert tblCIDADE values ('Redentora', 21);
insert tblCIDADE values ('Relvado', 21);
insert tblCIDADE values ('Restinga Seca', 21);
insert tblCIDADE values ('Rio dos �ndios', 21);
insert tblCIDADE values ('Rio Grande', 21);
insert tblCIDADE values ('Rio Pardo', 21);
insert tblCIDADE values ('Riozinho', 21);
insert tblCIDADE values ('Roca Sales', 21);
insert tblCIDADE values ('Rodeio Bonito', 21);
insert tblCIDADE values ('Rolador', 21);
insert tblCIDADE values ('Rolante', 21);
insert tblCIDADE values ('Ronda Alta', 21);
insert tblCIDADE values ('Rondinha', 21);
insert tblCIDADE values ('Roque Gonzales', 21);
insert tblCIDADE values ('Ros�rio do Sul', 21);
insert tblCIDADE values ('Sagrada Fam�lia', 21);
insert tblCIDADE values ('Saldanha Marinho', 21);
insert tblCIDADE values ('Salto do Jacu�', 21);
insert tblCIDADE values ('Salvador das Miss�es', 21);
insert tblCIDADE values ('Salvador do Sul', 21);
insert tblCIDADE values ('Sananduva', 21);
insert tblCIDADE values ('Santa B�rbara do Sul', 21);
insert tblCIDADE values ('Santa Cec�lia do Sul', 21);
insert tblCIDADE values ('Santa Clara do Sul', 21);
insert tblCIDADE values ('Santa Cruz do Sul', 21);
insert tblCIDADE values ('Santa Maria', 21);
insert tblCIDADE values ('Santa Maria do Herval', 21);
insert tblCIDADE values ('Santa Margarida do Sul', 21);
insert tblCIDADE values ('Santana da Boa Vista', 21);
insert tblCIDADE values ('Sant''Ana do Livramento', 21);
insert tblCIDADE values ('Santa Rosa', 21);
insert tblCIDADE values ('Santa Tereza', 21);
insert tblCIDADE values ('Santa Vit�ria do Palmar', 21);
insert tblCIDADE values ('Santiago', 21);
insert tblCIDADE values ('Santo �ngelo', 21);
insert tblCIDADE values ('Santo Ant�nio do Palma', 21);
insert tblCIDADE values ('Santo Ant�nio da Patrulha', 21);
insert tblCIDADE values ('Santo Ant�nio das Miss�es', 21);
insert tblCIDADE values ('Santo Ant�nio do Planalto', 21);
insert tblCIDADE values ('Santo Augusto', 21);
insert tblCIDADE values ('Santo Cristo', 21);
insert tblCIDADE values ('Santo Expedito do Sul', 21);
insert tblCIDADE values ('S�o Borja', 21);
insert tblCIDADE values ('S�o Domingos do Sul', 21);
insert tblCIDADE values ('S�o Francisco de Assis', 21);
insert tblCIDADE values ('S�o Francisco de Paula', 21);
insert tblCIDADE values ('S�o Gabriel', 21);
insert tblCIDADE values ('S�o Jer�nimo', 21);
insert tblCIDADE values ('S�o Jo�o da Urtiga', 21);
insert tblCIDADE values ('S�o Jo�o do Pol�sine', 21);
insert tblCIDADE values ('S�o Jorge', 21);
insert tblCIDADE values ('S�o Jos� das Miss�es', 21);
insert tblCIDADE values ('S�o Jos� do Herval', 21);
insert tblCIDADE values ('S�o Jos� do Hort�ncio', 21);
insert tblCIDADE values ('S�o Jos� do Inhacor�', 21);
insert tblCIDADE values ('S�o Jos� do Norte', 21);
insert tblCIDADE values ('S�o Jos� do Ouro', 21);
insert tblCIDADE values ('S�o Jos� do Sul', 21);
insert tblCIDADE values ('S�o Jos� dos Ausentes', 21);
insert tblCIDADE values ('S�o Leopoldo', 21);
insert tblCIDADE values ('S�o Louren�o do Sul', 21);
insert tblCIDADE values ('S�o Luiz Gonzaga', 21);
insert tblCIDADE values ('S�o Marcos', 21);
insert tblCIDADE values ('S�o Martinho', 21);
insert tblCIDADE values ('S�o Martinho da Serra', 21);
insert tblCIDADE values ('S�o Miguel das Miss�es', 21);
insert tblCIDADE values ('S�o Nicolau', 21);
insert tblCIDADE values ('S�o Paulo das Miss�es', 21);
insert tblCIDADE values ('S�o Pedro da Serra', 21);
insert tblCIDADE values ('S�o Pedro das Miss�es', 21);
insert tblCIDADE values ('S�o Pedro do Buti�', 21);
insert tblCIDADE values ('S�o Pedro do Sul', 21);
insert tblCIDADE values ('S�o Sebasti�o do Ca�', 21);
insert tblCIDADE values ('S�o Sep�', 21);
insert tblCIDADE values ('S�o Valentim', 21);
insert tblCIDADE values ('S�o Valentim do Sul', 21);
insert tblCIDADE values ('S�o Val�rio do Sul', 21);
insert tblCIDADE values ('S�o Vendelino', 21);
insert tblCIDADE values ('S�o Vicente do Sul', 21);
insert tblCIDADE values ('Sapiranga', 21);
insert tblCIDADE values ('Sapucaia do Sul', 21);
insert tblCIDADE values ('Sarandi', 21);
insert tblCIDADE values ('Seberi', 21);
insert tblCIDADE values ('Sede Nova', 21);
insert tblCIDADE values ('Segredo', 21);
insert tblCIDADE values ('Selbach', 21);
insert tblCIDADE values ('Senador Salgado Filho', 21);
insert tblCIDADE values ('Sentinela do Sul', 21);
insert tblCIDADE values ('Serafina Corr�a', 21);
insert tblCIDADE values ('S�rio', 21);
insert tblCIDADE values ('Sert�o', 21);
insert tblCIDADE values ('Sert�o Santana', 21);
insert tblCIDADE values ('Sete de Setembro', 21);
insert tblCIDADE values ('Severiano de Almeida', 21);
insert tblCIDADE values ('Silveira Martins', 21);
insert tblCIDADE values ('Sinimbu', 21);
insert tblCIDADE values ('Sobradinho', 21);
insert tblCIDADE values ('Soledade', 21);
insert tblCIDADE values ('Taba�', 21);
insert tblCIDADE values ('Tapejara', 21);
insert tblCIDADE values ('Tapera', 21);
insert tblCIDADE values ('Tapes', 21);
insert tblCIDADE values ('Taquara', 21);
insert tblCIDADE values ('Taquari', 21);
insert tblCIDADE values ('Taquaru�u do Sul', 21);
insert tblCIDADE values ('Tavares', 21);
insert tblCIDADE values ('Tenente Portela', 21);
insert tblCIDADE values ('Terra de Areia', 21);
insert tblCIDADE values ('Teut�nia', 21);
insert tblCIDADE values ('Tio Hugo', 21);
insert tblCIDADE values ('Tiradentes do Sul', 21);
insert tblCIDADE values ('Toropi', 21);
insert tblCIDADE values ('Torres', 21);
insert tblCIDADE values ('Tramanda�', 21);
insert tblCIDADE values ('Travesseiro', 21);
insert tblCIDADE values ('Tr�s Arroios', 21);
insert tblCIDADE values ('Tr�s Cachoeiras', 21);
insert tblCIDADE values ('Tr�s Coroas', 21);
insert tblCIDADE values ('Tr�s de Maio', 21);
insert tblCIDADE values ('Tr�s Forquilhas', 21);
insert tblCIDADE values ('Tr�s Palmeiras', 21);
insert tblCIDADE values ('Tr�s Passos', 21);
insert tblCIDADE values ('Trindade do Sul', 21);
insert tblCIDADE values ('Triunfo', 21);
insert tblCIDADE values ('Tucunduva', 21);
insert tblCIDADE values ('Tunas', 21);
insert tblCIDADE values ('Tupanci do Sul', 21);
insert tblCIDADE values ('Tupanciret�', 21);
insert tblCIDADE values ('Tupandi', 21);
insert tblCIDADE values ('Tuparendi', 21);
insert tblCIDADE values ('Turu�u', 21);
insert tblCIDADE values ('Ubiretama', 21);
insert tblCIDADE values ('Uni�o da Serra', 21);
insert tblCIDADE values ('Unistalda', 21);
insert tblCIDADE values ('Uruguaiana', 21);
insert tblCIDADE values ('Vacaria', 21);
insert tblCIDADE values ('Vale Verde', 21);
insert tblCIDADE values ('Vale do Sol', 21);
insert tblCIDADE values ('Vale Real', 21);
insert tblCIDADE values ('Vanini', 21);
insert tblCIDADE values ('Ven�ncio Aires', 21);
insert tblCIDADE values ('Vera Cruz', 21);
insert tblCIDADE values ('Veran�polis', 21);
insert tblCIDADE values ('Vespasiano Correa', 21);
insert tblCIDADE values ('Viadutos', 21);
insert tblCIDADE values ('Viam�o', 21);
insert tblCIDADE values ('Vicente Dutra', 21);
insert tblCIDADE values ('Victor Graeff', 21);
insert tblCIDADE values ('Vila Flores', 21);
insert tblCIDADE values ('Vila L�ngaro', 21);
insert tblCIDADE values ('Vila Maria', 21);
insert tblCIDADE values ('Vila Nova do Sul', 21);
insert tblCIDADE values ('Vista Alegre', 21);
insert tblCIDADE values ('Vista Alegre do Prata', 21);
insert tblCIDADE values ('Vista Ga�cha', 21);
insert tblCIDADE values ('Vit�ria das Miss�es', 21);
insert tblCIDADE values ('Westfalia', 21);
insert tblCIDADE values ('Xangri-l�', 21);
insert tblCIDADE values ('�gua Clara', 21);
insert tblCIDADE values ('Alcin�polis', 21);
insert tblCIDADE values ('Amambai', 21);
insert tblCIDADE values ('Anast�cio', 21);
insert tblCIDADE values ('Anauril�ndia', 21);
insert tblCIDADE values ('Ang�lica', 21);
insert tblCIDADE values ('Ant�nio Jo�o', 21);
insert tblCIDADE values ('Aparecida do Taboado', 21);
insert tblCIDADE values ('Aquidauana', 21);
insert tblCIDADE values ('Aral Moreira', 21);
insert tblCIDADE values ('Bandeirantes', 21);
insert tblCIDADE values ('Bataguassu', 21);
insert tblCIDADE values ('Bataypor�', 21);
insert tblCIDADE values ('Bela Vista', 21);
insert tblCIDADE values ('Bodoquena', 21);
insert tblCIDADE values ('Bonito', 21);
insert tblCIDADE values ('Brasil�ndia', 21);
insert tblCIDADE values ('Caarap�', 21);
insert tblCIDADE values ('Camapu�', 21);
insert tblCIDADE values ('Campo Grande', 21);
insert tblCIDADE values ('Caracol', 21);
insert tblCIDADE values ('Cassil�ndia', 21);
insert tblCIDADE values ('Chapad�o do Sul', 21);
insert tblCIDADE values ('Corguinho', 21);
insert tblCIDADE values ('Coronel Sapucaia', 21);
insert tblCIDADE values ('Corumb�', 21);
insert tblCIDADE values ('Costa Rica', 21);
insert tblCIDADE values ('Coxim', 21);
insert tblCIDADE values ('Deod�polis', 21);
insert tblCIDADE values ('Dois Irm�os do Buriti', 21);
insert tblCIDADE values ('Douradina', 21);
insert tblCIDADE values ('Dourados', 21);
insert tblCIDADE values ('Eldorado', 21);
insert tblCIDADE values ('F�tima do Sul', 21);
insert tblCIDADE values ('Figueir�o', 21);
insert tblCIDADE values ('Gl�ria de Dourados', 21);
insert tblCIDADE values ('Guia Lopes da Laguna', 21);
insert tblCIDADE values ('Iguatemi', 21);
insert tblCIDADE values ('Inoc�ncia', 21);
insert tblCIDADE values ('Itapor�', 21);
insert tblCIDADE values ('Itaquira�', 21);
insert tblCIDADE values ('Ivinhema', 21);
insert tblCIDADE values ('Japor�', 21);
insert tblCIDADE values ('Jaraguari', 21);
insert tblCIDADE values ('Jardim', 21);
insert tblCIDADE values ('Jate�', 21);
insert tblCIDADE values ('Juti', 21);
insert tblCIDADE values ('Lad�rio', 21);
insert tblCIDADE values ('Laguna Carap�', 21);
insert tblCIDADE values ('Maracaju', 21);
insert tblCIDADE values ('Miranda', 21);
insert tblCIDADE values ('Mundo Novo', 21);
insert tblCIDADE values ('Navira�', 21);
insert tblCIDADE values ('Nioaque', 21);
insert tblCIDADE values ('Nova Alvorada do Sul', 21);
insert tblCIDADE values ('Nova Andradina', 21);
insert tblCIDADE values ('Novo Horizonte do Sul', 21);
insert tblCIDADE values ('Parana�ba', 21);
insert tblCIDADE values ('Paranhos', 21);
insert tblCIDADE values ('Pedro Gomes', 21);
insert tblCIDADE values ('Ponta Por�', 21);
insert tblCIDADE values ('Porto Murtinho', 21);
insert tblCIDADE values ('Ribas do Rio Pardo', 21);
insert tblCIDADE values ('Rio Brilhante', 21);
insert tblCIDADE values ('Rio Negro', 21);
insert tblCIDADE values ('Rio Verde de Mato Grosso', 21);
insert tblCIDADE values ('Rochedo', 21);
insert tblCIDADE values ('Santa Rita do Pardo', 21);
insert tblCIDADE values ('S�o Gabriel do Oeste', 21);
insert tblCIDADE values ('Sete Quedas', 21);
insert tblCIDADE values ('Selv�ria', 21);
insert tblCIDADE values ('Sidrol�ndia', 21);
insert tblCIDADE values ('Sonora', 21);
insert tblCIDADE values ('Tacuru', 21);
insert tblCIDADE values ('Taquarussu', 21);
insert tblCIDADE values ('Terenos', 21);
insert tblCIDADE values ('Tr�s Lagoas', 21);
insert tblCIDADE values ('Vicentina', 21);
insert tblCIDADE values ('Alta Floresta D''Oeste', 22);
insert tblCIDADE values ('Ariquemes', 22);
insert tblCIDADE values ('Cabixi', 22);
insert tblCIDADE values ('Cacoal', 22);
insert tblCIDADE values ('Cerejeiras', 22);
insert tblCIDADE values ('Colorado do Oeste', 22);
insert tblCIDADE values ('Corumbiara', 22);
insert tblCIDADE values ('Costa Marques', 22);
insert tblCIDADE values ('Espig�o D''Oeste', 22);
insert tblCIDADE values ('Guajar�-Mirim', 22);
insert tblCIDADE values ('Jaru', 22);
insert tblCIDADE values ('Ji-Paran�', 22);
insert tblCIDADE values ('Machadinho D''Oeste', 22);
insert tblCIDADE values ('Nova Brasil�ndia D''Oeste', 22);
insert tblCIDADE values ('Ouro Preto do Oeste', 22);
insert tblCIDADE values ('Pimenta Bueno', 22);
insert tblCIDADE values ('Porto Velho', 22);
insert tblCIDADE values ('Presidente M�dici', 22);
insert tblCIDADE values ('Rio Crespo', 22);
insert tblCIDADE values ('Rolim de Moura', 22);
insert tblCIDADE values ('Santa Luzia D''Oeste', 22);
insert tblCIDADE values ('Vilhena', 22);
insert tblCIDADE values ('S�o Miguel do Guapor�', 22);
insert tblCIDADE values ('Nova Mamor�', 22);
insert tblCIDADE values ('Alvorada D''Oeste', 22);
insert tblCIDADE values ('Alto Alegre dos Parecis', 22);
insert tblCIDADE values ('Alto Para�so', 22);
insert tblCIDADE values ('Buritis', 22);
insert tblCIDADE values ('Novo Horizonte do Oeste', 22);
insert tblCIDADE values ('Cacaul�ndia', 22);
insert tblCIDADE values ('Campo Novo de Rond�nia', 22);
insert tblCIDADE values ('Candeias do Jamari', 22);
insert tblCIDADE values ('Castanheiras', 22);
insert tblCIDADE values ('Chupinguaia', 22);
insert tblCIDADE values ('Cujubim', 22);
insert tblCIDADE values ('Governador Jorge Teixeira', 22);
insert tblCIDADE values ('Itapu� do Oeste', 22);
insert tblCIDADE values ('Ministro Andreazza', 22);
insert tblCIDADE values ('Mirante da Serra', 22);
insert tblCIDADE values ('Monte Negro', 22);
insert tblCIDADE values ('Nova Uni�o', 22);
insert tblCIDADE values ('Parecis', 22);
insert tblCIDADE values ('Pimenteiras do Oeste', 22);
insert tblCIDADE values ('Primavera de Rond�nia', 22);
insert tblCIDADE values ('S�o Felipe D''Oeste', 22);
insert tblCIDADE values ('S�o Francisco do Guapor�', 22);
insert tblCIDADE values ('Seringueiras', 22);
insert tblCIDADE values ('Teixeir�polis', 22);
insert tblCIDADE values ('Theobroma', 22);
insert tblCIDADE values ('Urup�', 22);
insert tblCIDADE values ('Vale do Anari', 22);
insert tblCIDADE values ('Vale do Para�so', 22);
insert tblCIDADE values ('Amajari', 23);
insert tblCIDADE values ('Alto Alegre', 23);
insert tblCIDADE values ('Boa Vista', 23);
insert tblCIDADE values ('Bonfim', 23);
insert tblCIDADE values ('Cant�', 23);
insert tblCIDADE values ('Caracara�', 23);
insert tblCIDADE values ('Caroebe', 23);
insert tblCIDADE values ('Iracema', 23);
insert tblCIDADE values ('Mucaja�', 23);
insert tblCIDADE values ('Normandia', 23);
insert tblCIDADE values ('Pacaraima', 23);
insert tblCIDADE values ('Rorain�polis', 23);
insert tblCIDADE values ('S�o Jo�o da Baliza', 23);
insert tblCIDADE values ('S�o Luiz', 23);
insert tblCIDADE values ('Uiramut�', 23);
insert tblCIDADE values ('Abdon Batista', 24);
insert tblCIDADE values ('Abelardo Luz', 24);
insert tblCIDADE values ('Agrol�ndia', 24);
insert tblCIDADE values ('Agron�mica', 24);
insert tblCIDADE values ('�gua Doce', 24);
insert tblCIDADE values ('�guas de Chapec�', 24);
insert tblCIDADE values ('�guas Frias', 24);
insert tblCIDADE values ('�guas Mornas', 24);
insert tblCIDADE values ('Alfredo Wagner', 24);
insert tblCIDADE values ('Alto Bela Vista', 24);
insert tblCIDADE values ('Anchieta', 24);
insert tblCIDADE values ('Angelina', 24);
insert tblCIDADE values ('Anita Garibaldi', 24);
insert tblCIDADE values ('Anit�polis', 24);
insert tblCIDADE values ('Ant�nio Carlos', 24);
insert tblCIDADE values ('Api�na', 24);
insert tblCIDADE values ('Arabut�', 24);
insert tblCIDADE values ('Araquari', 24);
insert tblCIDADE values ('Ararangu�', 24);
insert tblCIDADE values ('Armaz�m', 24);
insert tblCIDADE values ('Arroio Trinta', 24);
insert tblCIDADE values ('Arvoredo', 24);
insert tblCIDADE values ('Ascurra', 24);
insert tblCIDADE values ('Atalanta', 24);
insert tblCIDADE values ('Aurora', 24);
insert tblCIDADE values ('Balne�rio Arroio do Silva', 24);
insert tblCIDADE values ('Balne�rio Cambori�', 24);
insert tblCIDADE values ('Balne�rio Barra do Sul', 24);
insert tblCIDADE values ('Balne�rio Gaivota', 24);
insert tblCIDADE values ('Bandeirante', 24);
insert tblCIDADE values ('Barra Bonita', 24);
insert tblCIDADE values ('Barra Velha', 24);
insert tblCIDADE values ('Bela Vista do Toldo', 24);
insert tblCIDADE values ('Belmonte', 24);
insert tblCIDADE values ('Benedito Novo', 24);
insert tblCIDADE values ('Bigua�u', 24);
insert tblCIDADE values ('Blumenau', 24);
insert tblCIDADE values ('Bocaina do Sul', 24);
insert tblCIDADE values ('Bombinhas', 24);
insert tblCIDADE values ('Bom Jardim da Serra', 24);
insert tblCIDADE values ('Bom Jesus', 24);
insert tblCIDADE values ('Bom Jesus do Oeste', 24);
insert tblCIDADE values ('Bom Retiro', 24);
insert tblCIDADE values ('Botuver�', 24);
insert tblCIDADE values ('Bra�o do Norte', 24);
insert tblCIDADE values ('Bra�o do Trombudo', 24);
insert tblCIDADE values ('Brun�polis', 24);
insert tblCIDADE values ('Brusque', 24);
insert tblCIDADE values ('Ca�ador', 24);
insert tblCIDADE values ('Caibi', 24);
insert tblCIDADE values ('Calmon', 24);
insert tblCIDADE values ('Cambori�', 24);
insert tblCIDADE values ('Cap�o Alto', 24);
insert tblCIDADE values ('Campo Alegre', 24);
insert tblCIDADE values ('Campo Belo do Sul', 24);
insert tblCIDADE values ('Campo Er�', 24);
insert tblCIDADE values ('Campos Novos', 24);
insert tblCIDADE values ('Canelinha', 24);
insert tblCIDADE values ('Canoinhas', 24);
insert tblCIDADE values ('Capinzal', 24);
insert tblCIDADE values ('Capivari de Baixo', 24);
insert tblCIDADE values ('Catanduvas', 24);
insert tblCIDADE values ('Caxambu do Sul', 24);
insert tblCIDADE values ('Celso Ramos', 24);
insert tblCIDADE values ('Cerro Negro', 24);
insert tblCIDADE values ('Chapad�o do Lageado', 24);
insert tblCIDADE values ('Chapec�', 24);
insert tblCIDADE values ('Cocal do Sul', 24);
insert tblCIDADE values ('Conc�rdia', 24);
insert tblCIDADE values ('Cordilheira Alta', 24);
insert tblCIDADE values ('Coronel Freitas', 24);
insert tblCIDADE values ('Coronel Martins', 24);
insert tblCIDADE values ('Corup�', 24);
insert tblCIDADE values ('Correia Pinto', 24);
insert tblCIDADE values ('Crici�ma', 24);
insert tblCIDADE values ('Cunha Por�', 24);
insert tblCIDADE values ('Cunhata�', 24);
insert tblCIDADE values ('Curitibanos', 24);
insert tblCIDADE values ('Descanso', 24);
insert tblCIDADE values ('Dion�sio Cerqueira', 24);
insert tblCIDADE values ('Dona Emma', 24);
insert tblCIDADE values ('Doutor Pedrinho', 24);
insert tblCIDADE values ('Entre Rios', 24);
insert tblCIDADE values ('Ermo', 24);
insert tblCIDADE values ('Erval Velho', 24);
insert tblCIDADE values ('Faxinal dos Guedes', 24);
insert tblCIDADE values ('Flor do Sert�o', 24);
insert tblCIDADE values ('Florian�polis', 24);
insert tblCIDADE values ('Formosa do Sul', 24);
insert tblCIDADE values ('Forquilhinha', 24);
insert tblCIDADE values ('Fraiburgo', 24);
insert tblCIDADE values ('Frei Rog�rio', 24);
insert tblCIDADE values ('Galv�o', 24);
insert tblCIDADE values ('Garopaba', 24);
insert tblCIDADE values ('Garuva', 24);
insert tblCIDADE values ('Gaspar', 24);
insert tblCIDADE values ('Governador Celso Ramos', 24);
insert tblCIDADE values ('Gr�o Par�', 24);
insert tblCIDADE values ('Gravatal', 24);
insert tblCIDADE values ('Guabiruba', 24);
insert tblCIDADE values ('Guaraciaba', 24);
insert tblCIDADE values ('Guaramirim', 24);
insert tblCIDADE values ('Guaruj� do Sul', 24);
insert tblCIDADE values ('Guatamb�', 24);
insert tblCIDADE values ('Herval d''Oeste', 24);
insert tblCIDADE values ('Ibiam', 24);
insert tblCIDADE values ('Ibicar�', 24);
insert tblCIDADE values ('Ibirama', 24);
insert tblCIDADE values ('I�ara', 24);
insert tblCIDADE values ('Ilhota', 24);
insert tblCIDADE values ('Imaru�', 24);
insert tblCIDADE values ('Imbituba', 24);
insert tblCIDADE values ('Imbuia', 24);
insert tblCIDADE values ('Indaial', 24);
insert tblCIDADE values ('Iomer�', 24);
insert tblCIDADE values ('Ipira', 24);
insert tblCIDADE values ('Ipor� do Oeste', 24);
insert tblCIDADE values ('Ipua�u', 24);
insert tblCIDADE values ('Ipumirim', 24);
insert tblCIDADE values ('Iraceminha', 24);
insert tblCIDADE values ('Irani', 24);
insert tblCIDADE values ('Irati', 24);
insert tblCIDADE values ('Irine�polis', 24);
insert tblCIDADE values ('It�', 24);
insert tblCIDADE values ('Itai�polis', 24);
insert tblCIDADE values ('Itaja�', 24);
insert tblCIDADE values ('Itapema', 24);
insert tblCIDADE values ('Itapiranga', 24);
insert tblCIDADE values ('Itapo�', 24);
insert tblCIDADE values ('Ituporanga', 24);
insert tblCIDADE values ('Jabor�', 24);
insert tblCIDADE values ('Jacinto Machado', 24);
insert tblCIDADE values ('Jaguaruna', 24);
insert tblCIDADE values ('Jaragu� do Sul', 24);
insert tblCIDADE values ('Jardin�polis', 24);
insert tblCIDADE values ('Joa�aba', 24);
insert tblCIDADE values ('Joinville', 24);
insert tblCIDADE values ('Jos� Boiteux', 24);
insert tblCIDADE values ('Jupi�', 24);
insert tblCIDADE values ('Lacerd�polis', 24);
insert tblCIDADE values ('Lages', 24);
insert tblCIDADE values ('Laguna', 24);
insert tblCIDADE values ('Lajeado Grande', 24);
insert tblCIDADE values ('Laurentino', 24);
insert tblCIDADE values ('Lauro Muller', 24);
insert tblCIDADE values ('Lebon R�gis', 24);
insert tblCIDADE values ('Leoberto Leal', 24);
insert tblCIDADE values ('Lind�ia do Sul', 24);
insert tblCIDADE values ('Lontras', 24);
insert tblCIDADE values ('Luiz Alves', 24);
insert tblCIDADE values ('Luzerna', 24);
insert tblCIDADE values ('Macieira', 24);
insert tblCIDADE values ('Mafra', 24);
insert tblCIDADE values ('Major Gercino', 24);
insert tblCIDADE values ('Major Vieira', 24);
insert tblCIDADE values ('Maracaj�', 24);
insert tblCIDADE values ('Maravilha', 24);
insert tblCIDADE values ('Marema', 24);
insert tblCIDADE values ('Massaranduba', 24);
insert tblCIDADE values ('Matos Costa', 24);
insert tblCIDADE values ('Meleiro', 24);
insert tblCIDADE values ('Mirim Doce', 24);
insert tblCIDADE values ('Modelo', 24);
insert tblCIDADE values ('Monda�', 24);
insert tblCIDADE values ('Monte Carlo', 24);
insert tblCIDADE values ('Monte Castelo', 24);
insert tblCIDADE values ('Morro da Fuma�a', 24);
insert tblCIDADE values ('Morro Grande', 24);
insert tblCIDADE values ('Navegantes', 24);
insert tblCIDADE values ('Nova Erechim', 24);
insert tblCIDADE values ('Nova Itaberaba', 24);
insert tblCIDADE values ('Nova Trento', 24);
insert tblCIDADE values ('Nova Veneza', 24);
insert tblCIDADE values ('Novo Horizonte', 24);
insert tblCIDADE values ('Orleans', 24);
insert tblCIDADE values ('Otac�lio Costa', 24);
insert tblCIDADE values ('Ouro', 24);
insert tblCIDADE values ('Ouro Verde', 24);
insert tblCIDADE values ('Paial', 24);
insert tblCIDADE values ('Painel', 24);
insert tblCIDADE values ('Palho�a', 24);
insert tblCIDADE values ('Palma Sola', 24);
insert tblCIDADE values ('Palmeira', 24);
insert tblCIDADE values ('Palmitos', 24);
insert tblCIDADE values ('Papanduva', 24);
insert tblCIDADE values ('Para�so', 24);
insert tblCIDADE values ('Passo de Torres', 24);
insert tblCIDADE values ('Passos Maia', 24);
insert tblCIDADE values ('Paulo Lopes', 24);
insert tblCIDADE values ('Pedras Grandes', 24);
insert tblCIDADE values ('Penha', 24);
insert tblCIDADE values ('Peritiba', 24);
insert tblCIDADE values ('Petrol�ndia', 24);
insert tblCIDADE values ('Balne�rio Pi�arras', 24);
insert tblCIDADE values ('Pinhalzinho', 24);
insert tblCIDADE values ('Pinheiro Preto', 24);
insert tblCIDADE values ('Piratuba', 24);
insert tblCIDADE values ('Planalto Alegre', 24);
insert tblCIDADE values ('Pomerode', 24);
insert tblCIDADE values ('Ponte Alta', 24);
insert tblCIDADE values ('Ponte Alta do Norte', 24);
insert tblCIDADE values ('Ponte Serrada', 24);
insert tblCIDADE values ('Porto Belo', 24);
insert tblCIDADE values ('Porto Uni�o', 24);
insert tblCIDADE values ('Pouso Redondo', 24);
insert tblCIDADE values ('Praia Grande', 24);
insert tblCIDADE values ('Presidente Castello Branco', 24);
insert tblCIDADE values ('Presidente Get�lio', 24);
insert tblCIDADE values ('Presidente Nereu', 24);
insert tblCIDADE values ('Princesa', 24);
insert tblCIDADE values ('Quilombo', 24);
insert tblCIDADE values ('Rancho Queimado', 24);
insert tblCIDADE values ('Rio das Antas', 24);
insert tblCIDADE values ('Rio do Campo', 24);
insert tblCIDADE values ('Rio do Oeste', 24);
insert tblCIDADE values ('Rio dos Cedros', 24);
insert tblCIDADE values ('Rio do Sul', 24);
insert tblCIDADE values ('Rio Fortuna', 24);
insert tblCIDADE values ('Rio Negrinho', 24);
insert tblCIDADE values ('Rio Rufino', 24);
insert tblCIDADE values ('Riqueza', 24);
insert tblCIDADE values ('Rodeio', 24);
insert tblCIDADE values ('Romel�ndia', 24);
insert tblCIDADE values ('Salete', 24);
insert tblCIDADE values ('Saltinho', 24);
insert tblCIDADE values ('Salto Veloso', 24);
insert tblCIDADE values ('Sang�o', 24);
insert tblCIDADE values ('Santa Cec�lia', 24);
insert tblCIDADE values ('Santa Helena', 24);
insert tblCIDADE values ('Santa Rosa de Lima', 24);
insert tblCIDADE values ('Santa Rosa do Sul', 24);
insert tblCIDADE values ('Santa Terezinha', 24);
insert tblCIDADE values ('Santa Terezinha do Progresso', 24);
insert tblCIDADE values ('Santiago do Sul', 24);
insert tblCIDADE values ('Santo Amaro da Imperatriz', 24);
insert tblCIDADE values ('S�o Bernardino', 24);
insert tblCIDADE values ('S�o Bento do Sul', 24);
insert tblCIDADE values ('S�o Bonif�cio', 24);
insert tblCIDADE values ('S�o Carlos', 24);
insert tblCIDADE values ('S�o Cristov�o do Sul', 24);
insert tblCIDADE values ('S�o Domingos', 24);
insert tblCIDADE values ('S�o Francisco do Sul', 24);
insert tblCIDADE values ('S�o Jo�o do Oeste', 24);
insert tblCIDADE values ('S�o Jo�o Batista', 24);
insert tblCIDADE values ('S�o Jo�o do Itaperi�', 24);
insert tblCIDADE values ('S�o Jo�o do Sul', 24);
insert tblCIDADE values ('S�o Joaquim', 24);
insert tblCIDADE values ('S�o Jos�', 24);
insert tblCIDADE values ('S�o Jos� do Cedro', 24);
insert tblCIDADE values ('S�o Jos� do Cerrito', 24);
insert tblCIDADE values ('S�o Louren�o do Oeste', 24);
insert tblCIDADE values ('S�o Ludgero', 24);
insert tblCIDADE values ('S�o Martinho', 24);
insert tblCIDADE values ('S�o Miguel da Boa Vista', 24);
insert tblCIDADE values ('S�o Miguel do Oeste', 24);
insert tblCIDADE values ('S�o Pedro de Alc�ntara', 24);
insert tblCIDADE values ('Saudades', 24);
insert tblCIDADE values ('Schroeder', 24);
insert tblCIDADE values ('Seara', 24);
insert tblCIDADE values ('Serra Alta', 24);
insert tblCIDADE values ('Sider�polis', 24);
insert tblCIDADE values ('Sombrio', 24);
insert tblCIDADE values ('Sul Brasil', 24);
insert tblCIDADE values ('Tai�', 24);
insert tblCIDADE values ('Tangar�', 24);
insert tblCIDADE values ('Tigrinhos', 24);
insert tblCIDADE values ('Tijucas', 24);
insert tblCIDADE values ('Timb� do Sul', 24);
insert tblCIDADE values ('Timb�', 24);
insert tblCIDADE values ('Timb� Grande', 24);
insert tblCIDADE values ('Tr�s Barras', 24);
insert tblCIDADE values ('Treviso', 24);
insert tblCIDADE values ('Treze de Maio', 24);
insert tblCIDADE values ('Treze T�lias', 24);
insert tblCIDADE values ('Trombudo Central', 24);
insert tblCIDADE values ('Tubar�o', 24);
insert tblCIDADE values ('Tun�polis', 24);
insert tblCIDADE values ('Turvo', 24);
insert tblCIDADE values ('Uni�o do Oeste', 24);
insert tblCIDADE values ('Urubici', 24);
insert tblCIDADE values ('Urupema', 24);
insert tblCIDADE values ('Urussanga', 24);
insert tblCIDADE values ('Varge�o', 24);
insert tblCIDADE values ('Vargem', 24);
insert tblCIDADE values ('Vargem Bonita', 24);
insert tblCIDADE values ('Vidal Ramos', 24);
insert tblCIDADE values ('Videira', 24);
insert tblCIDADE values ('Vitor Meireles', 24);
insert tblCIDADE values ('Witmarsum', 24);
insert tblCIDADE values ('Xanxer�', 24);
insert tblCIDADE values ('Xavantina', 24);
insert tblCIDADE values ('Xaxim', 24);
insert tblCIDADE values ('Zort�a', 24);
insert tblCIDADE values ('Adamantina', 25);
insert tblCIDADE values ('Adolfo', 25);
insert tblCIDADE values ('Agua�', 25);
insert tblCIDADE values ('�guas da Prata', 25);
insert tblCIDADE values ('�guas de Lind�ia', 25);
insert tblCIDADE values ('�guas de Santa B�rbara', 25);
insert tblCIDADE values ('�guas de S�o Pedro', 25);
insert tblCIDADE values ('Agudos', 25);
insert tblCIDADE values ('Alambari', 25);
insert tblCIDADE values ('Alfredo Marcondes', 25);
insert tblCIDADE values ('Altair', 25);
insert tblCIDADE values ('Altin�polis', 25);
insert tblCIDADE values ('Alto Alegre', 25);
insert tblCIDADE values ('Alum�nio', 25);
insert tblCIDADE values ('�lvares Florence', 25);
insert tblCIDADE values ('�lvares Machado', 25);
insert tblCIDADE values ('�lvaro de Carvalho', 25);
insert tblCIDADE values ('Alvinl�ndia', 25);
insert tblCIDADE values ('Americana', 25);
insert tblCIDADE values ('Am�rico Brasiliense', 25);
insert tblCIDADE values ('Am�rico de Campos', 25);
insert tblCIDADE values ('Amparo', 25);
insert tblCIDADE values ('Anal�ndia', 25);
insert tblCIDADE values ('Andradina', 25);
insert tblCIDADE values ('Angatuba', 25);
insert tblCIDADE values ('Anhembi', 25);
insert tblCIDADE values ('Anhumas', 25);
insert tblCIDADE values ('Aparecida', 25);
insert tblCIDADE values ('Aparecida d''Oeste', 25);
insert tblCIDADE values ('Apia�', 25);
insert tblCIDADE values ('Ara�ariguama', 25);
insert tblCIDADE values ('Ara�atuba', 25);
insert tblCIDADE values ('Ara�oiaba da Serra', 25);
insert tblCIDADE values ('Aramina', 25);
insert tblCIDADE values ('Arandu', 25);
insert tblCIDADE values ('Arape�', 25);
insert tblCIDADE values ('Araraquara', 25);
insert tblCIDADE values ('Araras', 25);
insert tblCIDADE values ('Arco-�ris', 25);
insert tblCIDADE values ('Arealva', 25);
insert tblCIDADE values ('Areias', 25);
insert tblCIDADE values ('Arei�polis', 25);
insert tblCIDADE values ('Ariranha', 25);
insert tblCIDADE values ('Artur Nogueira', 25);
insert tblCIDADE values ('Aruj�', 25);
insert tblCIDADE values ('Asp�sia', 25);
insert tblCIDADE values ('Assis', 25);
insert tblCIDADE values ('Atibaia', 25);
insert tblCIDADE values ('Auriflama', 25);
insert tblCIDADE values ('Ava�', 25);
insert tblCIDADE values ('Avanhandava', 25);
insert tblCIDADE values ('Avar�', 25);
insert tblCIDADE values ('Bady Bassitt', 25);
insert tblCIDADE values ('Balbinos', 25);
insert tblCIDADE values ('B�lsamo', 25);
insert tblCIDADE values ('Bananal', 25);
insert tblCIDADE values ('Bar�o de Antonina', 25);
insert tblCIDADE values ('Barbosa', 25);
insert tblCIDADE values ('Bariri', 25);
insert tblCIDADE values ('Barra Bonita', 25);
insert tblCIDADE values ('Barra do Chap�u', 25);
insert tblCIDADE values ('Barra do Turvo', 25);
insert tblCIDADE values ('Barretos', 25);
insert tblCIDADE values ('Barrinha', 25);
insert tblCIDADE values ('Barueri', 25);
insert tblCIDADE values ('Bastos', 25);
insert tblCIDADE values ('Batatais', 25);
insert tblCIDADE values ('Bauru', 25);
insert tblCIDADE values ('Bebedouro', 25);
insert tblCIDADE values ('Bento de Abreu', 25);
insert tblCIDADE values ('Bernardino de Campos', 25);
insert tblCIDADE values ('Bertioga', 25);
insert tblCIDADE values ('Bilac', 25);
insert tblCIDADE values ('Birigui', 25);
insert tblCIDADE values ('Biritiba-Mirim', 25);
insert tblCIDADE values ('Boa Esperan�a do Sul', 25);
insert tblCIDADE values ('Bocaina', 25);
insert tblCIDADE values ('Bofete', 25);
insert tblCIDADE values ('Boituva', 25);
insert tblCIDADE values ('Bom Jesus dos Perd�es', 25);
insert tblCIDADE values ('Bom Sucesso de Itarar�', 25);
insert tblCIDADE values ('Bor�', 25);
insert tblCIDADE values ('Borac�ia', 25);
insert tblCIDADE values ('Borborema', 25);
insert tblCIDADE values ('Borebi', 25);
insert tblCIDADE values ('Botucatu', 25);
insert tblCIDADE values ('Bragan�a Paulista', 25);
insert tblCIDADE values ('Bra�na', 25);
insert tblCIDADE values ('Brejo Alegre', 25);
insert tblCIDADE values ('Brodowski', 25);
insert tblCIDADE values ('Brotas', 25);
insert tblCIDADE values ('Buri', 25);
insert tblCIDADE values ('Buritama', 25);
insert tblCIDADE values ('Buritizal', 25);
insert tblCIDADE values ('Cabr�lia Paulista', 25);
insert tblCIDADE values ('Cabre�va', 25);
insert tblCIDADE values ('Ca�apava', 25);
insert tblCIDADE values ('Cachoeira Paulista', 25);
insert tblCIDADE values ('Caconde', 25);
insert tblCIDADE values ('Cafel�ndia', 25);
insert tblCIDADE values ('Caiabu', 25);
insert tblCIDADE values ('Caieiras', 25);
insert tblCIDADE values ('Caiu�', 25);
insert tblCIDADE values ('Cajamar', 25);
insert tblCIDADE values ('Cajati', 25);
insert tblCIDADE values ('Cajobi', 25);
insert tblCIDADE values ('Cajuru', 25);
insert tblCIDADE values ('Campina do Monte Alegre', 25);
insert tblCIDADE values ('Campinas', 25);
insert tblCIDADE values ('Campo Limpo Paulista', 25);
insert tblCIDADE values ('Campos do Jord�o', 25);
insert tblCIDADE values ('Campos Novos Paulista', 25);
insert tblCIDADE values ('Canan�ia', 25);
insert tblCIDADE values ('Canas', 25);
insert tblCIDADE values ('C�ndido Mota', 25);
insert tblCIDADE values ('C�ndido Rodrigues', 25);
insert tblCIDADE values ('Canitar', 25);
insert tblCIDADE values ('Cap�o Bonito', 25);
insert tblCIDADE values ('Capela do Alto', 25);
insert tblCIDADE values ('Capivari', 25);
insert tblCIDADE values ('Caraguatatuba', 25);
insert tblCIDADE values ('Carapicu�ba', 25);
insert tblCIDADE values ('Cardoso', 25);
insert tblCIDADE values ('Casa Branca', 25);
insert tblCIDADE values ('C�ssia dos Coqueiros', 25);
insert tblCIDADE values ('Castilho', 25);
insert tblCIDADE values ('Catanduva', 25);
insert tblCIDADE values ('Catigu�', 25);
insert tblCIDADE values ('Cedral', 25);
insert tblCIDADE values ('Cerqueira C�sar', 25);
insert tblCIDADE values ('Cerquilho', 25);
insert tblCIDADE values ('Ces�rio Lange', 25);
insert tblCIDADE values ('Charqueada', 25);
insert tblCIDADE values ('Clementina', 25);
insert tblCIDADE values ('Colina', 25);
insert tblCIDADE values ('Col�mbia', 25);
insert tblCIDADE values ('Conchal', 25);
insert tblCIDADE values ('Conchas', 25);
insert tblCIDADE values ('Cordeir�polis', 25);
insert tblCIDADE values ('Coroados', 25);
insert tblCIDADE values ('Coronel Macedo', 25);
insert tblCIDADE values ('Corumbata�', 25);
insert tblCIDADE values ('Cosm�polis', 25);
insert tblCIDADE values ('Cosmorama', 25);
insert tblCIDADE values ('Cotia', 25);
insert tblCIDADE values ('Cravinhos', 25);
insert tblCIDADE values ('Cristais Paulista', 25);
insert tblCIDADE values ('Cruz�lia', 25);
insert tblCIDADE values ('Cruzeiro', 25);
insert tblCIDADE values ('Cubat�o', 25);
insert tblCIDADE values ('Cunha', 25);
insert tblCIDADE values ('Descalvado', 25);
insert tblCIDADE values ('Diadema', 25);
insert tblCIDADE values ('Dirce Reis', 25);
insert tblCIDADE values ('Divinol�ndia', 25);
insert tblCIDADE values ('Dobrada', 25);
insert tblCIDADE values ('Dois C�rregos', 25);
insert tblCIDADE values ('Dolcin�polis', 25);
insert tblCIDADE values ('Dourado', 25);
insert tblCIDADE values ('Dracena', 25);
insert tblCIDADE values ('Duartina', 25);
insert tblCIDADE values ('Dumont', 25);
insert tblCIDADE values ('Echapor�', 25);
insert tblCIDADE values ('Eldorado', 25);
insert tblCIDADE values ('Elias Fausto', 25);
insert tblCIDADE values ('Elisi�rio', 25);
insert tblCIDADE values ('Emba�ba', 25);
insert tblCIDADE values ('Embu das Artes', 25);
insert tblCIDADE values ('Embu-Gua�u', 25);
insert tblCIDADE values ('Emilian�polis', 25);
insert tblCIDADE values ('Engenheiro Coelho', 25);
insert tblCIDADE values ('Esp�rito Santo do Pinhal', 25);
insert tblCIDADE values ('Esp�rito Santo do Turvo', 25);
insert tblCIDADE values ('Estrela d''Oeste', 25);
insert tblCIDADE values ('Estrela do Norte', 25);
insert tblCIDADE values ('Euclides da Cunha Paulista', 25);
insert tblCIDADE values ('Fartura', 25);
insert tblCIDADE values ('Fernand�polis', 25);
insert tblCIDADE values ('Fernando Prestes', 25);
insert tblCIDADE values ('Fern�o', 25);
insert tblCIDADE values ('Ferraz de Vasconcelos', 25);
insert tblCIDADE values ('Flora Rica', 25);
insert tblCIDADE values ('Floreal', 25);
insert tblCIDADE values ('Fl�rida Paulista', 25);
insert tblCIDADE values ('Flor�nia', 25);
insert tblCIDADE values ('Franca', 25);
insert tblCIDADE values ('Francisco Morato', 25);
insert tblCIDADE values ('Franco da Rocha', 25);
insert tblCIDADE values ('Gabriel Monteiro', 25);
insert tblCIDADE values ('G�lia', 25);
insert tblCIDADE values ('Gar�a', 25);
insert tblCIDADE values ('Gast�o Vidigal', 25);
insert tblCIDADE values ('Gavi�o Peixoto', 25);
insert tblCIDADE values ('General Salgado', 25);
insert tblCIDADE values ('Getulina', 25);
insert tblCIDADE values ('Glic�rio', 25);
insert tblCIDADE values ('Guai�ara', 25);
insert tblCIDADE values ('Guaimb�', 25);
insert tblCIDADE values ('Gua�ra', 25);
insert tblCIDADE values ('Guapia�u', 25);
insert tblCIDADE values ('Guapiara', 25);
insert tblCIDADE values ('Guar�', 25);
insert tblCIDADE values ('Guara�a�', 25);
insert tblCIDADE values ('Guaraci', 25);
insert tblCIDADE values ('Guarani d''Oeste', 25);
insert tblCIDADE values ('Guarant�', 25);
insert tblCIDADE values ('Guararapes', 25);
insert tblCIDADE values ('Guararema', 25);
insert tblCIDADE values ('Guaratinguet�', 25);
insert tblCIDADE values ('Guare�', 25);
insert tblCIDADE values ('Guariba', 25);
insert tblCIDADE values ('Guaruj�', 25);
insert tblCIDADE values ('Guarulhos', 25);
insert tblCIDADE values ('Guatapar�', 25);
insert tblCIDADE values ('Guzol�ndia', 25);
insert tblCIDADE values ('Hercul�ndia', 25);
insert tblCIDADE values ('Holambra', 25);
insert tblCIDADE values ('Hortol�ndia', 25);
insert tblCIDADE values ('Iacanga', 25);
insert tblCIDADE values ('Iacri', 25);
insert tblCIDADE values ('Iaras', 25);
insert tblCIDADE values ('Ibat�', 25);
insert tblCIDADE values ('Ibir�', 25);
insert tblCIDADE values ('Ibirarema', 25);
insert tblCIDADE values ('Ibitinga', 25);
insert tblCIDADE values ('Ibi�na', 25);
insert tblCIDADE values ('Ic�m', 25);
insert tblCIDADE values ('Iep�', 25);
insert tblCIDADE values ('Igara�u do Tiet�', 25);
insert tblCIDADE values ('Igarapava', 25);
insert tblCIDADE values ('Igarat�', 25);
insert tblCIDADE values ('Iguape', 25);
insert tblCIDADE values ('Ilhabela', 25);
insert tblCIDADE values ('Ilha Comprida', 25);
insert tblCIDADE values ('Ilha Solteira', 25);
insert tblCIDADE values ('Indaiatuba', 25);
insert tblCIDADE values ('Indiana', 25);
insert tblCIDADE values ('Indiapor�', 25);
insert tblCIDADE values ('In�bia Paulista', 25);
insert tblCIDADE values ('Ipaussu', 25);
insert tblCIDADE values ('Iper�', 25);
insert tblCIDADE values ('Ipe�na', 25);
insert tblCIDADE values ('Ipigu�', 25);
insert tblCIDADE values ('Iporanga', 25);
insert tblCIDADE values ('Ipu�', 25);
insert tblCIDADE values ('Iracem�polis', 25);
insert tblCIDADE values ('Irapu�', 25);
insert tblCIDADE values ('Irapuru', 25);
insert tblCIDADE values ('Itaber�', 25);
insert tblCIDADE values ('Ita�', 25);
insert tblCIDADE values ('Itajobi', 25);
insert tblCIDADE values ('Itaju', 25);
insert tblCIDADE values ('Itanha�m', 25);
insert tblCIDADE values ('Ita�ca', 25);
insert tblCIDADE values ('Itapecerica da Serra', 25);
insert tblCIDADE values ('Itapetininga', 25);
insert tblCIDADE values ('Itapeva', 25);
insert tblCIDADE values ('Itapevi', 25);
insert tblCIDADE values ('Itapira', 25);
insert tblCIDADE values ('Itapirapu� Paulista', 25);
insert tblCIDADE values ('It�polis', 25);
insert tblCIDADE values ('Itaporanga', 25);
insert tblCIDADE values ('Itapu�', 25);
insert tblCIDADE values ('Itapura', 25);
insert tblCIDADE values ('Itaquaquecetuba', 25);
insert tblCIDADE values ('Itarar�', 25);
insert tblCIDADE values ('Itariri', 25);
insert tblCIDADE values ('Itatiba', 25);
insert tblCIDADE values ('Itatinga', 25);
insert tblCIDADE values ('Itirapina', 25);
insert tblCIDADE values ('Itirapu�', 25);
insert tblCIDADE values ('Itobi', 25);
insert tblCIDADE values ('Itu', 25);
insert tblCIDADE values ('Itupeva', 25);
insert tblCIDADE values ('Ituverava', 25);
insert tblCIDADE values ('Jaborandi', 25);
insert tblCIDADE values ('Jaboticabal', 25);
insert tblCIDADE values ('Jacare�', 25);
insert tblCIDADE values ('Jaci', 25);
insert tblCIDADE values ('Jacupiranga', 25);
insert tblCIDADE values ('Jaguari�na', 25);
insert tblCIDADE values ('Jales', 25);
insert tblCIDADE values ('Jambeiro', 25);
insert tblCIDADE values ('Jandira', 25);
insert tblCIDADE values ('Jardin�polis', 25);
insert tblCIDADE values ('Jarinu', 25);
insert tblCIDADE values ('Ja�', 25);
insert tblCIDADE values ('Jeriquara', 25);
insert tblCIDADE values ('Joan�polis', 25);
insert tblCIDADE values ('Jo�o Ramalho', 25);
insert tblCIDADE values ('Jos� Bonif�cio', 25);
insert tblCIDADE values ('J�lio Mesquita', 25);
insert tblCIDADE values ('Jumirim', 25);
insert tblCIDADE values ('Jundia�', 25);
insert tblCIDADE values ('Junqueir�polis', 25);
insert tblCIDADE values ('Juqui�', 25);
insert tblCIDADE values ('Juquitiba', 25);
insert tblCIDADE values ('Lagoinha', 25);
insert tblCIDADE values ('Laranjal Paulista', 25);
insert tblCIDADE values ('Lav�nia', 25);
insert tblCIDADE values ('Lavrinhas', 25);
insert tblCIDADE values ('Leme', 25);
insert tblCIDADE values ('Len��is Paulista', 25);
insert tblCIDADE values ('Limeira', 25);
insert tblCIDADE values ('Lind�ia', 25);
insert tblCIDADE values ('Lins', 25);
insert tblCIDADE values ('Lorena', 25);
insert tblCIDADE values ('Lourdes', 25);
insert tblCIDADE values ('Louveira', 25);
insert tblCIDADE values ('Luc�lia', 25);
insert tblCIDADE values ('Lucian�polis', 25);
insert tblCIDADE values ('Lu�s Ant�nio', 25);
insert tblCIDADE values ('Luizi�nia', 25);
insert tblCIDADE values ('Lup�rcio', 25);
insert tblCIDADE values ('Lut�cia', 25);
insert tblCIDADE values ('Macatuba', 25);
insert tblCIDADE values ('Macaubal', 25);
insert tblCIDADE values ('Maced�nia', 25);
insert tblCIDADE values ('Magda', 25);
insert tblCIDADE values ('Mairinque', 25);
insert tblCIDADE values ('Mairipor�', 25);
insert tblCIDADE values ('Manduri', 25);
insert tblCIDADE values ('Marab� Paulista', 25);
insert tblCIDADE values ('Maraca�', 25);
insert tblCIDADE values ('Marapoama', 25);
insert tblCIDADE values ('Mari�polis', 25);
insert tblCIDADE values ('Mar�lia', 25);
insert tblCIDADE values ('Marin�polis', 25);
insert tblCIDADE values ('Martin�polis', 25);
insert tblCIDADE values ('Mat�o', 25);
insert tblCIDADE values ('Mau�', 25);
insert tblCIDADE values ('Mendon�a', 25);
insert tblCIDADE values ('Meridiano', 25);
insert tblCIDADE values ('Mes�polis', 25);
insert tblCIDADE values ('Miguel�polis', 25);
insert tblCIDADE values ('Mineiros do Tiet�', 25);
insert tblCIDADE values ('Miracatu', 25);
insert tblCIDADE values ('Mira Estrela', 25);
insert tblCIDADE values ('Mirand�polis', 25);
insert tblCIDADE values ('Mirante do Paranapanema', 25);
insert tblCIDADE values ('Mirassol', 25);
insert tblCIDADE values ('Mirassol�ndia', 25);
insert tblCIDADE values ('Mococa', 25);
insert tblCIDADE values ('Mogi das Cruzes', 25);
insert tblCIDADE values ('Mogi Gua�u', 25);
insert tblCIDADE values ('Moji Mirim', 25);
insert tblCIDADE values ('Mombuca', 25);
insert tblCIDADE values ('Mon��es', 25);
insert tblCIDADE values ('Mongagu�', 25);
insert tblCIDADE values ('Monte Alegre do Sul', 25);
insert tblCIDADE values ('Monte Alto', 25);
insert tblCIDADE values ('Monte Apraz�vel', 25);
insert tblCIDADE values ('Monte Azul Paulista', 25);
insert tblCIDADE values ('Monte Castelo', 25);
insert tblCIDADE values ('Monteiro Lobato', 25);
insert tblCIDADE values ('Monte Mor', 25);
insert tblCIDADE values ('Morro Agudo', 25);
insert tblCIDADE values ('Morungaba', 25);
insert tblCIDADE values ('Motuca', 25);
insert tblCIDADE values ('Murutinga do Sul', 25);
insert tblCIDADE values ('Nantes', 25);
insert tblCIDADE values ('Narandiba', 25);
insert tblCIDADE values ('Natividade da Serra', 25);
insert tblCIDADE values ('Nazar� Paulista', 25);
insert tblCIDADE values ('Neves Paulista', 25);
insert tblCIDADE values ('Nhandeara', 25);
insert tblCIDADE values ('Nipo�', 25);
insert tblCIDADE values ('Nova Alian�a', 25);
insert tblCIDADE values ('Nova Campina', 25);
insert tblCIDADE values ('Nova Cana� Paulista', 25);
insert tblCIDADE values ('Nova Castilho', 25);
insert tblCIDADE values ('Nova Europa', 25);
insert tblCIDADE values ('Nova Granada', 25);
insert tblCIDADE values ('Nova Guataporanga', 25);
insert tblCIDADE values ('Nova Independ�ncia', 25);
insert tblCIDADE values ('Novais', 25);
insert tblCIDADE values ('Nova Luzit�nia', 25);
insert tblCIDADE values ('Nova Odessa', 25);
insert tblCIDADE values ('Novo Horizonte', 25);
insert tblCIDADE values ('Nuporanga', 25);
insert tblCIDADE values ('Ocau�u', 25);
insert tblCIDADE values ('�leo', 25);
insert tblCIDADE values ('Ol�mpia', 25);
insert tblCIDADE values ('Onda Verde', 25);
insert tblCIDADE values ('Oriente', 25);
insert tblCIDADE values ('Orindi�va', 25);
insert tblCIDADE values ('Orl�ndia', 25);
insert tblCIDADE values ('Osasco', 25);
insert tblCIDADE values ('Oscar Bressane', 25);
insert tblCIDADE values ('Osvaldo Cruz', 25);
insert tblCIDADE values ('Ourinhos', 25);
insert tblCIDADE values ('Ouroeste', 25);
insert tblCIDADE values ('Ouro Verde', 25);
insert tblCIDADE values ('Pacaembu', 25);
insert tblCIDADE values ('Palestina', 25);
insert tblCIDADE values ('Palmares Paulista', 25);
insert tblCIDADE values ('Palmeira d''Oeste', 25);
insert tblCIDADE values ('Palmital', 25);
insert tblCIDADE values ('Panorama', 25);
insert tblCIDADE values ('Paragua�u Paulista', 25);
insert tblCIDADE values ('Paraibuna', 25);
insert tblCIDADE values ('Para�so', 25);
insert tblCIDADE values ('Paranapanema', 25);
insert tblCIDADE values ('Paranapu�', 25);
insert tblCIDADE values ('Parapu�', 25);
insert tblCIDADE values ('Pardinho', 25);
insert tblCIDADE values ('Pariquera-A�u', 25);
insert tblCIDADE values ('Parisi', 25);
insert tblCIDADE values ('Patroc�nio Paulista', 25);
insert tblCIDADE values ('Paulic�ia', 25);
insert tblCIDADE values ('Paul�nia', 25);
insert tblCIDADE values ('Paulist�nia', 25);
insert tblCIDADE values ('Paulo de Faria', 25);
insert tblCIDADE values ('Pederneiras', 25);
insert tblCIDADE values ('Pedra Bela', 25);
insert tblCIDADE values ('Pedran�polis', 25);
insert tblCIDADE values ('Pedregulho', 25);
insert tblCIDADE values ('Pedreira', 25);
insert tblCIDADE values ('Pedrinhas Paulista', 25);
insert tblCIDADE values ('Pedro de Toledo', 25);
insert tblCIDADE values ('Pen�polis', 25);
insert tblCIDADE values ('Pereira Barreto', 25);
insert tblCIDADE values ('Pereiras', 25);
insert tblCIDADE values ('Peru�be', 25);
insert tblCIDADE values ('Piacatu', 25);
insert tblCIDADE values ('Piedade', 25);
insert tblCIDADE values ('Pilar do Sul', 25);
insert tblCIDADE values ('Pindamonhangaba', 25);
insert tblCIDADE values ('Pindorama', 25);
insert tblCIDADE values ('Pinhalzinho', 25);
insert tblCIDADE values ('Piquerobi', 25);
insert tblCIDADE values ('Piquete', 25);
insert tblCIDADE values ('Piracaia', 25);
insert tblCIDADE values ('Piracicaba', 25);
insert tblCIDADE values ('Piraju', 25);
insert tblCIDADE values ('Piraju�', 25);
insert tblCIDADE values ('Pirangi', 25);
insert tblCIDADE values ('Pirapora do Bom Jesus', 25);
insert tblCIDADE values ('Pirapozinho', 25);
insert tblCIDADE values ('Pirassununga', 25);
insert tblCIDADE values ('Piratininga', 25);
insert tblCIDADE values ('Pitangueiras', 25);
insert tblCIDADE values ('Planalto', 25);
insert tblCIDADE values ('Platina', 25);
insert tblCIDADE values ('Po�', 25);
insert tblCIDADE values ('Poloni', 25);
insert tblCIDADE values ('Pomp�ia', 25);
insert tblCIDADE values ('Ponga�', 25);
insert tblCIDADE values ('Pontal', 25);
insert tblCIDADE values ('Pontalinda', 25);
insert tblCIDADE values ('Pontes Gestal', 25);
insert tblCIDADE values ('Populina', 25);
insert tblCIDADE values ('Porangaba', 25);
insert tblCIDADE values ('Porto Feliz', 25);
insert tblCIDADE values ('Porto Ferreira', 25);
insert tblCIDADE values ('Potim', 25);
insert tblCIDADE values ('Potirendaba', 25);
insert tblCIDADE values ('Pracinha', 25);
insert tblCIDADE values ('Prad�polis', 25);
insert tblCIDADE values ('Praia Grande', 25);
insert tblCIDADE values ('Prat�nia', 25);
insert tblCIDADE values ('Presidente Alves', 25);
insert tblCIDADE values ('Presidente Bernardes', 25);
insert tblCIDADE values ('Presidente Epit�cio', 25);
insert tblCIDADE values ('Presidente Prudente', 25);
insert tblCIDADE values ('Presidente Venceslau', 25);
insert tblCIDADE values ('Promiss�o', 25);
insert tblCIDADE values ('Quadra', 25);
insert tblCIDADE values ('Quat�', 25);
insert tblCIDADE values ('Queiroz', 25);
insert tblCIDADE values ('Queluz', 25);
insert tblCIDADE values ('Quintana', 25);
insert tblCIDADE values ('Rafard', 25);
insert tblCIDADE values ('Rancharia', 25);
insert tblCIDADE values ('Reden��o da Serra', 25);
insert tblCIDADE values ('Regente Feij�', 25);
insert tblCIDADE values ('Regin�polis', 25);
insert tblCIDADE values ('Registro', 25);
insert tblCIDADE values ('Restinga', 25);
insert tblCIDADE values ('Ribeira', 25);
insert tblCIDADE values ('Ribeir�o Bonito', 25);
insert tblCIDADE values ('Ribeir�o Branco', 25);
insert tblCIDADE values ('Ribeir�o Corrente', 25);
insert tblCIDADE values ('Ribeir�o do Sul', 25);
insert tblCIDADE values ('Ribeir�o dos �ndios', 25);
insert tblCIDADE values ('Ribeir�o Grande', 25);
insert tblCIDADE values ('Ribeir�o Pires', 25);
insert tblCIDADE values ('Ribeir�o Preto', 25);
insert tblCIDADE values ('Riversul', 25);
insert tblCIDADE values ('Rifaina', 25);
insert tblCIDADE values ('Rinc�o', 25);
insert tblCIDADE values ('Rin�polis', 25);
insert tblCIDADE values ('Rio Claro', 25);
insert tblCIDADE values ('Rio das Pedras', 25);
insert tblCIDADE values ('Rio Grande da Serra', 25);
insert tblCIDADE values ('Riol�ndia', 25);
insert tblCIDADE values ('Rosana', 25);
insert tblCIDADE values ('Roseira', 25);
insert tblCIDADE values ('Rubi�cea', 25);
insert tblCIDADE values ('Rubin�ia', 25);
insert tblCIDADE values ('Sabino', 25);
insert tblCIDADE values ('Sagres', 25);
insert tblCIDADE values ('Sales', 25);
insert tblCIDADE values ('Sales Oliveira', 25);
insert tblCIDADE values ('Sales�polis', 25);
insert tblCIDADE values ('Salmour�o', 25);
insert tblCIDADE values ('Saltinho', 25);
insert tblCIDADE values ('Salto', 25);
insert tblCIDADE values ('Salto de Pirapora', 25);
insert tblCIDADE values ('Salto Grande', 25);
insert tblCIDADE values ('Sandovalina', 25);
insert tblCIDADE values ('Santa Ad�lia', 25);
insert tblCIDADE values ('Santa Albertina', 25);
insert tblCIDADE values ('Santa B�rbara d''Oeste', 25);
insert tblCIDADE values ('Santa Branca', 25);
insert tblCIDADE values ('Santa Clara d''Oeste', 25);
insert tblCIDADE values ('Santa Cruz da Concei��o', 25);
insert tblCIDADE values ('Santa Cruz da Esperan�a', 25);
insert tblCIDADE values ('Santa Cruz das Palmeiras', 25);
insert tblCIDADE values ('Santa Cruz do Rio Pardo', 25);
insert tblCIDADE values ('Santa Ernestina', 25);
insert tblCIDADE values ('Santa F� do Sul', 25);
insert tblCIDADE values ('Santa Gertrudes', 25);
insert tblCIDADE values ('Santa Isabel', 25);
insert tblCIDADE values ('Santa L�cia', 25);
insert tblCIDADE values ('Santa Maria da Serra', 25);
insert tblCIDADE values ('Santa Mercedes', 25);
insert tblCIDADE values ('Santana da Ponte Pensa', 25);
insert tblCIDADE values ('Santana de Parna�ba', 25);
insert tblCIDADE values ('Santa Rita d''Oeste', 25);
insert tblCIDADE values ('Santa Rita do Passa Quatro', 25);
insert tblCIDADE values ('Santa Rosa de Viterbo', 25);
insert tblCIDADE values ('Santa Salete', 25);
insert tblCIDADE values ('Santo Anast�cio', 25);
insert tblCIDADE values ('Santo Andr�', 25);
insert tblCIDADE values ('Santo Ant�nio da Alegria', 25);
insert tblCIDADE values ('Santo Ant�nio de Posse', 25);
insert tblCIDADE values ('Santo Ant�nio do Aracangu�', 25);
insert tblCIDADE values ('Santo Ant�nio do Jardim', 25);
insert tblCIDADE values ('Santo Ant�nio do Pinhal', 25);
insert tblCIDADE values ('Santo Expedito', 25);
insert tblCIDADE values ('Sant�polis do Aguape�', 25);
insert tblCIDADE values ('Santos', 25);
insert tblCIDADE values ('S�o Bento do Sapuca�', 25);
insert tblCIDADE values ('S�o Bernardo do Campo', 25);
insert tblCIDADE values ('S�o Caetano do Sul', 25);
insert tblCIDADE values ('S�o Carlos', 25);
insert tblCIDADE values ('S�o Francisco', 25);
insert tblCIDADE values ('S�o Jo�o da Boa Vista', 25);
insert tblCIDADE values ('S�o Jo�o das Duas Pontes', 25);
insert tblCIDADE values ('S�o Jo�o de Iracema', 25);
insert tblCIDADE values ('S�o Jo�o do Pau d''Alho', 25);
insert tblCIDADE values ('S�o Joaquim da Barra', 25);
insert tblCIDADE values ('S�o Jos� da Bela Vista', 25);
insert tblCIDADE values ('S�o Jos� do Barreiro', 25);
insert tblCIDADE values ('S�o Jos� do Rio Pardo', 25);
insert tblCIDADE values ('S�o Jos� do Rio Preto', 25);
insert tblCIDADE values ('S�o Jos� dos Campos', 25);
insert tblCIDADE values ('S�o Louren�o da Serra', 25);
insert tblCIDADE values ('S�o Lu�s do Paraitinga', 25);
insert tblCIDADE values ('S�o Manuel', 25);
insert tblCIDADE values ('S�o Miguel Arcanjo', 25);
insert tblCIDADE values ('S�o Paulo', 25);
insert tblCIDADE values ('S�o Pedro', 25);
insert tblCIDADE values ('S�o Pedro do Turvo', 25);
insert tblCIDADE values ('S�o Roque', 25);
insert tblCIDADE values ('S�o Sebasti�o', 25);
insert tblCIDADE values ('S�o Sebasti�o da Grama', 25);
insert tblCIDADE values ('S�o Sim�o', 25);
insert tblCIDADE values ('S�o Vicente', 25);
insert tblCIDADE values ('Sarapu�', 25);
insert tblCIDADE values ('Sarutai�', 25);
insert tblCIDADE values ('Sebastian�polis do Sul', 25);
insert tblCIDADE values ('Serra Azul', 25);
insert tblCIDADE values ('Serrana', 25);
insert tblCIDADE values ('Serra Negra', 25);
insert tblCIDADE values ('Sert�ozinho', 25);
insert tblCIDADE values ('Sete Barras', 25);
insert tblCIDADE values ('Sever�nia', 25);
insert tblCIDADE values ('Silveiras', 25);
insert tblCIDADE values ('Socorro', 25);
insert tblCIDADE values ('Sorocaba', 25);
insert tblCIDADE values ('Sud Mennucci', 25);
insert tblCIDADE values ('Sumar�', 25);
insert tblCIDADE values ('Suzano', 25);
insert tblCIDADE values ('Suzan�polis', 25);
insert tblCIDADE values ('Tabapu�', 25);
insert tblCIDADE values ('Tabatinga', 25);
insert tblCIDADE values ('Tabo�o da Serra', 25);
insert tblCIDADE values ('Taciba', 25);
insert tblCIDADE values ('Tagua�', 25);
insert tblCIDADE values ('Taia�u', 25);
insert tblCIDADE values ('Tai�va', 25);
insert tblCIDADE values ('Tamba�', 25);
insert tblCIDADE values ('Tanabi', 25);
insert tblCIDADE values ('Tapira�', 25);
insert tblCIDADE values ('Tapiratiba', 25);
insert tblCIDADE values ('Taquaral', 25);
insert tblCIDADE values ('Taquaritinga', 25);
insert tblCIDADE values ('Taquarituba', 25);
insert tblCIDADE values ('Taquariva�', 25);
insert tblCIDADE values ('Tarabai', 25);
insert tblCIDADE values ('Tarum�', 25);
insert tblCIDADE values ('Tatu�', 25);
insert tblCIDADE values ('Taubat�', 25);
insert tblCIDADE values ('Tejup�', 25);
insert tblCIDADE values ('Teodoro Sampaio', 25);
insert tblCIDADE values ('Terra Roxa', 25);
insert tblCIDADE values ('Tiet�', 25);
insert tblCIDADE values ('Timburi', 25);
insert tblCIDADE values ('Torre de Pedra', 25);
insert tblCIDADE values ('Torrinha', 25);
insert tblCIDADE values ('Trabiju', 25);
insert tblCIDADE values ('Trememb�', 25);
insert tblCIDADE values ('Tr�s Fronteiras', 25);
insert tblCIDADE values ('Tuiuti', 25);
insert tblCIDADE values ('Tup�', 25);
insert tblCIDADE values ('Tupi Paulista', 25);
insert tblCIDADE values ('Turi�ba', 25);
insert tblCIDADE values ('Turmalina', 25);
insert tblCIDADE values ('Ubarana', 25);
insert tblCIDADE values ('Ubatuba', 25);
insert tblCIDADE values ('Ubirajara', 25);
insert tblCIDADE values ('Uchoa', 25);
insert tblCIDADE values ('Uni�o Paulista', 25);
insert tblCIDADE values ('Ur�nia', 25);
insert tblCIDADE values ('Uru', 25);
insert tblCIDADE values ('Urup�s', 25);
insert tblCIDADE values ('Valentim Gentil', 25);
insert tblCIDADE values ('Valinhos', 25);
insert tblCIDADE values ('Valpara�so', 25);
insert tblCIDADE values ('Vargem', 25);
insert tblCIDADE values ('Vargem Grande do Sul', 25);
insert tblCIDADE values ('Vargem Grande Paulista', 25);
insert tblCIDADE values ('V�rzea Paulista', 25);
insert tblCIDADE values ('Vera Cruz', 25);
insert tblCIDADE values ('Vinhedo', 25);
insert tblCIDADE values ('Viradouro', 25);
insert tblCIDADE values ('Vista Alegre do Alto', 25);
insert tblCIDADE values ('Vit�ria Brasil', 25);
insert tblCIDADE values ('Votorantim', 25);
insert tblCIDADE values ('Votuporanga', 25);
insert tblCIDADE values ('Zacarias', 25);
insert tblCIDADE values ('Chavantes', 25);
insert tblCIDADE values ('Estiva Gerbi', 25);
insert tblCIDADE values ('Amparo de S�o Francisco', 26);
insert tblCIDADE values ('Aquidab�', 26);
insert tblCIDADE values ('Aracaju', 26);
insert tblCIDADE values ('Arau�', 26);
insert tblCIDADE values ('Areia Branca', 26);
insert tblCIDADE values ('Barra dos Coqueiros', 26);
insert tblCIDADE values ('Boquim', 26);
insert tblCIDADE values ('Brejo Grande', 26);
insert tblCIDADE values ('Campo do Brito', 26);
insert tblCIDADE values ('Canhoba', 26);
insert tblCIDADE values ('Canind� de S�o Francisco', 26);
insert tblCIDADE values ('Capela', 26);
insert tblCIDADE values ('Carira', 26);
insert tblCIDADE values ('Carm�polis', 26);
insert tblCIDADE values ('Cedro de S�o Jo�o', 26);
insert tblCIDADE values ('Cristin�polis', 26);
insert tblCIDADE values ('Cumbe', 26);
insert tblCIDADE values ('Divina Pastora', 26);
insert tblCIDADE values ('Est�ncia', 26);
insert tblCIDADE values ('Feira Nova', 26);
insert tblCIDADE values ('Frei Paulo', 26);
insert tblCIDADE values ('Gararu', 26);
insert tblCIDADE values ('General Maynard', 26);
insert tblCIDADE values ('Gracho Cardoso', 26);
insert tblCIDADE values ('Ilha das Flores', 26);
insert tblCIDADE values ('Indiaroba', 26);
insert tblCIDADE values ('Itabaiana', 26);
insert tblCIDADE values ('Itabaianinha', 26);
insert tblCIDADE values ('Itabi', 26);
insert tblCIDADE values ('Itaporanga d''Ajuda', 26);
insert tblCIDADE values ('Japaratuba', 26);
insert tblCIDADE values ('Japoat�', 26);
insert tblCIDADE values ('Lagarto', 26);
insert tblCIDADE values ('Laranjeiras', 26);
insert tblCIDADE values ('Macambira', 26);
insert tblCIDADE values ('Malhada dos Bois', 26);
insert tblCIDADE values ('Malhador', 26);
insert tblCIDADE values ('Maruim', 26);
insert tblCIDADE values ('Moita Bonita', 26);
insert tblCIDADE values ('Monte Alegre de Sergipe', 26);
insert tblCIDADE values ('Muribeca', 26);
insert tblCIDADE values ('Ne�polis', 26);
insert tblCIDADE values ('Nossa Senhora Aparecida', 26);
insert tblCIDADE values ('Nossa Senhora da Gl�ria', 26);
insert tblCIDADE values ('Nossa Senhora das Dores', 26);
insert tblCIDADE values ('Nossa Senhora de Lourdes', 26);
insert tblCIDADE values ('Nossa Senhora do Socorro', 26);
insert tblCIDADE values ('Pacatuba', 26);
insert tblCIDADE values ('Pedra Mole', 26);
insert tblCIDADE values ('Pedrinhas', 26);
insert tblCIDADE values ('Pinh�o', 26);
insert tblCIDADE values ('Pirambu', 26);
insert tblCIDADE values ('Po�o Redondo', 26);
insert tblCIDADE values ('Po�o Verde', 26);
insert tblCIDADE values ('Porto da Folha', 26);
insert tblCIDADE values ('Propri�', 26);
insert tblCIDADE values ('Riach�o do Dantas', 26);
insert tblCIDADE values ('Riachuelo', 26);
insert tblCIDADE values ('Ribeir�polis', 26);
insert tblCIDADE values ('Ros�rio do Catete', 26);
insert tblCIDADE values ('Salgado', 26);
insert tblCIDADE values ('Santa Luzia do Itanhy', 26);
insert tblCIDADE values ('Santana do S�o Francisco', 26);
insert tblCIDADE values ('Santa Rosa de Lima', 26);
insert tblCIDADE values ('Santo Amaro das Brotas', 26);
insert tblCIDADE values ('S�o Crist�v�o', 26);
insert tblCIDADE values ('S�o Domingos', 26);
insert tblCIDADE values ('S�o Francisco', 26);
insert tblCIDADE values ('S�o Miguel do Aleixo', 26);
insert tblCIDADE values ('Sim�o Dias', 26);
insert tblCIDADE values ('Siriri', 26);
insert tblCIDADE values ('Telha', 26);
insert tblCIDADE values ('Tobias Barreto', 26);
insert tblCIDADE values ('Tomar do Geru', 26);
insert tblCIDADE values ('Umba�ba', 26);
insert tblCIDADE values ('Abreul�ndia', 27);
insert tblCIDADE values ('Aguiarn�polis', 27);
insert tblCIDADE values ('Alian�a do Tocantins', 27);
insert tblCIDADE values ('Almas', 27);
insert tblCIDADE values ('Alvorada', 27);
insert tblCIDADE values ('Anan�s', 27);
insert tblCIDADE values ('Angico', 27);
insert tblCIDADE values ('Aparecida do Rio Negro', 27);
insert tblCIDADE values ('Aragominas', 27);
insert tblCIDADE values ('Araguacema', 27);
insert tblCIDADE values ('Aragua�u', 27);
insert tblCIDADE values ('Aragua�na', 27);
insert tblCIDADE values ('Araguan�', 27);
insert tblCIDADE values ('Araguatins', 27);
insert tblCIDADE values ('Arapoema', 27);
insert tblCIDADE values ('Arraias', 27);
insert tblCIDADE values ('Augustin�polis', 27);
insert tblCIDADE values ('Aurora do Tocantins', 27);
insert tblCIDADE values ('Axix� do Tocantins', 27);
insert tblCIDADE values ('Baba�ul�ndia', 27);
insert tblCIDADE values ('Bandeirantes do Tocantins', 27);
insert tblCIDADE values ('Barra do Ouro', 27);
insert tblCIDADE values ('Barrol�ndia', 27);
insert tblCIDADE values ('Bernardo Say�o', 27);
insert tblCIDADE values ('Bom Jesus do Tocantins', 27);
insert tblCIDADE values ('Brasil�ndia do Tocantins', 27);
insert tblCIDADE values ('Brejinho de Nazar�', 27);
insert tblCIDADE values ('Buriti do Tocantins', 27);
insert tblCIDADE values ('Cachoeirinha', 27);
insert tblCIDADE values ('Campos Lindos', 27);
insert tblCIDADE values ('Cariri do Tocantins', 27);
insert tblCIDADE values ('Carmol�ndia', 27);
insert tblCIDADE values ('Carrasco Bonito', 27);
insert tblCIDADE values ('Caseara', 27);
insert tblCIDADE values ('Centen�rio', 27);
insert tblCIDADE values ('Chapada de Areia', 27);
insert tblCIDADE values ('Chapada da Natividade', 27);
insert tblCIDADE values ('Colinas do Tocantins', 27);
insert tblCIDADE values ('Combinado', 27);
insert tblCIDADE values ('Concei��o do Tocantins', 27);
insert tblCIDADE values ('Couto Magalh�es', 27);
insert tblCIDADE values ('Cristal�ndia', 27);
insert tblCIDADE values ('Crix�s do Tocantins', 27);
insert tblCIDADE values ('Darcin�polis', 27);
insert tblCIDADE values ('Dian�polis', 27);
insert tblCIDADE values ('Divin�polis do Tocantins', 27);
insert tblCIDADE values ('Dois Irm�os do Tocantins', 27);
insert tblCIDADE values ('Duer�', 27);
insert tblCIDADE values ('Esperantina', 27);
insert tblCIDADE values ('F�tima', 27);
insert tblCIDADE values ('Figueir�polis', 27);
insert tblCIDADE values ('Filad�lfia', 27);
insert tblCIDADE values ('Formoso do Araguaia', 27);
insert tblCIDADE values ('Fortaleza do Taboc�o', 27);
insert tblCIDADE values ('Goianorte', 27);
insert tblCIDADE values ('Goiatins', 27);
insert tblCIDADE values ('Guara�', 27);
insert tblCIDADE values ('Gurupi', 27);
insert tblCIDADE values ('Ipueiras', 27);
insert tblCIDADE values ('Itacaj�', 27);
insert tblCIDADE values ('Itaguatins', 27);
insert tblCIDADE values ('Itapiratins', 27);
insert tblCIDADE values ('Itapor� do Tocantins', 27);
insert tblCIDADE values ('Ja� do Tocantins', 27);
insert tblCIDADE values ('Juarina', 27);
insert tblCIDADE values ('Lagoa da Confus�o', 27);
insert tblCIDADE values ('Lagoa do Tocantins', 27);
insert tblCIDADE values ('Lajeado', 27);
insert tblCIDADE values ('Lavandeira', 27);
insert tblCIDADE values ('Lizarda', 27);
insert tblCIDADE values ('Luzin�polis', 27);
insert tblCIDADE values ('Marian�polis do Tocantins', 27);
insert tblCIDADE values ('Mateiros', 27);
insert tblCIDADE values ('Mauril�ndia do Tocantins', 27);
insert tblCIDADE values ('Miracema do Tocantins', 27);
insert tblCIDADE values ('Miranorte', 27);
insert tblCIDADE values ('Monte do Carmo', 27);
insert tblCIDADE values ('Monte Santo do Tocantins', 27);
insert tblCIDADE values ('Palmeiras do Tocantins', 27);
insert tblCIDADE values ('Muricil�ndia', 27);
insert tblCIDADE values ('Natividade', 27);
insert tblCIDADE values ('Nazar�', 27);
insert tblCIDADE values ('Nova Olinda', 27);
insert tblCIDADE values ('Nova Rosal�ndia', 27);
insert tblCIDADE values ('Novo Acordo', 27);
insert tblCIDADE values ('Novo Alegre', 27);
insert tblCIDADE values ('Novo Jardim', 27);
insert tblCIDADE values ('Oliveira de F�tima', 27);
insert tblCIDADE values ('Palmeirante', 27);
insert tblCIDADE values ('Palmeir�polis', 27);
insert tblCIDADE values ('Para�so do Tocantins', 27);
insert tblCIDADE values ('Paran�', 27);
insert tblCIDADE values ('Pau D''Arco', 27);
insert tblCIDADE values ('Pedro Afonso', 27);
insert tblCIDADE values ('Peixe', 27);
insert tblCIDADE values ('Pequizeiro', 27);
insert tblCIDADE values ('Colm�ia', 27);
insert tblCIDADE values ('Pindorama do Tocantins', 27);
insert tblCIDADE values ('Piraqu�', 27);
insert tblCIDADE values ('Pium', 27);
insert tblCIDADE values ('Ponte Alta do Bom Jesus', 27);
insert tblCIDADE values ('Ponte Alta do Tocantins', 27);
insert tblCIDADE values ('Porto Alegre do Tocantins', 27);
insert tblCIDADE values ('Porto Nacional', 27);
insert tblCIDADE values ('Praia Norte', 27);
insert tblCIDADE values ('Presidente Kennedy', 27);
insert tblCIDADE values ('Pugmil', 27);
insert tblCIDADE values ('Recursol�ndia', 27);
insert tblCIDADE values ('Riachinho', 27);
insert tblCIDADE values ('Rio da Concei��o', 27);
insert tblCIDADE values ('Rio dos Bois', 27);
insert tblCIDADE values ('Rio Sono', 27);
insert tblCIDADE values ('Sampaio', 27);
insert tblCIDADE values ('Sandol�ndia', 27);
insert tblCIDADE values ('Santa F� do Araguaia', 27);
insert tblCIDADE values ('Santa Maria do Tocantins', 27);
insert tblCIDADE values ('Santa Rita do Tocantins', 27);
insert tblCIDADE values ('Santa Rosa do Tocantins', 27);
insert tblCIDADE values ('Santa Tereza do Tocantins', 27);
insert tblCIDADE values ('Santa Terezinha do Tocantins', 27);
insert tblCIDADE values ('S�o Bento do Tocantins', 27);
insert tblCIDADE values ('S�o F�lix do Tocantins', 27);
insert tblCIDADE values ('S�o Miguel do Tocantins', 27);
insert tblCIDADE values ('S�o Salvador do Tocantins', 27);
insert tblCIDADE values ('S�o Sebasti�o do Tocantins', 27);
insert tblCIDADE values ('S�o Val�rio', 27);
insert tblCIDADE values ('Silvan�polis', 27);
insert tblCIDADE values ('S�tio Novo do Tocantins', 27);
insert tblCIDADE values ('Sucupira', 27);
insert tblCIDADE values ('Taguatinga', 27);
insert tblCIDADE values ('Taipas do Tocantins', 27);
insert tblCIDADE values ('Talism�', 27);
insert tblCIDADE values ('Palmas', 27);
insert tblCIDADE values ('Tocant�nia', 27);
insert tblCIDADE values ('Tocantin�polis', 27);
insert tblCIDADE values ('Tupirama', 27);
insert tblCIDADE values ('Tupiratins', 27);
insert tblCIDADE values ('Wanderl�ndia', 27);
insert tblCIDADE values ('Xambio�', 27);



/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwCidade AS (
    SELECT c.CidadeID, c.CidadeNome, e.EstadoID, e.EstadoNome, e.EstadoSigla
    FROM tblCidade c
	INNER JOIN vwEstado e ON (c.EstadoID = e.EstadoID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewCidade
        ON vwCidade 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaCidadeManter
    ON tblCidade
    INSTEAD OF INSERT, UPDATE, DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- Pessoa
CREATE TABLE tblPessoa(
	PessoaID INT PRIMARY KEY IDENTITY(1,1),
	PessoaEndereco VARCHAR(60) NOT NULL,
	PessoaBairro VARCHAR(50) NOT NULL,
	PessoaTelefone VARCHAR(15) NOT NULL,
	PessoaAtivo BIT NOT NULL,
	CidadeID INT NOT NULL
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwPessoa AS (
    SELECT p.PessoaID, p.PessoaEndereco, p.PessoaBairro, p.PessoaTelefone, p.PessoaAtivo, c.CidadeID, c.CidadeNome, c.EstadoID, c.EstadoNome, c.EstadoSigla
    FROM tblPessoa p
	INNER JOIN vwCidade c ON (p.CidadeID = c.CidadeID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewPessoa
        ON vwPessoa 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaPessoaManter
    ON tblPessoa
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- PessoaFisica
CREATE TABLE tblPessoaFisica(
	PessoaFisicaCPF VARCHAR(14) PRIMARY KEY,
	PessoaFisicaNome VARCHAR(60) NOT NULL,
	PessoaID INT NOT NULL,

	CONSTRAINT FK_PessoaFisica_Pessoa FOREIGN KEY (PessoaID) REFERENCES tblPessoa (PessoaID),
	CONSTRAINT UQ_PessoaFisicaNome UNIQUE (PessoaFisicaNome)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwPessoaFisica AS (
    SELECT pf.PessoaFisicaCPF, pf.PessoaFisicaNome, p.PessoaID, p.PessoaEndereco, p.PessoaBairro, p.PessoaTelefone, p.PessoaAtivo, p.CidadeID, p.CidadeNome, p.EstadoID, p.EstadoNome, p.EstadoSigla
    FROM tblPessoaFisica pf
	INNER JOIN vwPessoa p ON (pf.PessoaID = p.PessoaID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewPessoaFisica
        ON vwPessoaFisica 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
/*CREATE TRIGGER trgSegurancaPessoaFisicaManter
    ON tblPessoaFisica
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK*/
END




BEGIN-- PessoaJuridica
CREATE TABLE tblPessoaJuridica(
	PessoaJuridicaCNPJ VARCHAR(20) PRIMARY KEY,
	PessoaJuridicaRazaoSocial VARCHAR(50) NOT NULL,
	PessoaJuridicaNomeFicticio VARCHAR(60) NOT NULL,
	PessoaID INT NOT NULL,

	CONSTRAINT FK_PessoaJuridica_Pessoa FOREIGN KEY (PessoaID) REFERENCES tblPessoa (PessoaID),
	CONSTRAINT UQ_PessoaJuridicaRazaoSocial UNIQUE (PessoaJuridicaRazaoSocial)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwPessoaJuridica AS (
    SELECT pj.PessoaJuridicaCNPJ, pj.PessoaJuridicaRazaoSocial, pj.PessoaJuridicaNomeFicticio, p.PessoaID, p.PessoaEndereco, p.PessoaBairro, p.PessoaTelefone, p.PessoaAtivo, p.CidadeID, p.CidadeNome, p.EstadoID, p.EstadoNome, p.EstadoSigla
    FROM tblPessoaJuridica pj
	INNER JOIN vwPessoa p ON (pj.PessoaID = p.PessoaID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewPessoaJuridica
        ON vwPessoaJuridica 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
/*CREATE TRIGGER trgSegurancaPessoaJuridicaManter
    ON tblPessoaJuridica
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK*/
END




BEGIN-- ContratoAluguel  -  Pasto  -  EstoqueLocalidade
CREATE TABLE tblContratoAluguel(
	ContratoAluguelID INT PRIMARY KEY IDENTITY(1,1),
	ContratoAluguelDataInicial DATETIME NOT NULL,
	ContratoAluguelDataFinal DATETIME NOT NULL,
	ContratoAluguelValor DECIMAL(18,2) NOT NULL,
	PessoaID INT NOT NULL,

	CONSTRAINT FK_ContratoAluguel_Pessoa FOREIGN KEY (PessoaID) REFERENCES tblPessoa (PessoaID)
)


CREATE TABLE tblEstoqueLocalidade(
	EstoqueLocalidadeID INT PRIMARY KEY IDENTITY(1,1),
	EstoqueLocalidadeDescricao VARCHAR(100) NOT NULL,
	EstoqueLocalidadeEndereco VARCHAR(60) NOT NULL,
	CidadeID INT NOT NULL,
	ContratoAluguelID INT

	CONSTRAINT FK_EstoqueLocalidade_Cidade FOREIGN KEY (CidadeID) REFERENCES tblCidade (CidadeID),
	CONSTRAINT FK_EstoqueLocalidade_ContratoAluguel FOREIGN KEY (ContratoAluguelID) REFERENCES tblContratoAluguel (ContratoAluguelID)
)


CREATE TABLE tblPasto(
	PastoID INT PRIMARY KEY IDENTITY(1,1),
	PastoDescricao VARCHAR(60) NOT NULL,
	PastoTamanho DECIMAL(18,4) NOT NULL,
	PastoAtivo BIT NOT NULL,
	CidadeID INT NOT NULL,
	ContratoAluguelID INT

	CONSTRAINT FK_Pasto_Cidade FOREIGN KEY (CidadeID) REFERENCES tblCidade (CidadeID),
	CONSTRAINT FK_Pasto_ContratoAluguel FOREIGN KEY (ContratoAluguelID) REFERENCES tblContratoAluguel (ContratoAluguelID)
)


/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwContratoAluguel AS (
    SELECT ca.ContratoAluguelID, ca.ContratoAluguelDataInicial, ca.ContratoAluguelDataFinal, ca.ContratoAluguelValor,
	ca.PessoaID,
	(
		SELECT 
			COUNT(p.PastoID)
		FROM 
			tblPasto p
		WHERE
			p.ContratoAluguelID = ca.ContratoAluguelID
	) AS QuantidadePasto,
	(
		SELECT	
			COUNT(el.EstoqueLocalidadeID)
		FROM
			tblEstoqueLocalidade el
		WHERE
			el.ContratoAluguelID = ca.ContratoAluguelID
	) AS QuantidadeEstoqueLocalidade
    FROM tblContratoAluguel ca
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewContratoAluguel
        ON vwContratoAluguel 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaContratoAluguelManter
    ON tblContratoAluguel
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK




/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwPasto AS (
    SELECT p.PastoID, p.PastoDescricao, p.PastoTamanho, p.PastoAtivo, c.CidadeID,
	c.CidadeNome, c.EstadoID, c.EstadoNome, c.EstadoSigla, p.ContratoAluguelID
    FROM tblPasto p
	INNER JOIN vwCidade c ON (p.CidadeID = c.CidadeID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewPasto
        ON vwPasto 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaPastoManter
    ON tblPasto
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK


/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwEstoqueLocalidade AS (
    SELECT e.EstoqueLocalidadeID, e.EstoqueLocalidadeDescricao, e.EstoqueLocalidadeEndereco, c.CidadeID,
	c.CidadeNome, c.EstadoID, c.EstadoNome, c.EstadoSigla, e.ContratoAluguelID
    FROM tblEstoqueLocalidade e
	INNER JOIN vwCidade c ON (e.CidadeID = c.CidadeID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewEstoqueLocalidade
        ON vwEstoqueLocalidade 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaEstoqueLocalidadeManter
    ON tblEstoqueLocalidade
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- TipoItem
CREATE TABLE tblTipoItem(
	TipoItemID INT PRIMARY KEY IDENTITY(1,1),
	TipoItemDescricao VARCHAR(60) NOT NULL
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwTipoItem AS (
    SELECT ti.TipoItemID, ti.TipoItemDescricao
    FROM tblTipoItem ti
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewTipoItem
        ON vwTipoItem 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaTipoItemManter
    ON tblTipoItem
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- Item
CREATE TABLE tblItem(
	ItemID INT PRIMARY KEY IDENTITY(1,1),
	ItemDescricao VARCHAR(100) NOT NULL,
	TipoItemID INT NOT NULL,

	CONSTRAINT FK_Item_TipoItem FOREIGN KEY (TipoItemID) REFERENCES tblTipoItem (TipoItemID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwItem AS (
    SELECT i.ItemID, i.ItemDescricao, ti.TipoItemID, ti.TipoItemDescricao
    FROM tblItem i
	INNER JOIN vwTipoItem ti ON (i.TipoItemID = ti.TipoItemID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewItem
        ON vwItem 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaItemManter
    ON tblItem
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- Estoque
CREATE TABLE tblEstoque(
	EstoqueID INT PRIMARY KEY IDENTITY(1,1),
	EstoqueQuantidade DECIMAL(8,3) NOT NULL,
	EstoqueLocalidadeID INT NOT NULL,
	EstoqueAtivo BIT NOT NULL,
	ItemID INT NOT NULL,

	CONSTRAINT FK_Estoque_EstoqueLocalidade FOREIGN KEY (EstoqueLocalidadeID) REFERENCES tblEstoqueLocalidade (EstoqueLocalidadeID),
	CONSTRAINT FK_Estoque_Item FOREIGN KEY (ItemID) REFERENCES tblItem (ItemID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwEstoque AS (
    SELECT e.EstoqueID, e.EstoqueQuantidade, e.EstoqueLocalidadeID, e.EstoqueAtivo,
	el.EstoqueLocalidadeDescricao, el.EstoqueLocalidadeEndereco, el.CidadeID, el.CidadeNome, el.EstadoID, el.EstadoNome, el.EstadoSigla, 
	i.ItemID, i.ItemDescricao, i.TipoItemID, i.TipoItemDescricao
    FROM tblEstoque e
	INNER JOIN vwEstoqueLocalidade el ON (e.EstoqueLocalidadeID = el.EstoqueLocalidadeID)
	INNER JOIN vwItem i ON (e.ItemID = i.ItemID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewEstoque
        ON vwEstoque 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaEstoqueManter
    ON tblEstoque
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- EntradaItem
CREATE TABLE tblEntradaItem(
	EntradaItemID INT PRIMARY KEY IDENTITY(1,1),
	EntradaItemDescricao VARCHAR(100) NOT NULL,
	EntradaItemQuantidade DECIMAL(8,3) NOT NULL,
	EntradaItemData DATETIME NOT NULL,
	EstoqueID INT NOT NULL,
	UsuarioID INT NOT NULL,

	CONSTRAINT FK_EntradaItem_Estoque FOREIGN KEY (EstoqueID) REFERENCES tblEstoque (EstoqueID),
	CONSTRAINT FK_EntradaItem_Usuario FOREIGN KEY (UsuarioID) REFERENCES tblUsuario (UsuarioID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwEntradaItem AS (
    SELECT ei.EntradaItemID, ei.EntradaItemDescricao, ei.EntradaItemQuantidade, ei.EntradaItemData,
	ei.EstoqueID, ei.UsuarioID, u.UsuarioNome, u.TipoUsuarioDescricao, u.UsuarioAtivo

    FROM tblEntradaItem ei
	INNER JOIN vwUsuario u ON (ei.UsuarioID = u.UsuarioID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewEntradaItem 
        ON vwEntradaItem 
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
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
			
-- Trigger para subtrair do estoque quando houver exclus�o da entrada
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

END




BEGIN-- RetiradaItem
CREATE TABLE tblRetiradaitem(
	RetiradaItemID INT PRIMARY KEY IDENTITY(1,1),
	RetiradaItemDescricao VARCHAR(100) NOT NULL,
	RetiradaItemQuantidade DECIMAL(8,3) NOT NULL,
	RetiradaItemData DATETIME NOT NULL,
	EstoqueID INT NOT NULL,
	UsuarioID INT NOT NULL,

	CONSTRAINT FK_RetiradaItem_Estoque FOREIGN KEY (EstoqueID) REFERENCES tblEstoque (EstoqueID),
	CONSTRAINT FK_RetiradaItem_Usuario FOREIGN KEY (UsuarioID) REFERENCES tblUsuario (UsuarioID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwRetiradaItem AS (
    SELECT ri.RetiradaItemID, ri.RetiradaItemDescricao, ri.RetiradaItemQuantidade, ri.RetiradaItemData,
	ri.EstoqueID, ri.UsuarioID, u.UsuarioNome, u.TipoUsuarioDescricao, u.UsuarioAtivo
    FROM tblRetiradaItem ri
	INNER JOIN vwUsuario u ON (ri.UsuarioID = u.UsuarioID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewRetiradaItem
        ON vwRetiradaItem
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
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
			
-- Trigger para somar do estoque quando houver exclus�o da retirada
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

END




BEGIN-- Piquete
CREATE TABLE tblPiquete(
	PiqueteID INT PRIMARY KEY IDENTITY(1,1),
	PiqueteDescricao VARCHAR(30) NOT NULL,
	PiqueteAtivo BIT NOT NULL,
	PastoID INT NOT NULL,

	CONSTRAINT FK_Piquete_Pasto FOREIGN KEY (PastoID) REFERENCES tblPasto (PastoID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwPiquete AS (
    SELECT pqt.PiqueteID, pqt.PiqueteDescricao, pqt.PiqueteAtivo, pqt.PastoID
    FROM tblPiquete pqt
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewPiquete
        ON vwPiquete
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
END




BEGIN-- Ra�a
CREATE TABLE tblRaca(
	RacaID INT PRIMARY KEY IDENTITY(1,1),
	RacaNome VARCHAR(30) NOT NULL,
	RacaDescricao VARCHAR(60) NOT NULL
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwRaca AS (
    SELECT rc.RacaID, rc.RacaNome, rc.RacaDescricao
    FROM tblRaca rc
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewRaca
        ON vwRaca
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaRacaManter
    ON tblRaca
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- Animal
CREATE TABLE tblAnimal(
	AnimalID INT PRIMARY KEY IDENTITY(1,1),
	AnimalDescricao VARCHAR(100) NOT NULL,
	AnimalParentescoPai INT NULL,
	AnimalParentescoMae INT NULL,
	AnimalLocalidadeNascimento VARCHAR(60) NULL,
	AnimalDataNascimento DATETIME NULL,
	AnimalIdentificador VARCHAR(8) NOT NULL,
	AnimalAtivo BIT NOT NULL,
	RacaID INT NOT NULL,
	PiqueteID INT NOT NULL,

	CONSTRAINT FK_Animal_Raca FOREIGN KEY (RacaID) REFERENCES tblRaca (RacaID),
	CONSTRAINT FK_Animal_Piquete FOREIGN KEY (PiqueteID) REFERENCES tblPiquete (PiqueteID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwAnimal AS (
    SELECT a.AnimalID, a.AnimalDescricao, a.AnimalParentescoPai, a.AnimalParentescoMae, a.AnimalLocalidadeNascimento,
	a.AnimalDataNascimento, a.AnimalIdentificador, a.PiqueteID, a.AnimalAtivo, rc.RacaID, rc.RacaNome, rc.RacaDescricao
    FROM tblAnimal a
	INNER JOIN vwRaca rc ON (a.RacaID = rc.RacaID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewAnimal
        ON vwAnimal
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaAnimalManter
    ON tblAnimal
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- Pesagem
CREATE TABLE tblPesagem(
	PesagemID INT PRIMARY KEY IDENTITY(1,1),
	PesagemData DATETIME NOT NULL,
	PesagemPeso DECIMAL(8,3) NOT NULL,
	AnimalID INT NOT NULL,

	CONSTRAINT FK_Pesagem_Animal FOREIGN KEY (AnimalID) REFERENCES tblAnimal (AnimalID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwPesagem AS (
    SELECT ps.PesagemID, ps.PesagemData, ps.PesagemPeso, ps.AnimalID, a.AnimalDescricao
    FROM tblPesagem ps
	INNER JOIN tblAnimal a ON (ps.AnimalID = a.AnimalID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewPesagem
        ON vwPesagem
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK

--View respons�vel pelo retorno da ultima pesagem de um animal
CREATE VIEW vwUltimaPesagemAnimal AS (
	SELECT 
		(SELECT TOP 1 ps.PesagemID
		FROM tblPesagem ps WHERE ps.AnimalID = a.AnimalID ORDER BY PesagemData DESC) as PesagemID, a.AnimalID, a.RacaID
	FROM tblAnimal a
	GROUP BY a.AnimalID, a.RacaID
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewUltimaPesagemAnimal
        ON vwUltimaPesagemAnimal
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK

			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaPesagemManter
    ON tblPesagem
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- Veterinario
CREATE TABLE tblVeterinario(
	VeterinarioID INT IDENTITY(1,1) PRIMARY KEY,
	VeterinarioCRMV VARCHAR(30) NOT NULL,
	VeterinarioNome VARCHAR(60) NOT NULL,
	VeterinarioTelefone VARCHAR(15) NOT NULL,
	VeterinarioBairro VARCHAR(30) NOT NULL,
	VeterinarioEndereco VARCHAR(50) NOT NULL,
	VeterinarioAtivo BIT NOT NULL,
	CidadeID INT NOT NULL,

	CONSTRAINT FK_Veterinario_Cidade FOREIGN KEY (CidadeID) REFERENCES tblCidade (CidadeID),
	CONSTRAINT FK_Veterinario_Unique UNIQUE (VeterinarioCRMV)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwVeterinario AS (
    SELECT v.VeterinarioID, v.VeterinarioCRMV, v.VeterinarioNome, v.VeterinarioTelefone, v.VeterinarioBairro,
	v.VeterinarioEndereco, v.VeterinarioAtivo, c.CidadeID, c.CidadeNome, c.EstadoID, c.EstadoNome, c.EstadoSigla
    FROM tblVeterinario v
	INNER JOIN vwCidade c ON (v.CidadeID = c.CidadeID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewVeterinario
        ON vwVeterinario
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaVeterinarioManter
    ON tblVeterinario
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- ConsultaVeterinaria
CREATE TABLE tblConsultaVeterinaria(
	ConsultaVeterinariaID INT IDENTITY(1,1) PRIMARY KEY,
	ConsultaVeterinariaData DATETIME NOT NULL,
	ConsultaVeterinariaDescricao VARCHAR(300) NOT NULL,
	ConsultaVeterinariaCusto DECIMAL(18,2) NOT NULL,
	AnimalID INT NOT NULL,

	CONSTRAINT FK_ConsultaVeterinaria_Animal FOREIGN KEY (AnimalID) REFERENCES tblAnimal (AnimalID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwConsultaVeterinaria AS (
    SELECT cv.ConsultaVeterinariaID, cv.ConsultaVeterinariaData, cv.ConsultaVeterinariaDescricao,
	cv.ConsultaVeterinariaCusto, a.AnimalID, a.AnimalDescricao,
	a.AnimalLocalidadeNascimento, a.AnimalDataNascimento, a.AnimalIdentificador, a.PiqueteID,
	a.AnimalAtivo, a.RacaID, a.RacaNome, a.RacaDescricao
    FROM tblConsultaVeterinaria cv
	INNER JOIN vwAnimal a ON (cv.AnimalID = a.AnimalID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewConsultaVeterinaria
        ON vwConsultaVeterinaria
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaConsultaVeterinariaManter
    ON tblConsultaVeterinaria
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- ListaVeterinario
CREATE TABLE tblListaVeterinario(
	ListaVeterinarioID INT IDENTITY(1,1) PRIMARY KEY,
	ConsultaVeterinariaID INT NOT NULL,
	VeterinarioID INT NOT NULL,

	CONSTRAINT FK_ListaVeterinario_ConsultaVeterinaria FOREIGN KEY (ConsultaVeterinariaID) REFERENCES tblConsultaVeterinaria (ConsultaVeterinariaID),
	CONSTRAINT FK_ListaVeterinario_Veterinaria FOREIGN KEY (VeterinarioID) REFERENCES tblVeterinario (VeterinarioID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwListaVeterinario AS (
    SELECT lvt.ListaVeterinarioID, lvt.ConsultaVeterinariaID, v.VeterinarioID, v.VeterinarioCRMV,
	v.VeterinarioNome, v.VeterinarioTelefone, v.VeterinarioBairro, v.VeterinarioEndereco, v.VeterinarioAtivo,
	v.CidadeID, v.CidadeNome, v.EstadoID, v.EstadoNome, v.EstadoSigla
    FROM tblListaVeterinario lvt
	INNER JOIN vwVeterinario v ON (lvt.VeterinarioID = v.VeterinarioID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewListaVeterinario
        ON vwListaVeterinario
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaListaVeterinarioManter
    ON tblListaVeterinario
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- Compra e ListaCompra
CREATE TABLE tblCompra(
	CompraID INT IDENTITY(1,1) PRIMARY KEY,
	CompraData DATETIME NOT NULL,
	CompraDataEntrega DATETIME NOT NULL,
	CompraValorTotal DECIMAL(18,2) NOT NULL,
	PessoaID INT NOT NULL,
	UsuarioID INT NOT NULL,

	CONSTRAINT FK_Compra_Pessoa FOREIGN KEY (PessoaID) REFERENCES tblPessoa (PessoaID),
	CONSTRAINT FK_Compra_Usuario FOREIGN KEY (UsuarioID) REFERENCES tblUsuario (UsuarioID)
)

CREATE TABLE tblListaCompra(
	ListaCompraID INT IDENTITY(1,1) PRIMARY KEY,
	ListaCompraValor DECIMAL(9,2) NOT NULL,
	CompraID INT NOT NULL,
	AnimalID INT NOT NULL,

	CONSTRAINT FK_ListaCompra_Compra FOREIGN KEY (CompraID) REFERENCES tblCompra (CompraID),
	CONSTRAINT FK_ListaCompra_Animal FOREIGN KEY (AnimalID) REFERENCES tblAnimal (AnimalID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwListaCompra AS (
    SELECT lc.ListaCompraID, lc.ListaCompraValor, lc.CompraID,
	a.AnimalID, a.AnimalDescricao, a.AnimalDataNascimento, a.AnimalIdentificador, a.RacaNome
    FROM tblListaCompra lc
	INNER JOIN vwAnimal a ON (lc.AnimalID = a.AnimalID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewListaCompra
        ON vwListaCompra
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK

			
/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwCompra AS (
    SELECT c.CompraID, c.CompraData, c.CompraDataEntrega, c.CompraValorTotal, 
	c.PessoaID, u.UsuarioID, u.UsuarioNome,
	(
		SELECT 
			COUNT(l.ListaCompraID) 
		FROM 
			vwListaCompra l
		WHERE
			l.CompraID = c.CompraID
	) AS QuantidadeAnimais
    FROM tblCompra c
	INNER JOIN vwUsuario u ON (c.UsuarioID = u.UsuarioID) 
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewCompra
        ON vwCompra
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaCompraManter
    ON tblCompra
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END




BEGIN-- Venda e ListaVenda
CREATE TABLE tblVenda(
	VendaID INT IDENTITY(1,1) PRIMARY KEY,
	VendaData DATETIME NOT NULL,
	VendaDataEntrega DATETIME NOT NULL,
	VendaValorTotal DECIMAL(18,2) NOT NULL,
	PessoaID INT NOT NULL,
	UsuarioID INT NOT NULL,

	CONSTRAINT FK_Venda_Pessoa FOREIGN KEY (PessoaID) REFERENCES tblPessoa (PessoaID),
	CONSTRAINT FK_Venda_Usuario FOREIGN KEY (UsuarioID) REFERENCES tblUsuario (UsuarioID)
)

CREATE TABLE tblListaVenda(
	ListaVendaID INT IDENTITY(1,1) PRIMARY KEY,
	ListaVendaValor DECIMAL(9,2) NOT NULL,
	VendaID INT NOT NULL,
	AnimalID INT NOT NULL,

	CONSTRAINT FK_ListaVenda_Venda FOREIGN KEY (VendaID) REFERENCES tblVenda (VendaID),
	CONSTRAINT FK_ListaVenda_Animal FOREIGN KEY (AnimalID) REFERENCES tblAnimal (AnimalID)
)

/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwListaVenda AS (
    SELECT lc.ListaVendaID, lc.ListaVendaValor, lc.VendaID,
	a.AnimalID, a.AnimalDescricao, a.AnimalDataNascimento, a.AnimalIdentificador, a.RacaNome
    FROM tblListaVenda lc
	INNER JOIN vwAnimal a ON (lc.AnimalID = a.AnimalID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewListaVenda
        ON vwListaVenda
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca

			
/* View que retorna os todos os campos
    Podemos futuramente utiliza-la para pegar apenas certos campos caso seja necess�rio*/
CREATE VIEW vwVenda AS (
    SELECT c.VendaID, c.VendaData, c.VendaDataEntrega, c.VendaValorTotal, 
	c.PessoaID, u.UsuarioID, u.UsuarioNome,
	(
		SELECT 
			COUNT(l.ListaVendaID) 
		FROM 
			vwListaVenda l
		WHERE
			l.VendaID = c.VendaID
	) AS QuantidadeAnimais
    FROM tblVenda c
	INNER JOIN vwUsuario u ON (c.UsuarioID = u.UsuarioID)
)

-- Trigger para evitar mal uso da View
CREATE TRIGGER trgSegurancaViewVenda
        ON vwVenda
        INSTEAD OF INSERT, UPDATE, DELETE
        AS
            PRINT  'N�o � permitido modificar os dados desta tabela com uma view.' 
            ROLLBACK
			
-- Trigger para evitar exlusao e alteraca
CREATE TRIGGER trgSegurancaVendaManter
    ON tblVenda
    INSTEAD OF DELETE
    AS
            PRINT  'N�o � permitido alterar nenhum dado desta tabela.' 
            ROLLBACK
END







-- Procedures

BEGIN --Tipo Usu�rio

CREATE PROCEDURE uspConsultaTipoUsuario
	@TipoProcedure VARCHAR(10),
	@TipoUsuarioID INT,
	@TipoUsuarioDescricao VARCHAR(40)
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					tu.TipoUsuarioID,
					tu.TipoUsuarioDescricao
				FROM
					vwTipoUsuario AS tu
				WHERE
					tu.TipoUsuarioID = @TipoUsuarioID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					tu.TipoUsuarioID,
					tu.TipoUsuarioDescricao
				FROM
					vwTipoUsuario AS tu
				WHERE
					tu.TipoUsuarioDescricao LIKE '%' + @TipoUsuarioDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Usu�rio

CREATE PROCEDURE uspManterUsuario
	@TipoProcedure VARCHAR(10),
	@UsuarioID INT,
	@UsuarioLogin VARCHAR(15),
	@UsuarioSenha VARCHAR(32),
	@UsuarioNome  VARCHAR(60),
	@UsuarioAtivo BIT,
	@TipoUsuarioID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblUsuario(
							UsuarioLogin,
							UsuarioSenha,
							UsuarioNome,
							UsuarioAtivo,
							TipoUsuarioID)
					VALUES
						(
							@UsuarioLogin,
							@UsuarioSenha,
							@UsuarioNome,
							1,
							@TipoUsuarioID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblUsuario 
					SET
						UsuarioLogin = @UsuarioLogin,
						UsuarioSenha = @UsuarioSenha,
						UsuarioNome = @UsuarioNome,
						UsuarioAtivo = @UsuarioAtivo,
						TipoUsuarioID = @TipoUsuarioID
					WHERE
						UsuarioID = @UsuarioID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaUsuario
	@TipoProcedure VARCHAR(10),
	@UsuarioID INT,
	@UsuarioLogin VARCHAR(15),
	@UsuarioSenha VARCHAR(32),
	@UsuarioNome  VARCHAR(60)
AS
BEGIN
	IF @TipoProcedure = 'Nome'
		BEGIN
			BEGIN TRY
				SELECT 
					u.UsuarioID,
					u.UsuarioLogin,
					u.UsuarioNome,
					u.UsuarioSenha,
					u.UsuarioAtivo,
					u.TipoUsuarioID,
					u.TipoUsuarioDescricao
				FROM
					vwUsuario AS u
				WHERE
					u.UsuarioNome LIKE '%' + @UsuarioNome + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Validar'
		BEGIN
			BEGIN TRY
				SELECT
					u.UsuarioID,
					u.UsuarioLogin,
					u.UsuarioNome
				FROM
					vwUsuario u
				WHERE
					u.UsuarioLogin = @UsuarioLogin AND u.UsuarioSenha = @UsuarioSenha AND u.UsuarioAtivo = 1
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					u.UsuarioID,
					u.UsuarioLogin,
					u.UsuarioNome,
					u.UsuarioSenha,
					u.UsuarioAtivo,
					u.TipoUsuarioID,
					u.TipoUsuarioDescricao
				FROM
					vwUsuario AS u
				WHERE
					u.UsuarioID = @UsuarioID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'ValLogin'
		BEGIN
			BEGIN TRY
				SELECT 
					u.UsuarioID
				FROM
					vwUsuario AS u
				WHERE
					u.UsuarioLogin = @UsuarioLogin
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Cidade

CREATE PROCEDURE uspConsultaCidade
	@TipoProcedure VARCHAR(10),
	@CidadeID INT,
	@EstadoID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					c.CidadeID,
					c.CidadeNome,
					c.EstadoID
				FROM
					vwCidade AS c
				WHERE
					c.CidadeID = @CidadeID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Estado'
		BEGIN
			BEGIN TRY
				SELECT 
					c.CidadeID,
					c.CidadeNome,
					c.EstadoID
				FROM
					vwCidade AS c
				WHERE
					c.EstadoID = @EstadoID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Estado

CREATE PROCEDURE uspConsultaEstado
	@TipoProcedure VARCHAR(10),
	@EstadoID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					e.EstadoID,
					e.EstadoNome,
					e.EstadoSigla
				FROM
					vwEstado AS e
				WHERE
					e.EstadoID = @EstadoID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Todos'
		BEGIN
			BEGIN TRY
				SELECT 
					e.EstadoID,
					e.EstadoNome,
					e.EstadoSigla
				FROM
					vwEstado AS e
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --ContratoAluguel

CREATE PROCEDURE uspManterContratoAluguel
	@TipoProcedure VARCHAR(10),
	@ContratoAluguelID INT,
	@ContratoAluguelDataInicial DATETIME,
	@ContratoAluguelDataFinal DATETIME,
	@ContratoAluguelValor DECIMAL(18,2),
	@PessoaID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblContratoAluguel(
							ContratoAluguelDataInicial,
							ContratoAluguelDataFinal,
							ContratoAluguelValor,
							PessoaID)
					VALUES
						(
							@ContratoAluguelDataInicial,
							@ContratoAluguelDataFinal,
							@ContratoAluguelValor,
							@PessoaID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblContratoAluguel 
					SET
						ContratoAluguelDataInicial = @ContratoAluguelDataInicial,
						ContratoAluguelDataFinal = @ContratoAluguelDataFinal,
						ContratoAluguelValor = @ContratoAluguelValor,
						PessoaID = @PessoaID
					WHERE
						ContratoAluguelID = @ContratoAluguelID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaContratoAluguel
	@TipoProcedure VARCHAR(10),
	@PastoID INT,
	@EstoqueLocalidadeID INT,
	@PessoaID INT,
	@ContratoAluguelID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					ca.ContratoAluguelID,
					ca.ContratoAluguelDataInicial,
					ca.ContratoAluguelDataFinal,
					ca.ContratoAluguelValor,
					ca.PessoaID,
					ca.QuantidadeEstoqueLocalidade,
					ca.QuantidadePasto
				FROM
					vwContratoAluguel AS ca
				WHERE
					ca.ContratoAluguelID = @ContratoAluguelID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'EstoqueL'
		BEGIN
			BEGIN TRY
				SELECT 
					ca.ContratoAluguelID,
					ca.ContratoAluguelDataInicial,
					ca.ContratoAluguelDataFinal,
					ca.ContratoAluguelValor,
					ca.PessoaID,
					ca.QuantidadeEstoqueLocalidade,
					ca.QuantidadePasto
				FROM
					vwEstoqueLocalidade AS el
				INNER JOIN
					vwContratoAluguel ca ON (el.ContratoAluguelID = ca.ContratoAluguelID)
				WHERE
					el.EstoqueLocalidadeID = @EstoqueLocalidadeID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Pasto'
		BEGIN
			BEGIN TRY
				SELECT 
					ca.ContratoAluguelID,
					ca.ContratoAluguelDataInicial,
					ca.ContratoAluguelDataFinal,
					ca.ContratoAluguelValor,
					ca.PessoaID,
					ca.QuantidadeEstoqueLocalidade,
					ca.QuantidadePasto
				FROM
					vwPasto AS p
				INNER JOIN
					vwContratoAluguel ca ON (p.ContratoAluguelID = ca.ContratoAluguelID)
				WHERE
					p.PastoID = @PastoID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Pessoa'
		BEGIN
			BEGIN TRY
				SELECT 
					ca.ContratoAluguelID,
					ca.ContratoAluguelDataInicial,
					ca.ContratoAluguelDataFinal,
					ca.ContratoAluguelValor,
					ca.PessoaID,
					ca.QuantidadeEstoqueLocalidade,
					ca.QuantidadePasto
				FROM
					vwContratoAluguel AS ca
				WHERE
					ca.PessoaID = @PessoaID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Pasto

CREATE PROCEDURE uspManterPasto
	@TipoProcedure VARCHAR(10),
	@PastoID INT,
	@PastoDescricao VARCHAR(60),
	@PastoTamanho DECIMAL(18,4),
	@PastoAtivo BIT,
	@CidadeID INT,
	@ContratoAluguelID INT = NULL
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblPasto(
							PastoDescricao,
							PastoTamanho,
							PastoAtivo,
							CidadeID,
							ContratoAluguelID)
					VALUES
						(
							@PastoDescricao,
							@PastoTamanho,
							1,
							@CidadeID,
							@ContratoAluguelID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblPasto 
					SET
						PastoDescricao = @PastoDescricao,
						PastoTamanho = @PastoTamanho,
						PastoAtivo = @PastoAtivo,
						CidadeID = @CidadeID,
						ContratoAluguelID = @ContratoAluguelID
					WHERE
						PastoID = @PastoID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END



CREATE PROCEDURE uspConsultaPasto
	@TipoProcedure VARCHAR(10),
	@PastoID INT,
	@PastoDescricao VARCHAR(60),
	@ContratoAluguelID INT,
	@CidadeID INT
AS
BEGIN
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PastoID,
					p.PastoDescricao,
					p.PastoTamanho,
					p.PastoAtivo,
					p.ContratoAluguelID,
					p.CidadeID,
					p.CidadeNome,
					p.EstadoID,
					p.EstadoNome,
					p.EstadoSigla
				FROM
					vwPasto AS p
				WHERE
					p.PastoDescricao LIKE '%' + @PastoDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Cidade'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PastoID,
					p.PastoDescricao,
					p.PastoTamanho,
					p.PastoAtivo,
					p.ContratoAluguelID,
					p.CidadeID,
					p.CidadeNome,
					p.EstadoID,
					p.EstadoNome,
					p.EstadoSigla
				FROM
					vwPasto AS p
				WHERE
					p.CidadeID = @CidadeID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'ContratoA'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PastoID,
					p.PastoDescricao,
					p.PastoTamanho,
					p.PastoAtivo,
					p.ContratoAluguelID,
					p.CidadeID,
					p.CidadeNome,
					p.EstadoID,
					p.EstadoNome,
					p.EstadoSigla
				FROM
					vwPasto AS p
				WHERE
					p.ContratoAluguelID = @ContratoAluguelID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PastoID,
					p.PastoDescricao,
					p.PastoTamanho,
					p.PastoAtivo,
					p.ContratoAluguelID,
					p.CidadeID,
					p.CidadeNome,
					p.EstadoID,
					p.EstadoNome,
					p.EstadoSigla
				FROM
					vwPasto AS p
				WHERE
					p.PastoID = @PastoID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --EstoqueLocalidade

CREATE PROCEDURE uspManterEstoqueLocalidade
	@TipoProcedure VARCHAR(10),
	@EstoqueLocalidadeID INT,
	@EstoqueLocalidadeDescricao VARCHAR(100),
	@EstoqueLocalidadeEndereco VARCHAR(60),
	@CidadeID INT,
	@ContratoAluguelID INT = NULL
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblEstoqueLocalidade(
							EstoqueLocalidadeDescricao,
							EstoqueLocalidadeEndereco,
							CidadeID,
							ContratoAluguelID)
					VALUES
						(
							@EstoqueLocalidadeDescricao,
							@EstoqueLocalidadeEndereco,
							@CidadeID,
							@ContratoAluguelID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblEstoqueLocalidade 
					SET
						EstoqueLocalidadeDescricao = @EstoqueLocalidadeDescricao,
						EstoqueLocalidadeEndereco = @EstoqueLocalidadeEndereco,
						CidadeID = @CidadeID,
						ContratoAluguelID = @ContratoAluguelID
					WHERE
						EstoqueLocalidadeID = @EstoqueLocalidadeID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaEstoqueLocalidade
	@TipoProcedure VARCHAR(10),
	@CidadeID INT,
	@EstoqueLocalidadeID INT,
	@ContratoAluguelID INT,
	@ItemID INT,
	@EstoqueLocalidadeDescricao VARCHAR(100)
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					el.EstoqueLocalidadeID,
					el.EstoqueLocalidadeDescricao,
					el.EstoqueLocalidadeEndereco,
					el.CidadeID,
					el.CidadeNome,
					el.EstadoID,
					el.EstadoNome,
					el.EstadoSigla,
					el.ContratoAluguelID
				FROM
					vwEstoqueLocalidade AS el
				WHERE
					el.EstoqueLocalidadeID = @EstoqueLocalidadeID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Cidade'
		BEGIN
			BEGIN TRY
				SELECT 
					el.EstoqueLocalidadeID,
					el.EstoqueLocalidadeDescricao,
					el.EstoqueLocalidadeEndereco,
					el.CidadeID,
					el.CidadeNome,
					el.EstadoID,
					el.EstadoNome,
					el.EstadoSigla,
					el.ContratoAluguelID
				FROM
					vwEstoqueLocalidade AS el
				WHERE
					el.CidadeID = @CidadeID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'ContratoA'
		BEGIN
			BEGIN TRY
				SELECT 
					el.EstoqueLocalidadeID,
					el.EstoqueLocalidadeDescricao,
					el.EstoqueLocalidadeEndereco,
					el.CidadeID,
					el.CidadeNome,
					el.EstadoID,
					el.EstadoNome,
					el.EstadoSigla,
					el.ContratoAluguelID
				FROM
					vwEstoqueLocalidade AS el
				WHERE
					el.ContratoAluguelID = @ContratoAluguelID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Item'
		BEGIN
			BEGIN TRY
				SELECT 
					el.EstoqueLocalidadeID,
					el.EstoqueLocalidadeDescricao,
					el.EstoqueLocalidadeEndereco,
					el.CidadeID,
					el.CidadeNome,
					el.EstadoID,
					el.EstadoNome,
					el.EstadoSigla,
					el.ContratoAluguelID
				FROM
					vwEstoqueLocalidade AS el
				INNER JOIN
					vwEstoque AS e ON (e.EstoqueLocalidadeID = el.EstoqueLocalidadeID)
				WHERE
					e.ItemID = @ItemID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					el.EstoqueLocalidadeID,
					el.EstoqueLocalidadeDescricao,
					el.EstoqueLocalidadeEndereco,
					el.CidadeID,
					el.CidadeNome,
					el.EstadoID,
					el.EstadoNome,
					el.EstadoSigla,
					el.ContratoAluguelID
				FROM
					vwEstoqueLocalidade AS el
				WHERE
					el.EstoqueLocalidadeDescricao LIKE '%' + @EstoqueLocalidadeDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --TipoItem

CREATE PROCEDURE uspManterTipoItem
	@TipoProcedure VARCHAR(10),
	@TipoItemID INT,
	@TipoItemDescricao VARCHAR(60)
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblTipoItem(
							TipoItemDescricao)
					VALUES
						(
							@TipoItemDescricao)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblTipoItem 
					SET
						TipoItemDescricao = @TipoItemDescricao
					WHERE
						TipoItemID = @TipoItemID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaTipoItem
	@TipoProcedure VARCHAR(10),
	@TipoItemID INT,
	@TipoItemDescricao VARCHAR(60)
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					ti.TipoItemID,
					ti.TipoItemDescricao
				FROM
					vwTipoItem AS ti
				WHERE
					ti.TipoItemID = @TipoItemID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					ti.TipoItemID,
					ti.TipoItemDescricao
				FROM
					vwTipoItem AS ti
				WHERE
					ti.TipoItemDescricao LIKE '%' + @TipoItemDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Item

CREATE PROCEDURE uspManterItem
	@TipoProcedure VARCHAR(10),
	@ItemID INT,
	@ItemDescricao VARCHAR(100),
	@TipoItemID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblItem(
							ItemDescricao,
							TipoItemID)
					VALUES
						(
							@ItemDescricao,
							@TipoItemID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblItem 
					SET
						ItemDescricao = @ItemDescricao,
						TipoItemID = @TipoItemID
					WHERE
						ItemID = @ItemID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaItem
	@TipoProcedure VARCHAR(10),
	@ItemID INT,
	@ItemDescricao VARCHAR(100),
	@TipoItemID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					i.ItemID,
					i.ItemDescricao,
					i.TipoItemID,
					i.TipoItemDescricao
				FROM
					vwItem AS i
				WHERE
					i.ItemID = @ItemID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					i.ItemID,
					i.ItemDescricao,
					i.TipoItemID,
					i.TipoItemDescricao
				FROM
					vwItem AS i
				WHERE
					i.ItemDescricao LIKE '%' + @ItemDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'TipoItem'
		BEGIN
			BEGIN TRY
				SELECT 
					i.ItemID,
					i.ItemDescricao,
					i.TipoItemID,
					i.TipoItemDescricao
				FROM
					vwItem AS i
				WHERE
					i.TipoItemID = @TipoItemID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Valid'
		BEGIN
			BEGIN TRY
				SELECT 
					i.ItemID,
					i.ItemDescricao,
					i.TipoItemID,
					i.TipoItemDescricao
				FROM
					vwItem AS i
				WHERE
					i.ItemDescricao = @ItemDescricao AND (i.ItemID != @ItemID OR (@ItemID = 0))
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Estoque

CREATE PROCEDURE uspManterEstoque
	@TipoProcedure VARCHAR(10),
	@EstoqueID INT,
	@EstoqueQuantidade DECIMAL(8,3),
	@EstoqueLocalidadeID INT,
	@EstoqueAtivo INT,
	@ItemID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblEstoque(
							EstoqueQuantidade,
							EstoqueLocalidadeID,
							EstoqueAtivo,
							ItemID)
					VALUES
						(
							@EstoqueQuantidade,
							@EstoqueLocalidadeID,
							1,
							@ItemID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblEstoque 
					SET
						EstoqueQuantidade = @EstoqueQuantidade,
						EstoqueAtivo = @EstoqueAtivo,
						ItemID = @ItemID
					WHERE
						EstoqueID = @EstoqueID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaEstoque
	@TipoProcedure VARCHAR(10),
	@EstoqueID INT,
	@EstoqueLocalidadeID INT,
	@ItemID INT
AS
BEGIN
	IF @TipoProcedure = 'EstoqueL'
		BEGIN
			BEGIN TRY
				SELECT 
					e.EstoqueID,
					e.EstoqueQuantidade, 
					e.EstoqueLocalidadeID,
					e.EstoqueLocalidadeDescricao, 
					e.EstoqueLocalidadeEndereco, 
					e.EstoqueAtivo,
					e.CidadeID, 
					e.CidadeNome,
					e.EstadoID, 
					e.EstadoNome, 
					e.EstadoSigla, 
					e.ItemID, 
					e.ItemDescricao,
					e.TipoItemID,
					e.TipoItemDescricao
				FROM
					vwEstoque AS e
				WHERE
					e.EstoqueLocalidadeID = @EstoqueLocalidadeID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Item'
		BEGIN
			BEGIN TRY
				SELECT 
					e.EstoqueID,
					e.EstoqueQuantidade, 
					e.EstoqueLocalidadeID,
					e.EstoqueLocalidadeDescricao, 
					e.EstoqueLocalidadeEndereco, 
					e.EstoqueAtivo,
					e.CidadeID, 
					e.CidadeNome,
					e.EstadoID, 
					e.EstadoNome, 
					e.EstadoSigla, 
					e.ItemID, 
					e.ItemDescricao,
					e.TipoItemID,
					e.TipoItemDescricao
				FROM
					vwEstoque AS e
				WHERE
					e.ItemID = @ItemID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					e.EstoqueID,
					e.EstoqueQuantidade, 
					e.EstoqueLocalidadeID,
					e.EstoqueLocalidadeDescricao, 
					e.EstoqueLocalidadeEndereco, 
					e.EstoqueAtivo,
					e.CidadeID, 
					e.CidadeNome,
					e.EstadoID, 
					e.EstadoNome, 
					e.EstadoSigla, 
					e.ItemID, 
					e.ItemDescricao,
					e.TipoItemID,
					e.TipoItemDescricao
				FROM
					vwEstoque AS e
				WHERE
					e.EstoqueID = @EstoqueID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --EntradaItem

CREATE PROCEDURE uspManterEntradaitem
	@TipoProcedure VARCHAR(10),
	@EntradaItemID INT,
	@EntradaItemDescricao VARCHAR(100),
	@EntradaItemQuantidade DECIMAL(8,3),
	@EntradaItemData DATETIME,
	@EstoqueID INT,
	@UsuarioID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblEntradaItem(
							EntradaItemDescricao,
							EntradaItemQuantidade,
							EntradaItemData,
							EstoqueID,
							UsuarioID)
					VALUES
						(
							@EntradaItemDescricao,
							@EntradaItemQuantidade,
							@EntradaItemData,
							@EstoqueID,
							@UsuarioID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblEntradaItem 
					SET
						EntradaItemDescricao = @EntradaItemDescricao
					WHERE
						EntradaItemID = @EntradaItemID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Excluir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					DELETE FROM
						tblEntradaItem
					WHERE
						EntradaItemID = @EntradaItemID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaEntradaItem
	@TipoProcedure VARCHAR(10),
	@EntradaItemID INT,
	@EntradaItemDescricao VARCHAR(100),
	@EntradaItemData DATETIME,
	@EntradaItemData2 DATETIME,
	@EstoqueID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.EntradaItemID,
					ei.EntradaItemDescricao,
					ei.EntradaItemQuantidade,
					ei.EntradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemID,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwEntradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.EntradaItemID = @EntradaItemID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataEntre'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.EntradaItemID,
					ei.EntradaItemDescricao,
					ei.EntradaItemQuantidade,
					ei.EntradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwEntradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.EntradaItemData BETWEEN @EntradaItemData AND @EntradaItemData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataApos'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.EntradaItemID,
					ei.EntradaItemDescricao,
					ei.EntradaItemQuantidade,
					ei.EntradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwEntradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.EntradaItemData > @EntradaItemData
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataAntes'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.EntradaItemID,
					ei.EntradaItemDescricao,
					ei.EntradaItemQuantidade,
					ei.EntradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwEntradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.EntradaItemData < @EntradaItemData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Estoque'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.EntradaItemID,
					ei.EntradaItemDescricao,
					ei.EntradaItemQuantidade,
					ei.EntradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwEntradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.EstoqueID = @EstoqueID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.EntradaItemID,
					ei.EntradaItemDescricao,
					ei.EntradaItemQuantidade,
					ei.EntradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwEntradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.EntradaItemDescricao LIKE '%' + @EntradaItemDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --RetiradaItem

CREATE PROCEDURE uspManterRetiradaitem
	@TipoProcedure VARCHAR(10),
	@RetiradaItemID INT,
	@RetiradaItemDescricao VARCHAR(100),
	@RetiradaItemQuantidade DECIMAL(8,3),
	@RetiradaItemData DATETIME,
	@EstoqueID INT,
	@UsuarioID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblRetiradaItem(
							RetiradaItemDescricao,
							RetiradaItemQuantidade,
							RetiradaItemData,
							EstoqueID,
							UsuarioID)
					VALUES
						(
							@RetiradaItemDescricao,
							@RetiradaItemQuantidade,
							@RetiradaItemData,
							@EstoqueID,
							@UsuarioID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblRetiradaItem 
					SET
						RetiradaItemDescricao = @RetiradaItemDescricao
					WHERE
						RetiradaItemID = @RetiradaItemID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Excluir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					DELETE FROM
						tblRetiradaItem
					WHERE
						RetiradaItemID = @RetiradaItemID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaRetiradaItem
	@TipoProcedure VARCHAR(10),
	@RetiradaItemID INT,
	@RetiradaItemDescricao VARCHAR(100),
	@RetiradaItemData DATETIME,
	@RetiradaItemData2 DATETIME
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.RetiradaItemID,
					ei.RetiradaItemDescricao,
					ei.RetiradaItemQuantidade,
					ei.RetiradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemID,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwRetiradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.RetiradaItemID = @RetiradaItemID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataEntre'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.RetiradaItemID,
					ei.RetiradaItemDescricao,
					ei.RetiradaItemQuantidade,
					ei.RetiradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwRetiradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.RetiradaItemData BETWEEN @RetiradaItemData AND @RetiradaItemData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataApos'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.RetiradaItemID,
					ei.RetiradaItemDescricao,
					ei.RetiradaItemQuantidade,
					ei.RetiradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwRetiradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.RetiradaItemData > @RetiradaItemData
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataAntes'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.RetiradaItemID,
					ei.RetiradaItemDescricao,
					ei.RetiradaItemQuantidade,
					ei.RetiradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwRetiradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.RetiradaItemData < @RetiradaItemData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					ei.RetiradaItemID,
					ei.RetiradaItemDescricao,
					ei.RetiradaItemQuantidade,
					ei.RetiradaItemData,
					ei.EstoqueID,
					ei.UsuarioID,
					ei.UsuarioNome,
					ei.TipoUsuarioDescricao,
					ei.UsuarioAtivo,
					e.ItemDescricao,
					e.TipoItemDescricao
				FROM
					vwRetiradaItem AS ei
				INNER JOIN
					vwEstoque e ON (ei.EstoqueID = e.EstoqueID)
				WHERE
					ei.RetiradaItemDescricao LIKE '%' + @RetiradaItemDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Piquete

CREATE PROCEDURE uspManterPiquete
	@TipoProcedure VARCHAR(10),
	@PiqueteID INT,
	@PiqueteDescricao VARCHAR(30),
	@PiqueteAtivo BIT,
	@PastoID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblPiquete(
							PiqueteDescricao,
							PiqueteAtivo,
							PastoID)
					VALUES
						(
							@PiqueteDescricao,
							1,
							@PastoID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblPiquete 
					SET
						PiqueteDescricao = @PiqueteDescricao,
						PiqueteAtivo = @PiqueteAtivo
					WHERE
						PiqueteID = @PiqueteID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Excluir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					DELETE FROM
						tblPiquete
					WHERE
						PiqueteID = @PiqueteID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaPiquete
	@TipoProcedure VARCHAR(10),
	@PiqueteID INT,
	@PastoID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PiqueteID,
					p.PiqueteDescricao,
					p.PiqueteAtivo,
					p.PastoID,
					(SELECT 
						COUNT(animal.AnimalID) 
					FROM 
						vwAnimal animal 
					WHERE 
						animal.PiqueteID = @PiqueteID) as PiqueteQuantidadeAnimais
				FROM
					vwPiquete AS p
				WHERE
					p.PiqueteID = @PiqueteID
				GROUP BY
					p.PiqueteID,
					p.PiqueteDescricao,
					p.PiqueteAtivo,
					p.PastoID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Pasto'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PiqueteID,
					p.PiqueteDescricao,
					p.PiqueteAtivo,
					p.PastoID,
					(SELECT 
						COUNT(animal.AnimalID) 
					FROM 
						vwAnimal animal 
					INNER JOIN 
						vwPiquete piquete ON (animal.PiqueteID = piquete.PiqueteID)
					WHERE 
						piquete.PiqueteID = p.PiqueteID) as PiqueteQuantidadeAnimais
				FROM
					vwPiquete AS p
				WHERE
					p.PastoID = @PastoID
				GROUP BY
					p.PiqueteID,
					p.PiqueteDescricao,
					p.PiqueteAtivo,
					p.PastoID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Ra�a

CREATE PROCEDURE uspManterRaca
	@TipoProcedure VARCHAR(10),
	@RacaID INT,
	@RacaNome VARCHAR(30),
	@RacaDescricao VARCHAR(60)
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblRaca(
							RacaNome,
							RacaDescricao)
					VALUES
						(
							@RacaNome,
							@RacaDescricao)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblRaca 
					SET
						RacaNome = @RacaNome,
						RacaDescricao = @RacaDescricao
					WHERE
						RacaID = @RacaID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaRaca
	@TipoProcedure VARCHAR(10),
	@RacaID INT,
	@RacaNome VARCHAR(30),
	@RacaDescricao VARCHAR(60)
AS
BEGIN
	IF @TipoProcedure = 'Nome'
		BEGIN
			BEGIN TRY
				SELECT 
					r.RacaID,
					r.RacaNome,
					r.RacaDescricao
				FROM
					vwRaca AS r
				WHERE
					r.RacaNome LIKE '%' + @RacaNome + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Valid'
		BEGIN
			BEGIN TRY
				SELECT 
					r.RacaID,
					r.RacaNome,
					r.RacaDescricao
				FROM
					vwRaca AS r
				WHERE
					r.RacaNome = @RacaNome AND (r.RacaID != @RacaID OR (@RacaID = 0))
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					r.RacaID,
					r.RacaNome,
					r.RacaDescricao
				FROM
					vwRaca AS r
				WHERE
					r.RacaDescricao LIKE '%' + @RacaDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Animal
CREATE PROCEDURE uspManterAnimal
	@TipoProcedure VARCHAR(10),
	@AnimalID INT,
	@AnimalDescricao VARCHAR(100),
	@AnimalIdentificador VARCHAR(8),
	@AnimalAtivo BIT,
	@RacaID INT,
	@PiqueteID INT,
	@AnimalParentescoPai INT = NULL,
	@AnimalParentescoMae INT = NULL,
	@AnimalLocalidadeNascimento VARCHAR(60) = NULL,
	@AnimalDataNascimento DATETIME = NULL
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblAnimal (
							AnimalDescricao,
							AnimalParentescoPai,
							AnimalParentescoMae,
							AnimalLocalidadeNascimento,
							AnimalDataNascimento,
							AnimalIdentificador,
							AnimalAtivo,
							RacaID,
							PiqueteID)
					VALUES
						(
						@AnimalDescricao,
						@AnimalParentescoPai,
						@AnimalParentescoMae,
						@AnimalLocalidadeNascimento,
						@AnimalDataNascimento,
						@AnimalIdentificador,
						@AnimalAtivo,
						@RacaID,
						@PiqueteID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblAnimal 
					SET
						AnimalDescricao = @AnimalDescricao,
						AnimalParentescoPai = @AnimalParentescoPai,
						AnimalParentescoMae = @AnimalParentescoMae,
						AnimalLocalidadeNascimento = @AnimalLocalidadeNascimento,
						AnimalIdentificador = @AnimalIdentificador,
						AnimalAtivo = @AnimalAtivo,
						RacaID = @RacaID,
						PiqueteID = @PiqueteID
					WHERE
						AnimalID = @AnimalID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaAnimal
	@TipoProcedure VARCHAR(10),
	@AnimalID INT,
	@AnimalDescricao VARCHAR(100),
	@AnimalIdentificador VARCHAR(8),
	@RacaID INT,
	@PiqueteID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					a.AnimalID,
					a.AnimalDescricao,
					a.AnimalParentescoPai,
					a.AnimalParentescoMae,
					a.AnimalLocalidadeNascimento,
					a.AnimalDataNascimento,
					a.AnimalIdentificador,
					a.AnimalAtivo,
					a.RacaID,
					a.RacaNome,
					a.RacaDescricao,
					up.PesagemID,
					pqt.PiqueteID,
					pqt.PiqueteDescricao,
					p.PastoID,
					p.PastoDescricao,
					p.PastoTamanho,
					p.CidadeID,
					p.CidadeNome,
					p.EstadoID,
					p.EstadoSigla,
					p.EstadoNome
				FROM
					vwAnimal AS a
				LEFT JOIN 
					vwUltimaPesagemAnimal up ON (a.AnimalID = up.AnimalID)
				LEFT JOIN
					vwPiquete pqt ON (a.PiqueteID = pqt.PiqueteID)
				LEFT JOIN
					vwPasto p ON (pqt.PastoID = p.PastoID)
				WHERE
					a.AnimalID = @AnimalID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					a.AnimalID,
					a.AnimalDescricao,
					a.AnimalParentescoPai,
					a.AnimalParentescoMae,
					a.AnimalLocalidadeNascimento,
					a.AnimalDataNascimento,
					a.AnimalIdentificador,
					a.AnimalAtivo,
					a.RacaID,
					a.RacaNome,
					up.PesagemID,
					pqt.PiqueteID,
					pqt.PiqueteDescricao,
					p.PastoDescricao
				FROM
					vwAnimal AS a
				LEFT JOIN 
					vwUltimaPesagemAnimal up ON (a.AnimalID = up.AnimalID)
				LEFT JOIN
					vwPiquete pqt ON (a.PiqueteID = pqt.PiqueteID)
				LEFT JOIN
					vwPasto p ON (pqt.PastoID = p.PastoID)
				WHERE
					a.AnimalDescricao LIKE '%' + @AnimalDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Ident'
		BEGIN
			BEGIN TRY
				SELECT 
					a.AnimalID,
					a.AnimalDescricao,
					a.AnimalParentescoPai,
					a.AnimalParentescoMae,
					a.AnimalLocalidadeNascimento,
					a.AnimalDataNascimento,
					a.AnimalIdentificador,
					a.AnimalAtivo,
					a.RacaID,
					a.RacaNome,
					up.PesagemID,
					pqt.PiqueteID,
					pqt.PiqueteDescricao,
					p.PastoDescricao
				FROM
					vwAnimal AS a
				LEFT JOIN 
					vwUltimaPesagemAnimal up ON (a.AnimalID = up.AnimalID)
				LEFT JOIN
					vwPiquete pqt ON (a.PiqueteID = pqt.PiqueteID)
				LEFT JOIN
					vwPasto p ON (pqt.PastoID = p.PastoID)
				WHERE
					a.AnimalIdentificador = @AnimalIdentificador
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Piquete'
		BEGIN
			BEGIN TRY
				SELECT 
					a.AnimalID,
					a.AnimalDescricao,
					a.AnimalParentescoPai,
					a.AnimalParentescoMae,
					a.AnimalLocalidadeNascimento,
					a.AnimalDataNascimento,
					a.AnimalIdentificador,
					a.AnimalAtivo,
					a.RacaID,
					a.RacaNome,
					up.PesagemID,
					pqt.PiqueteID,
					pqt.PiqueteDescricao,
					p.PastoDescricao
				FROM
					vwAnimal AS a
				LEFT JOIN 
					vwUltimaPesagemAnimal up ON (a.AnimalID = up.AnimalID)
				LEFT JOIN
					vwPiquete pqt ON (a.PiqueteID = pqt.PiqueteID)
				LEFT JOIN
					vwPasto p ON (pqt.PastoID = p.PastoID)
				WHERE
					a.PiqueteID = @PiqueteID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END		
	IF @TipoProcedure = 'Raca'
		BEGIN
			BEGIN TRY
				SELECT 
					a.AnimalID,
					a.AnimalDescricao,
					a.AnimalParentescoPai,
					a.AnimalParentescoMae,
					a.AnimalLocalidadeNascimento,
					a.AnimalDataNascimento,
					a.AnimalIdentificador,
					a.AnimalAtivo,
					a.RacaID,
					a.RacaNome,
					up.PesagemID,
					pqt.PiqueteID,
					pqt.PiqueteDescricao,
					p.PastoDescricao
				FROM
					vwAnimal AS a
				LEFT JOIN 
					vwUltimaPesagemAnimal up ON (a.AnimalID = up.AnimalID)
				LEFT JOIN
					vwPiquete pqt ON (a.PiqueteID = pqt.PiqueteID)
				LEFT JOIN
					vwPasto p ON (pqt.PastoID = p.PastoID)
				WHERE
					a.RacaID = @RacaID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Pessoa
	
CREATE PROCEDURE uspCadastrarPessoa
	@PessoaEndereco VARCHAR(60),
	@PessoaBairro VARCHAR(50),
	@PessoaTelefone VARCHAR(15),
	@PessoaAtivo BIT,
	@CidadeID INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			INSERT
				tblPessoa (
					PessoaEndereco,
					PessoaBairro,
					PessoaTelefone,
					PessoaAtivo,
					CidadeID)
			VALUES
				(
					@PessoaEndereco,
					@PessoaBairro,
					@PessoaTelefone,
					@PessoaAtivo,
					@CidadeID)
			SELECT @@IDENTITY AS Retorno
			COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END




CREATE PROCEDURE uspAlterarPessoa
	@PessoaID INT,
	@PessoaEndereco VARCHAR(60),
	@PessoaBairro VARCHAR(50),
	@PessoaTelefone VARCHAR(15),
	@PessoaAtivo BIT,
	@CidadeID INT
AS
BEGIN
	BEGIN TRY
				
		BEGIN TRAN
			UPDATE
				tblPessoa
			SET
				PessoaEndereco = @PessoaEndereco,
				PessoaBairro = @PessoaBairro,
				PessoaTelefone = @PessoaTelefone,
				PessoaAtivo = @PessoaAtivo,
				CidadeID = @CidadeID
			WHERE
				PessoaID = @PessoaID
			SELECT @@IDENTITY AS Retorno
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END


CREATE PROCEDURE uspConsultarPessoa
	@PessoaID INT
AS
BEGIN
	BEGIN
		BEGIN TRY
			SELECT 
				p.PessoaID,
				p.PessoaEndereco,
				p.PessoaBairro,
				p.PessoaTelefone,
				p.PessoaAtivo,
				c.CidadeID,
				c.CidadeNome,
				e.EstadoID,
				e.EstadoNome,
				e.EstadoSigla,
				pf.PessoaFisicaCPF,
				pf.PessoaFisicaNome,
				pj.PessoaJuridicaCNPJ,
				pj.PessoaJuridicaRazaoSocial,
				pj.PessoaJuridicaNomeFicticio
			FROM
				tblPessoa p
			LEFT JOIN
				tblPessoaFisica pf ON (p.PessoaID = pf.PessoaID)
			LEFT JOIN
				tblPessoaJuridica pj ON (p.PessoaID = pj.PessoaID)
			LEFT JOIN 
				tblCidade c ON (p.CidadeID = c.CidadeID)
			LEFT JOIN
				tblEstado e ON (c.EstadoID = e.EstadoID)
			WHERE
				p.PessoaID = @PessoaID
		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS Retorno
		END CATCH
	END
END

END




BEGIN --PessoaFisica

CREATE PROCEDURE uspManterPessoaFisica
	@TipoProcedure VARCHAR(10),
	@PessoaFisicaCPF VARCHAR(14),
	@PessoaFisicaNome VARCHAR(60),
	@PessoaID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblPessoaFisica (
							PessoaFisicaCPF,
							PessoaID,
							PessoaFisicaNome)
					VALUES
						(
							@PessoaFisicaCPF,
							@PessoaID,
							@PessoaFisicaNome)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblPessoaFisica 
					SET
						PessoaFisicaNome = @PessoaFisicaNome
					WHERE
						PessoaFisicaCPF = @PessoaFisicaCPF
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Excluir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					DELETE FROM
						tblPessoaFisica 
					WHERE
						PessoaFisicaCPF = @PessoaFisicaCPF
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaPessoaFisica
	@TipoProcedure VARCHAR(10),
	@PessoaFisicaCPF VARCHAR(14),
	@PessoaFisicaNome VARCHAR(60)
AS
BEGIN
	IF @TipoProcedure = 'CPF'
		BEGIN
			BEGIN TRY
				SELECT 
					pf.PessoaFisicaCPF,
					pf.PessoaFisicaNome,
					pf.PessoaID,
					pf.PessoaEndereco,
					pf.PessoaBairro,
					pf.PessoaTelefone,
					pf.PessoaAtivo,
					pf.CidadeID,
					pf.CidadeNome,
					pf.EstadoID,
					pf.EstadoNome,
					pf.EstadoSigla
					
				FROM
					vwPessoaFisica AS pf
				WHERE
					pf.PessoaFisicaCPF = @PessoaFisicaCPF
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Nome'
		BEGIN
			BEGIN TRY
				SELECT 
					pf.PessoaFisicaCPF,
					pf.PessoaFisicaNome,
					pf.PessoaID,
					pf.PessoaEndereco,
					pf.PessoaBairro,
					pf.PessoaTelefone,
					pf.PessoaAtivo,
					pf.CidadeID,
					pf.CidadeNome,
					pf.EstadoID,
					pf.EstadoNome,
					pf.EstadoSigla
					
				FROM
					vwPessoaFisica AS pf
				WHERE
					pf.PessoaFisicaNome LIKE '%' + @PessoaFisicaNome + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --PessoaJuridica

CREATE PROCEDURE uspManterPessoaJuridica
	@TipoProcedure VARCHAR(10),
	@PessoaJuridicaCNPJ VARCHAR(20),
	@PessoaJuridicaRazaoSocial VARCHAR(50),
	@PessoaJuridicaNomeFicticio VARCHAR(60),
	@PessoaID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblPessoaJuridica(
							PessoaJuridicaCNPJ,
							PessoaJuridicaRazaoSocial,
							PessoaJuridicaNomeFicticio,
							PessoaID)
					VALUES
						(
							@PessoaJuridicaCNPJ,
							@PessoaJuridicaRazaoSocial,
							@PessoaJuridicaNomeFicticio,
							@PessoaID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblPessoaJuridica 
					SET
						PessoaJuridicaRazaoSocial = @PessoaJuridicaRazaoSocial,
						PessoaJuridicaNomeFicticio = @PessoaJuridicaNomeFicticio
					WHERE
						PessoaJuridicaCNPJ = @PessoaJuridicaCNPJ
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Excluir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					DELETE FROM
						tblPessoaJuridica 
					WHERE
						PessoaJuridicaCNPJ = @PessoaJuridicaCNPJ
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaPessoaJuridica
	@TipoProcedure VARCHAR(10),
	@PessoaJuridicaCNPJ VARCHAR(20),
	@PessoaJuridicaRazaoSocial VARCHAR(50),
	@PessoaJuridicaNomeFicticio VARCHAR(60)
AS
BEGIN
	IF @TipoProcedure = 'CNPJ'
		BEGIN
			BEGIN TRY
				SELECT 
					pj.PessoaJuridicaCNPJ,
					pj.PessoaJuridicaRazaoSocial,
					pj.PessoaJuridicaNomeFicticio,
					pj.PessoaID,
					pj.PessoaEndereco,
					pj.PessoaBairro,
					pj.PessoaTelefone,
					pj.PessoaAtivo,
					pj.CidadeID,
					pj.CidadeNome,
					pj.EstadoID,
					pj.EstadoNome,
					pj.EstadoSigla
				FROM
					vwPessoaJuridica AS pj
				WHERE
					pj.PessoaJuridicaCNPJ = @PessoaJuridicaCNPJ
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'RazaoS'
		BEGIN
			BEGIN TRY
				SELECT 
					pj.PessoaJuridicaCNPJ,
					pj.PessoaJuridicaRazaoSocial,
					pj.PessoaJuridicaNomeFicticio,
					pj.PessoaID,
					pj.PessoaEndereco,
					pj.PessoaBairro,
					pj.PessoaTelefone,
					pj.PessoaAtivo,
					pj.CidadeID,
					pj.CidadeNome,
					pj.EstadoID,
					pj.EstadoNome,
					pj.EstadoSigla
				FROM
					vwPessoaJuridica AS pj
				WHERE
					pj.PessoaJuridicaRazaoSocial LIKE '%' + @PessoaJuridicaRazaoSocial + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'NomeF'
		BEGIN
			BEGIN TRY
				SELECT 
					pj.PessoaJuridicaCNPJ,
					pj.PessoaJuridicaRazaoSocial,
					pj.PessoaJuridicaNomeFicticio,
					pj.PessoaID,
					pj.PessoaEndereco,
					pj.PessoaBairro,
					pj.PessoaTelefone,
					pj.PessoaAtivo,
					pj.CidadeID,
					pj.CidadeNome,
					pj.EstadoID,
					pj.EstadoNome,
					pj.EstadoSigla
				FROM
					vwPessoaJuridica AS pj
				WHERE
					pj.PessoaJuridicaNomeFicticio LIKE '%' + @PessoaJuridicaNomeFicticio + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Pesagem

CREATE PROCEDURE uspManterPesagem
	@TipoProcedure VARCHAR(10),
	@PesagemID INT,
	@PesagemData DATETIME,
	@PesagemPeso DECIMAL(8,3),
	@AnimalID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblPesagem(
							PesagemData,
							PesagemPeso,
							AnimalID)
					VALUES
						(
							@PesagemData,
							@PesagemPeso,
							@AnimalID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblPesagem 
					SET
						PesagemData = @PesagemData,
						PesagemPeso = @PesagemPeso
					WHERE
						PesagemID = @PesagemID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaPesagem
	@TipoProcedure VARCHAR(10),
	@AnimalID INT,
	@PesagemData DATE,
	@PesagemData2 DATE
AS
BEGIN
	IF @TipoProcedure = 'Animal'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PesagemID,
					p.PesagemData,
					p.PesagemPeso,
					p.AnimalID,
					p.AnimalDescricao
				FROM
					vwPesagem AS p
				WHERE
					p.AnimalID = @AnimalID
				ORDER BY
					p.PesagemData DESC
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Apos'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PesagemID,
					p.PesagemData,
					p.PesagemPeso,
					p.AnimalID,
					p.AnimalDescricao
				FROM
					vwPesagem AS p
				WHERE
					p.PesagemData > @PesagemData
				ORDER BY
					p.PesagemData DESC
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Antes'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PesagemID,
					p.PesagemData,
					p.PesagemPeso,
					p.AnimalID,
					p.AnimalDescricao
				FROM
					vwPesagem AS p
				WHERE
					p.PesagemData < @PesagemData2
				ORDER BY
					p.PesagemData DESC
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Entre'
		BEGIN
			BEGIN TRY
				SELECT 
					p.PesagemID,
					p.PesagemData,
					p.PesagemPeso,
					p.AnimalID,
					p.AnimalDescricao
				FROM
					vwPesagem AS p
				WHERE
					p.PesagemData BETWEEN @PesagemData AND @PesagemData2
				ORDER BY
					p.PesagemData DESC
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'RAposRaca'
		BEGIN
			BEGIN TRY
				SELECT 
					SUM(ps.PesagemPeso) as PesagemPeso, r.RacaNome
				FROM 
					vwUltimaPesagemAnimal upa
				INNER JOIN tblRaca r ON (upa.RacaID = r.RacaID)
				INNER JOIN tblPesagem ps ON (ps.PesagemID = upa.PesagemID)
				WHERE
					ps.PesagemData > @PesagemData
				GROUP BY 
					r.RacaNome
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'RAntesRaca'
		BEGIN
			BEGIN TRY
				SELECT 
					SUM(ps.PesagemPeso) as PesagemPeso, r.RacaNome
				FROM 
					vwUltimaPesagemAnimal upa
				INNER JOIN tblRaca r ON (upa.RacaID = r.RacaID)
				INNER JOIN tblPesagem ps ON (ps.PesagemID = upa.PesagemID)
				WHERE
					ps.PesagemData < @PesagemData2
				GROUP BY 
					r.RacaNome
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'REntreRaca'
		BEGIN
			BEGIN TRY
				SELECT 
					SUM(ps.PesagemPeso) as PesagemPeso, r.RacaNome
				FROM 
					vwUltimaPesagemAnimal upa
				INNER JOIN tblRaca r ON (upa.RacaID = r.RacaID)
				INNER JOIN tblPesagem ps ON (ps.PesagemID = upa.PesagemID)
				WHERE
					ps.PesagemData BETWEEN @PesagemData AND @PesagemData2
				GROUP BY 
					r.RacaNome
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Veterinario

CREATE PROCEDURE uspManterVeterinario
	@TipoProcedure VARCHAR(10),
	@VeterinarioID INT,
	@VeterinarioCRMV VARCHAR(30),
	@VeterinarioNome VARCHAR(60),
	@VeterinarioTelefone VARCHAR(15),
	@VeterinarioBairro VARCHAR(30),
	@VeterinarioEndereco VARCHAR(50),
	@VeterinarioAtivo BIT,
	@CidadeID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblVeterinario(
							VeterinarioCRMV,
							VeterinarioNome,
							VeterinarioTelefone,
							VeterinarioBairro,
							VeterinarioEndereco,
							VeterinarioAtivo,
							CidadeID)
					VALUES
						(
							@VeterinarioCRMV,
							@VeterinarioNome,
							@VeterinarioTelefone,
							@VeterinarioBairro,
							@VeterinarioEndereco,
							@VeterinarioAtivo,
							@CidadeID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblVeterinario 
					SET
						VeterinarioCRMV = @VeterinarioCRMV,
						VeterinarioNome = @VeterinarioNome,
						VeterinarioTelefone = @VeterinarioTelefone,
						VeterinarioBairro = @VeterinarioBairro,
						VeterinarioEndereco = @VeterinarioEndereco,
						VeterinarioAtivo = @VeterinarioAtivo,
						CidadeID = @CidadeID
					WHERE
						VeterinarioID = @VeterinarioID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaVeterinario
	@TipoProcedure VARCHAR(10),
	@VeterinarioNome VARCHAR(60),
	@VeterinarioID INT
AS
BEGIN
	IF @TipoProcedure = 'Nome'
		BEGIN
			BEGIN TRY
				SELECT 
				v.VeterinarioID,
				v.VeterinarioCRMV,
				v.VeterinarioNome,
				v.VeterinarioTelefone,
				v.VeterinarioBairro,
				v.VeterinarioEndereco,
				v.VeterinarioAtivo,
				v.CidadeID,
				v.CidadeNome,
				v.EstadoID,
				v.EstadoSigla,
				v.EstadoNome
				FROM
					vwVeterinario AS v
				WHERE
					v.VeterinarioNome LIKE '%' + @VeterinarioNome + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
				v.VeterinarioID,
				v.VeterinarioCRMV,
				v.VeterinarioNome,
				v.VeterinarioTelefone,
				v.VeterinarioBairro,
				v.VeterinarioEndereco,
				v.VeterinarioAtivo,
				v.CidadeID,
				v.CidadeNome,
				v.EstadoID,
				v.EstadoSigla,
				v.EstadoNome
				FROM
					vwVeterinario AS v
				WHERE
					v.VeterinarioID = @VeterinarioID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Consulta Veterinaria

CREATE PROCEDURE uspManterConsultaVeterinaria
	@TipoProcedure VARCHAR(10),
	@ConsultaVeterinariaID INT,
	@ConsultaVeterinariaData DATETIME,
	@ConsultaVeterinariaDescricao VARCHAR(300),
	@ConsultaVeterinariaCusto DECIMAL(18,2),
	@AnimalID INT

AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblConsultaVeterinaria(
							ConsultaVeterinariaData,
							ConsultaVeterinariaDescricao,
							ConsultaVeterinariaCusto,
							AnimalID)
					VALUES
						(
							@ConsultaVeterinariaData,
							@ConsultaVeterinariaDescricao,
							@ConsultaVeterinariaCusto,
							@AnimalID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblConsultaVeterinaria 
					SET
							ConsultaVeterinariaData = @ConsultaVeterinariaData,
							ConsultaVeterinariaDescricao = @ConsultaVeterinariaDescricao,
							ConsultaVeterinariaCusto = @ConsultaVeterinariaCusto,
							AnimalID = @AnimalID
					WHERE
						ConsultaVeterinariaID = @ConsultaVeterinariaID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaConsultaVeterinario
	@TipoProcedure VARCHAR(10),
	@ConsultaVeterinariaID INT,
	@ConsultaVeterinariaData DATETIME,
	@ConsultaVeterinariaData2 DATETIME,
	@ConsultaVeterinariaDescricao VARCHAR(300),
	@AnimalID INT,
	@VeterinarioID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					cv.ConsultaVeterinariaID,
					cv.ConsultaVeterinariaData,
					cv.ConsultaVeterinariaDescricao,
					cv.ConsultaVeterinariaCusto, 
					cv.AnimalID,
					cv.AnimalDescricao,
					cv.AnimalLocalidadeNascimento,
					cv.AnimalDataNascimento,
					cv.AnimalIdentificador,
					cv.PiqueteID,
					cv.AnimalAtivo, 
					cv.RacaID,
					cv.RacaNome,
					cv.RacaDescricao
				FROM
					vwConsultaVeterinaria AS cv
				WHERE
					cv.ConsultaVeterinariaID = @ConsultaVeterinariaID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Animal'
		BEGIN
			BEGIN TRY
				SELECT 
					cv.ConsultaVeterinariaID,
					cv.ConsultaVeterinariaData,
					cv.ConsultaVeterinariaDescricao,
					cv.ConsultaVeterinariaCusto, 
					cv.AnimalID,
					cv.AnimalDescricao,
					cv.AnimalLocalidadeNascimento,
					cv.AnimalDataNascimento,
					cv.AnimalIdentificador,
					cv.PiqueteID,
					cv.AnimalAtivo, 
					cv.RacaID,
					cv.RacaNome,
					cv.RacaDescricao
				FROM
					vwConsultaVeterinaria AS cv
				WHERE
					cv.AnimalID = @AnimalID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataEntre'
		BEGIN
			BEGIN TRY
				SELECT 
					cv.ConsultaVeterinariaID,
					cv.ConsultaVeterinariaData,
					cv.ConsultaVeterinariaDescricao,
					cv.ConsultaVeterinariaCusto, 
					cv.AnimalID,
					cv.AnimalDescricao,
					cv.AnimalLocalidadeNascimento,
					cv.AnimalDataNascimento,
					cv.AnimalIdentificador,
					cv.PiqueteID,
					cv.AnimalAtivo, 
					cv.RacaID,
					cv.RacaNome,
					cv.RacaDescricao
				FROM
					vwConsultaVeterinaria AS cv
				WHERE
					cv.ConsultaVeterinariaData BETWEEN @ConsultaVeterinariaData AND @ConsultaVeterinariaData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataApos'
		BEGIN
			BEGIN TRY
				SELECT 
					cv.ConsultaVeterinariaID,
					cv.ConsultaVeterinariaData,
					cv.ConsultaVeterinariaDescricao,
					cv.ConsultaVeterinariaCusto, 
					cv.AnimalID,
					cv.AnimalDescricao,
					cv.AnimalLocalidadeNascimento,
					cv.AnimalDataNascimento,
					cv.AnimalIdentificador,
					cv.PiqueteID,
					cv.AnimalAtivo, 
					cv.RacaID,
					cv.RacaNome,
					cv.RacaDescricao
				FROM
					vwConsultaVeterinaria AS cv
				WHERE
					cv.ConsultaVeterinariaData > @ConsultaVeterinariaData
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataAntes'
		BEGIN
			BEGIN TRY
				SELECT 
					cv.ConsultaVeterinariaID,
					cv.ConsultaVeterinariaData,
					cv.ConsultaVeterinariaDescricao,
					cv.ConsultaVeterinariaCusto, 
					cv.AnimalID,
					cv.AnimalDescricao,
					cv.AnimalLocalidadeNascimento,
					cv.AnimalDataNascimento,
					cv.AnimalIdentificador,
					cv.PiqueteID,
					cv.AnimalAtivo, 
					cv.RacaID,
					cv.RacaNome,
					cv.RacaDescricao
				FROM
					vwConsultaVeterinaria AS cv
				WHERE
					cv.ConsultaVeterinariaData < @ConsultaVeterinariaData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Descricao'
		BEGIN
			BEGIN TRY
				SELECT 
					cv.ConsultaVeterinariaID,
					cv.ConsultaVeterinariaData,
					cv.ConsultaVeterinariaDescricao,
					cv.ConsultaVeterinariaCusto, 
					cv.AnimalID,
					cv.AnimalDescricao,
					cv.AnimalLocalidadeNascimento,
					cv.AnimalDataNascimento,
					cv.AnimalIdentificador,
					cv.PiqueteID,
					cv.AnimalAtivo, 
					cv.RacaID,
					cv.RacaNome,
					cv.RacaDescricao
				FROM
					vwConsultaVeterinaria AS cv
				WHERE
					cv.ConsultaVeterinariaDescricao LIKE '%' + @ConsultaVeterinariaDescricao + '%'
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Vet'
		BEGIN
			BEGIN TRY
				SELECT 
					cv.ConsultaVeterinariaID,
					cv.ConsultaVeterinariaData,
					cv.ConsultaVeterinariaDescricao,
					cv.ConsultaVeterinariaCusto, 
					cv.AnimalID,
					cv.AnimalDescricao,
					cv.AnimalLocalidadeNascimento,
					cv.AnimalDataNascimento,
					cv.AnimalIdentificador,
					cv.PiqueteID,
					cv.AnimalAtivo, 
					cv.RacaID,
					cv.RacaNome,
					cv.RacaDescricao
				FROM
					vwConsultaVeterinaria AS cv
				INNER JOIN
					vwListaVeterinario lv ON (cv.ConsultaVeterinariaID = lv.ConsultaVeterinariaID)
				WHERE
					lv.VeterinarioID = @VeterinarioID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Lista Veterin�rio

CREATE PROCEDURE uspManterListaVeterinario
	@TipoProcedure VARCHAR(10),
	@ConsultaVeterinariaID INT,
	@VeterinarioID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblListaVeterinario(
							ConsultaVeterinariaID,
							VeterinarioID)
					VALUES
						(
							@ConsultaVeterinariaID,
							@VeterinarioID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaListaVeterinario
	@TipoProcedure VARCHAR(10),
	@ConsultaVeterinariaID INT,
	@VeterinarioID INT
AS
BEGIN
	IF @TipoProcedure = 'ConsultaV'
		BEGIN
			BEGIN TRY
				SELECT 
					lv.ListaVeterinarioID,
					lv.ConsultaVeterinariaID,
					lv.VeterinarioID,
					lv.VeterinarioCRMV,
					lv.VeterinarioBairro,
					lv.VeterinarioAtivo,
					lv.VeterinarioTelefone,
					lv.VeterinarioNome,
					lv.VeterinarioEndereco,
					lv.CidadeID,
					lv.CidadeNome,
					lv.EstadoID,
					lv.EstadoNome,
					lv.EstadoSigla
				FROM
					vwListaVeterinario AS lv
				WHERE
					lv.ConsultaVeterinariaID = @ConsultaVeterinariaID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


END




BEGIN --Compra e Lista Compra

CREATE PROCEDURE uspManterCompra
	@TipoProcedure VARCHAR(10),
	@CompraID INT,
	@CompraData DATETIME,
	@CompraDataEntrega DATETIME,
	@CompraValorTotal DECIMAL(18,2),
	@PessoaID INT,
	@UsuarioID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblCompra(
							CompraData,
							CompraDataEntrega,
							CompraValorTotal,
							PessoaID,
							UsuarioID)
					VALUES
						(
							@CompraData,
							@CompraDataEntrega,
							@CompraValorTotal,
							@PessoaID,
							@UsuarioID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblCompra 
					SET
						CompraDataEntrega = @CompraDataEntrega,
						CompraValorTotal = @CompraValorTotal
					WHERE
						CompraID = @CompraID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaCompra
	@TipoProcedure VARCHAR(10),
	@CompraID INT,
	@CompraData DATETIME,
	@CompraData2 DATETIME,
	@PessoaID INT,
	@UsuarioID INT,
	@AnimalID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					c.CompraID, c.CompraData, c.CompraDataEntrega, c.CompraValorTotal, c.PessoaID, c.UsuarioID, c.UsuarioNome, c.QuantidadeAnimais
				FROM
					vwCompra AS c
				WHERE
					c.CompraID = @CompraID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataEntre'
		BEGIN
			BEGIN TRY
				SELECT 
					c.CompraID, c.CompraData, c.CompraDataEntrega, c.CompraValorTotal, c.PessoaID, c.UsuarioID, c.UsuarioNome, c.QuantidadeAnimais
				FROM
					vwCompra AS c
				WHERE
					c.CompraData BETWEEN @CompraData AND @CompraData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataApos'
		BEGIN
			BEGIN TRY
				SELECT 
					c.CompraID, c.CompraData, c.CompraDataEntrega, c.CompraValorTotal, c.PessoaID, c.UsuarioID, c.UsuarioNome, c.QuantidadeAnimais
				FROM
					vwCompra AS c
				WHERE
					c.CompraData > @CompraData
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataAntes'
		BEGIN
			BEGIN TRY
				SELECT 
					c.CompraID, c.CompraData, c.CompraDataEntrega, c.CompraValorTotal, c.PessoaID, c.UsuarioID, c.UsuarioNome, c.QuantidadeAnimais
				FROM
					vwCompra AS c
				WHERE
					c.CompraData < @CompraData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Pessoa'
		BEGIN
			BEGIN TRY
				SELECT 
					c.CompraID, c.CompraData, c.CompraDataEntrega, c.CompraValorTotal, c.PessoaID, c.UsuarioID, c.UsuarioNome, c.QuantidadeAnimais
				FROM
					vwCompra AS c
				WHERE
					c.PessoaID = @PessoaID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Usuario'
		BEGIN
			BEGIN TRY
				SELECT 
					c.CompraID, c.CompraData, c.CompraDataEntrega, c.CompraValorTotal, c.PessoaID, c.UsuarioID, c.UsuarioNome, c.QuantidadeAnimais
				FROM
					vwCompra AS c
				WHERE
					c.UsuarioID = @UsuarioID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Animal'
		BEGIN
			BEGIN TRY
				SELECT 
					c.CompraID, c.CompraData, c.CompraDataEntrega, c.CompraValorTotal, c.PessoaID, c.UsuarioID, c.UsuarioNome, c.QuantidadeAnimais
				FROM
					vwCompra AS c
				LEFT JOIN
					vwListaCompra lc ON (c.CompraID = lc.CompraID)
				WHERE
					lc.AnimalID = @AnimalID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspManterListaCompra
	@TipoProcedure VARCHAR(10),
	@ListaCompraID INT,
	@ListaCompraValor DECIMAL(9,2),
	@CompraID INT,
	@AnimalID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblListaCompra(
							ListaCompraValor,
							CompraID,
							AnimalID)
					VALUES
						(
							@ListaCompraValor,
							@CompraID,
							@AnimalID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblListaCompra 
					SET
						ListaCompraValor = @ListaCompraValor
					WHERE
						ListaCompraID = @ListaCompraID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Excluir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					DELETE FROM
						tblListaCompra 
					WHERE
						ListaCompraID = @ListaCompraID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaListaCompra
	@TipoProcedure VARCHAR(10),
	@CompraID INT,
	@AnimalID INT
AS
BEGIN
	IF @TipoProcedure = 'Compra'
		BEGIN
			BEGIN TRY
				SELECT 
					lc.ListaCompraID, lc.ListaCompraValor, lc.CompraID,
					lc.AnimalID, lc.AnimalDescricao, lc.AnimalDataNascimento,
					lc.AnimalIdentificador, lc.RacaNome
				FROM
					vwListaCompra AS lc
				WHERE
					lc.CompraID = @CompraID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Animal'
		BEGIN
			BEGIN TRY
				SELECT 
					lc.ListaCompraID, lc.ListaCompraValor, lc.CompraID,
					lc.AnimalID, lc.AnimalDescricao, lc.AnimalDataNascimento,
					lc.AnimalIdentificador, lc.RacaNome
				FROM
					vwListaCompra AS lc
				WHERE
					lc.AnimalID = @AnimalID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
		
END

END




BEGIN --Venda e Lista Venda

CREATE PROCEDURE uspManterVenda
	@TipoProcedure VARCHAR(10),
	@VendaID INT,
	@VendaData DATETIME,
	@VendaDataEntrega DATETIME,
	@VendaValorTotal DECIMAL(18,2),
	@PessoaID INT,
	@UsuarioID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblVenda(
							VendaData,
							VendaDataEntrega,
							VendaValorTotal,
							PessoaID,
							UsuarioID)
					VALUES
						(
							@VendaData,
							@VendaDataEntrega,
							@VendaValorTotal,
							@PessoaID,
							@UsuarioID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblVenda 
					SET
						VendaDataEntrega = @VendaDataEntrega,
						VendaValorTotal = @VendaValorTotal
					WHERE
						VendaID = @VendaID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaVenda
	@TipoProcedure VARCHAR(10),
	@VendaID INT,
	@VendaData DATETIME,
	@VendaData2 DATETIME,
	@PessoaID INT,
	@UsuarioID INT,
	@AnimalID INT
AS
BEGIN
	IF @TipoProcedure = 'ID'
		BEGIN
			BEGIN TRY
				SELECT 
					v.VendaID, v.VendaData, v.VendaDataEntrega, v.VendaValorTotal, v.PessoaID, v.UsuarioID, v.UsuarioNome, v.QuantidadeAnimais
				FROM
					vwVenda AS v
				WHERE
					v.VendaID = @VendaID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataEntre'
		BEGIN
			BEGIN TRY
				SELECT 
					v.VendaID, v.VendaData, v.VendaDataEntrega, v.VendaValorTotal, v.PessoaID, v.UsuarioID, v.UsuarioNome, v.QuantidadeAnimais
				FROM
					vwVenda AS v
				WHERE
					v.VendaData BETWEEN @VendaData AND @VendaData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataApos'
		BEGIN
			BEGIN TRY
				SELECT 
					v.VendaID, v.VendaData, v.VendaDataEntrega, v.VendaValorTotal, v.PessoaID, v.UsuarioID, v.UsuarioNome, v.QuantidadeAnimais
				FROM
					vwVenda AS v
				WHERE
					v.VendaData > @VendaData
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'DataAntes'
		BEGIN
			BEGIN TRY
				SELECT 
					v.VendaID, v.VendaData, v.VendaDataEntrega, v.VendaValorTotal, v.PessoaID, v.UsuarioID, v.UsuarioNome, v.QuantidadeAnimais
				FROM
					vwVenda AS v
				WHERE
					v.VendaData < @VendaData2
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Pessoa'
		BEGIN
			BEGIN TRY
				SELECT 
					v.VendaID, v.VendaData, v.VendaDataEntrega, v.VendaValorTotal, v.PessoaID, v.UsuarioID, v.UsuarioNome, v.QuantidadeAnimais
				FROM
					vwVenda AS v
				WHERE
					v.PessoaID = @PessoaID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Usuario'
		BEGIN
			BEGIN TRY
				SELECT 
					v.VendaID, v.VendaData, v.VendaDataEntrega, v.VendaValorTotal, v.PessoaID, v.UsuarioID, v.UsuarioNome, v.QuantidadeAnimais
				FROM
					vwVenda AS v
				WHERE
					v.UsuarioID = @UsuarioID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Animal'
		BEGIN
			BEGIN TRY
				SELECT 
					v.VendaID, v.VendaData, v.VendaDataEntrega, v.VendaValorTotal, v.PessoaID, v.UsuarioID, v.UsuarioNome, v.QuantidadeAnimais
				FROM
					vwVenda AS v
				INNER JOIN
					vwListaVenda lv ON (v.VendaID = lv.VendaID)
				WHERE
					lv.AnimalID = @AnimalID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspManterListaVenda
	@TipoProcedure VARCHAR(10),
	@ListaVendaID INT,
	@ListaVendaValor DECIMAL(9,2),
	@VendaID INT,
	@AnimalID INT
AS
BEGIN
	IF @TipoProcedure = 'Inserir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					INSERT
						tblListaVenda(
							ListaVendaValor,
							VendaID,
							AnimalID)
					VALUES
						(
							@ListaVendaValor,
							@VendaID,
							@AnimalID)
					SELECT @@IDENTITY as Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Alterar'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					UPDATE
						tblListaVenda 
					SET
						ListaVendaValor = @ListaVendaValor
					WHERE
						ListaVendaID = @ListaVendaID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Excluir'
		BEGIN
			BEGIN TRY
				BEGIN TRAN
					DELETE FROM
						tblListaVenda
					WHERE
						ListaVendaID = @ListaVendaID
					SELECT @@IDENTITY AS Retorno
				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
END


CREATE PROCEDURE uspConsultaListaVenda
	@TipoProcedure VARCHAR(10),
	@VendaID INT,
	@AnimalID INT
AS
BEGIN
	IF @TipoProcedure = 'Venda'
		BEGIN
			BEGIN TRY
				SELECT 			
					lv.ListaVendaID, lv.ListaVendaValor, lv.VendaID,
					lv.AnimalID, lv.AnimalDescricao, lv.AnimalDataNascimento,
					lv.AnimalIdentificador, lv.RacaNome
				FROM
					vwListaVenda AS lv
				WHERE
					lv.VendaID = @VendaID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
	IF @TipoProcedure = 'Animal'
		BEGIN
			BEGIN TRY
				SELECT 
					lv.ListaVendaID, lv.ListaVendaValor, lv.VendaID,
					lv.AnimalID, lv.AnimalDescricao, lv.AnimalDataNascimento,
					lv.AnimalIdentificador, lv.RacaNome
				FROM
					vwListaVenda AS lv
				WHERE
					lv.AnimalID = @AnimalID
			END TRY
			BEGIN CATCH
				SELECT ERROR_MESSAGE() AS Retorno
			END CATCH
		END
		
END

END
