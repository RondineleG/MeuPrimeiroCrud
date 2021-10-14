CREATE PROCEDURE ClienteConsultaPorCodigo

 @Codigo INT     

AS
BEGIN
  
 SELECT * FROM tblClientes
  
 WHERE  Codigo = @Codigo 

 SELECT @Codigo  AS Retorno

END