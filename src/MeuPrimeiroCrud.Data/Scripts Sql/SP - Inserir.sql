CREATE PROCEDURE ClienteInserir
 
 @Nome VARCHAR (50),
 @CPF VARCHAR (15),
 @DataNascimento DATETIME,
 @Sexo BIT,
 @Telefone  VARCHAR (15),
 @Celular VARCHAR (15),
 @CEP	VARCHAR (50),
 @Endereco VARCHAR (50),
 @Bairro VARCHAR (50),
 @Cidade   VARCHAR (50),
 @Estado	 VARCHAR (2),
 @Complemento	VARCHAR (50),
 @Email   VARCHAR (50),
 @Obs  TEXT
 
   AS

  BEGIN
  
  INSERT INTO tblClientes
(
 
 Nome,
 CPF,
 DataNascimento,
 Sexo,
 Telefone,
 Celular,
 CEP,
 Endereco,
 Bairro,
 Cidade,
 Estado,
 Complemento,
 Email,
 Obs 
 )

   VALUES
(
 
 @Nome,
 @CPF,
 @DataNascimento,
 @Sexo,
 @Telefone,
 @Celular,
 @CEP,
 @Endereco,
 @Bairro,
 @Cidade,
 @Estado,
 @Complemento,
 @Email,
 @Obs 

)

 SELECT @@IDENTITY AS Retorno

END
