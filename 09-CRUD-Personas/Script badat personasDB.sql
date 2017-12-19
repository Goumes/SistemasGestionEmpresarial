CREATE DATABASE PersonasDB

GO

USE PersonasDB

GO

CREATE TABLE departamentos
(
	ID int NOT NULL,
	Nombre VARCHAR (40) NOT NULL,

	CONSTRAINT PK_departamentos PRIMARY KEY (ID)
)

GO

CREATE TABLE personas
(
	IDPersona INT IDENTITY (1,1) NOT NULL,
	nombre VARCHAR (20) NULL,
	apellidos VARCHAR (20) NULL,
	fechaNac DATE NULL,
	direccion VARCHAR (100),
	telefono VARCHAR (10) NULL,
	idDepartamento INT NOT NULL,

	CONSTRAINT PK_personas PRIMARY KEY (IDPersona),
	CONSTRAINT FK_personas_departamentos FOREIGN KEY (idDepartamento) REFERENCES departamentos (ID) ON UPDATE CASCADE ON DELETE NO ACTION
)

INSERT INTO departamentos (ID, Nombre)
VALUES (1, 'Departamento1'),
(2, 'Departamento2'),
(3, 'Departamento3'),
(4, 'Departamento4'),
(5, 'Departamento5'),
(6, 'Departamento6')

INSERT INTO personas (nombre, apellidos, fechaNac, direccion, telefono, idDepartamento)
VALUES ('Persona1', 'Apellido1', '27-10-2018 15:34:09', 'Direccion1', 'telefono1', 1),
('Persona2', 'Apellido2', '27-10-2018 15:34:09', 'Direccion2', 'telefono2', 1),
('Persona3', 'Apellido3', '27-10-2018 15:34:09', 'Direccion3', 'telefono3', 1),
('Persona4', 'Apellido4', '27-10-2018 15:34:09', 'Direccion4', 'telefono4', 2)
