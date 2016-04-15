CREATE SCHEMA banco_qualquer;
USE banco_qualquer;


CREATE TABLE cliente(
	id BIGINT AUTO_INCREMENT NOT NULL PRIMARY KEY UNIQUE,
    nome VARCHAR(100) NOT NULL,
    sobrenome VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL,
    cpf CHAR(14) UNIQUE NOT NULL,
    data_nascimento DATE NOT NULL,
    telefone VARCHAR(14) NOT NULL,
    celular VARCHAR(14) NOT NULL
);

CREATE TABLE endereco (
	id BIGINT AUTO_INCREMENT NOT NULL PRIMARY KEY UNIQUE,
    cep CHAR(9) NOT NULL,
    logradouro VARCHAR(150) NOT NULL,
    numero VARCHAR(50) NOT NULL,
    complemento VARCHAR(50) NOT NULL,
    bairro VARCHAR(150) NOT NULL,
    cidade VARCHAR(150) NOT NULL,
    estado VARCHAR(150) NOT NULL,
    pais VARCHAR(150) NOT NULL,    
    cliente_id BIGINT NOT NULL,
     
    FOREIGN KEY(cliente_id) REFERENCES cliente(id)
);
CREATE TABLE conta(
	id BIGINT AUTO_INCREMENT NOT NULL PRIMARY KEY UNIQUE,
    cliente_id BIGINT NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    agencia VARCHAR(100) NOT NULL,
    saldo DECIMAL(10,2) NOT NULL,

	FOREIGN KEY(cliente_id) REFERENCES cliente(id)
);
