CREATE PROCEDURE ClienteAlterar
 
 @Codigo INT,
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
  
   UPDATE

     tblClientes
	        
	 SET

 Nome = @Nome, 
 CPF = @CPF,
 DataNascimento = @DataNascimento, 
 Sexo = @Sexo,
 Telefone = @Telefone,
 Celular = @Celular,
 CEP = @CEP,
 Endereco = @Endereco,
 Bairro = @Bairro,
 Cidade =@Cidade,
 Estado = @Estado,
 Complemento = @Complemento,
 Email = @Email,
 Obs = @Obs  
 
 WHERE Codigo = @Codigo 




 SELECT @Codigo  AS Retorno

END
