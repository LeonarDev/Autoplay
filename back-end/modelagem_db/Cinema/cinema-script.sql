CREATE SCHEMA `cinema`;

CREATE TABLE TB_FILME (
                ID_FILME VARCHAR(10) NOT NULL,
                TITULO_BR VARCHAR(200) NOT NULL,
                TITULO_ORIGINAL VARCHAR(200) NOT NULL,
                GENERO VARCHAR(20) NOT NULL,
                ANO_LANCAMENTO DATE NOT NULL,
                CLASSIFICACAO_INDICATIVA VARCHAR(2) NOT NULL,
                DURACAO TIME NOT NULL,
                PRIMARY KEY (ID_FILME)
);


CREATE TABLE TB_CLIENTE (
                CPF_CLIENTE VARCHAR(11) NOT NULL,
                NOME_CLIENTE VARCHAR(50) NOT NULL,
                TELEFONE_CLIENTE INT NOT NULL,
                PRIMARY KEY (CPF_CLIENTE)
);


CREATE TABLE TB_FREQUENCIA_CLIENTE (
                CPF_CLIENTE VARCHAR(11) NOT NULL,
                ID_FILME VARCHAR(10) NOT NULL,
                QTD_FILMES_ASSISTIDOS INT NOT NULL,
                PRIMARY KEY (CPF_CLIENTE)
);


CREATE TABLE TB_CINEMA (
                ID_CINEMA VARCHAR(10) NOT NULL,
                QTD_SALAS INT NOT NULL,
                CAPACIDADE_TOTAL INT NOT NULL,
                PRIMARY KEY (ID_CINEMA)
);


CREATE TABLE TB_VISITAS_CLIENTE (
                CPF_CLIENTE VARCHAR(11) NOT NULL,
                ID_CINEMA VARCHAR(10) NOT NULL,
                QTD_CINEMAS_VISITADOS INT NOT NULL,
                PRIMARY KEY (CPF_CLIENTE)
);


CREATE TABLE TB_FILMES_EXIBICAO (
                ID_CINEMA VARCHAR(10) NOT NULL,
                ID_FILME VARCHAR(10) NOT NULL,
                PRIMARY KEY (ID_CINEMA)
);


CREATE TABLE TB_SALA (
                ID_SALA VARCHAR(10) NOT NULL,
                CAPACIDADE_SALA INT NOT NULL,
                ID_CINEMA VARCHAR(10) NOT NULL,
                PRIMARY KEY (ID_SALA)
);


CREATE TABLE TB_ASSENTO (
                ID_ASSENTO VARCHAR(10) NOT NULL,
                TIPO_ASSENTO VARCHAR(20) NOT NULL,
                STATUS_DISPONIVEL BOOLEAN NOT NULL,
                ID_SALA VARCHAR(10) NOT NULL,
                PRIMARY KEY (ID_ASSENTO)
);


CREATE TABLE TB_SESSAO (
                ID_SESSAO VARCHAR(10) NOT NULL,
                FORMATO VARCHAR(2) NOT NULL,
                DATA DATE NOT NULL,
                HORA_INICIO DATETIME NOT NULL,
                HORA_TERMINO DATETIME NOT NULL,
                ID_SALA VARCHAR(10) NOT NULL,
                ID_FILME VARCHAR(10) NOT NULL,
                PRIMARY KEY (ID_SESSAO)
);


CREATE TABLE TB_INGRESSO (
                ID_INGRESSO VARCHAR(10) NOT NULL,
                CPF_CLIENTE VARCHAR(11) NOT NULL,
                ID_SALA VARCHAR(10) NOT NULL,
                ID_SESSAO VARCHAR(10) NOT NULL,
                ID_ASSENTO VARCHAR(10) NOT NULL,
                PRIMARY KEY (ID_INGRESSO)
);


CREATE TABLE TB_PAGAMENTO (
                ID_INGRESSO VARCHAR(10) NOT NULL,
                VALOR DECIMAL NOT NULL,
                TIPO_PAGAMENTO VARCHAR(20) NOT NULL,
                TIPO_ENTRADA VARCHAR(10) NOT NULL,
                PRIMARY KEY (ID_INGRESSO)
);


CREATE TABLE TB_CONTATO_CINEMA (
                ID_CINEMA VARCHAR(10) NOT NULL,
                EMAIL VARCHAR(50) NOT NULL,
                TELEFONE VARCHAR(15) NOT NULL,
                PRIMARY KEY (ID_CINEMA)
);


CREATE TABLE TB_ENDERECO_CINEMA (
                ID_CINEMA VARCHAR(10) NOT NULL,
                RUA VARCHAR(50) NOT NULL,
                NUMERO VARCHAR(10) NOT NULL,
                COMPLEMENTO VARCHAR(200) NOT NULL,
                CEP VARCHAR(9) NOT NULL,
                CIDADED VARCHAR(50) NOT NULL,
                ESTADO VARCHAR(50) NOT NULL,
                PRIMARY KEY (ID_CINEMA)
);


ALTER TABLE TB_SESSAO ADD CONSTRAINT tb_filme_tb_sessao_fk
FOREIGN KEY (ID_FILME)
REFERENCES TB_FILME (ID_FILME)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_FREQUENCIA_CLIENTE ADD CONSTRAINT tb_filme_tb_frequencia_cliente_fk
FOREIGN KEY (ID_FILME)
REFERENCES TB_FILME (ID_FILME)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_FILMES_EXIBICAO ADD CONSTRAINT tb_filme_tb_filmes_exibicao_fk
FOREIGN KEY (ID_FILME)
REFERENCES TB_FILME (ID_FILME)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_INGRESSO ADD CONSTRAINT tb_cliente_tb_ingresso_fk
FOREIGN KEY (CPF_CLIENTE)
REFERENCES TB_CLIENTE (CPF_CLIENTE)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_FREQUENCIA_CLIENTE ADD CONSTRAINT tb_cliente_tb_frequencia_cliente_fk
FOREIGN KEY (CPF_CLIENTE)
REFERENCES TB_CLIENTE (CPF_CLIENTE)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_VISITAS_CLIENTE ADD CONSTRAINT tb_cliente_tb_visitas_cliente_fk
FOREIGN KEY (CPF_CLIENTE)
REFERENCES TB_CLIENTE (CPF_CLIENTE)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_ENDERECO_CINEMA ADD CONSTRAINT tb_cinema_tb_endereco_cinema_fk
FOREIGN KEY (ID_CINEMA)
REFERENCES TB_CINEMA (ID_CINEMA)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_CONTATO_CINEMA ADD CONSTRAINT tb_cinema_tb_contato_cinema_fk
FOREIGN KEY (ID_CINEMA)
REFERENCES TB_CINEMA (ID_CINEMA)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_SALA ADD CONSTRAINT tb_cinema_tb_sala_fk
FOREIGN KEY (ID_CINEMA)
REFERENCES TB_CINEMA (ID_CINEMA)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_FILMES_EXIBICAO ADD CONSTRAINT tb_cinema_tb_filmes_exibicao_fk
FOREIGN KEY (ID_CINEMA)
REFERENCES TB_CINEMA (ID_CINEMA)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_VISITAS_CLIENTE ADD CONSTRAINT tb_cinema_tb_visitas_cliente_fk
FOREIGN KEY (ID_CINEMA)
REFERENCES TB_CINEMA (ID_CINEMA)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_INGRESSO ADD CONSTRAINT tb_sala_tb_ingresso_fk
FOREIGN KEY (ID_SALA)
REFERENCES TB_SALA (ID_SALA)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_SESSAO ADD CONSTRAINT tb_sala_tb_sessao_fk
FOREIGN KEY (ID_SALA)
REFERENCES TB_SALA (ID_SALA)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_ASSENTO ADD CONSTRAINT tb_sala_tb_assento_fk
FOREIGN KEY (ID_SALA)
REFERENCES TB_SALA (ID_SALA)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_INGRESSO ADD CONSTRAINT tb_assento_tb_ingresso_fk
FOREIGN KEY (ID_ASSENTO)
REFERENCES TB_ASSENTO (ID_ASSENTO)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_INGRESSO ADD CONSTRAINT tb_sessao_tb_ingresso_fk
FOREIGN KEY (ID_SESSAO)
REFERENCES TB_SESSAO (ID_SESSAO)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE TB_PAGAMENTO ADD CONSTRAINT tb_ingresso_tb_pagamento_fk
FOREIGN KEY (ID_INGRESSO)
REFERENCES TB_INGRESSO (ID_INGRESSO)
ON DELETE NO ACTION
ON UPDATE NO ACTION;