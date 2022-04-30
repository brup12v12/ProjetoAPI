CREATE DATABASE Teste
GO

USE Teste
GO

CREATE TABLE Projetos
(
 Id INT PRIMARY KEY IDENTITY,
 Titulo VARCHAR(150) NOT NULL,
)
GO 

INSERT INTO Projetos (Titulo)
VALUES ('ftyguhijokpl')
GO

SELECT * FROM Projetos

--=====================

CREATE TABLE Usuarios
(
  Id INT PRIMARY KEY IDENTITY,
  Email VARCHAR (150) NOT  NULL UNIQUE,
  Senha VARCHAR (255) NOT NULL 
)
GO

INSERT INTO Usuarios VALUES ('emailTESTE@gmail.com', '12quhdjq7')
GO

SELECT * FROM Usuarios WHERE Email = 'emailTESTE@gmail.com' AND Senha = '12quhdjq7'
GO
