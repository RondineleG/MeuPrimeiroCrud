CREATE PROCEDURE ClienteConsultaPorNome
 @Nome VARCHAR (50)  

AS
BEGIN

  
 SELECT 
 Codigo,
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

 FROM 
 tblClientes
  
 WHERE 


 Nome LIKE '%' + @Nome + '%' 

END












































