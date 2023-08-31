
CREATE DATABASE IF NOT EXISTS academico;

USE academico;

CREATE TABLE aluno (
	id               int            NOT NULL AUTO_INCREMENT,
	matricula        varchar(15)    NOT NULL,
	dt_nascimento    datetime       NOT NULL,
	nome             varchar(100)   NOT NULL,
	endereco	     varchar(100)   NOT NULL,
	bairro		     varchar(100)   NOT NULL,
	cidade		     varchar(100)   NOT NULL,
	estado		     varchar(02)    NOT NULL,
	senha		     varchar(60)    NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE curso (
	id               int            NOT NULL AUTO_INCREMENT,
	tipo             varchar(100)   NOT NULL, -- Tecnico, bacharelado, Tecnologo, Licenciatura
	nome             varchar(100)   NOT NULL,
	ano_criacao      int            NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE professor (
	id               int            NOT NULL AUTO_INCREMENT,
	matricula        varchar(15)    NOT NULL,
	dt_nascimento    datetime       NOT NULL,
	nome             varchar(100)   NOT NULL,
	titulação        varchar(100)   NOT NULL, --Graduação, Especialização, Mestrado, Doutorado
	area_formacao    varchar(100)   NOT NULL,
	endereco	     varchar(100)   NOT NULL,
	bairro		     varchar(100)   NOT NULL,
	cidade		     varchar(100)   NOT NULL,
	estado		     varchar(02)    NOT NULL,
	PRIMARY KEY (id)
);