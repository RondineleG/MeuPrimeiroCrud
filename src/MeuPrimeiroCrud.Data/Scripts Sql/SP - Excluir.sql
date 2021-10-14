CREATE PROCEDURE ClienteExcluir

 @Codigo INT     
AS

BEGIN
 DELETE FROM tblClientes
 
 WHERE Codigo = @Codigo 

 SELECT @Codigo  AS Retorno

END
