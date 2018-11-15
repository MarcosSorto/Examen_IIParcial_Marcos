USE BulletProofRecords
GO

CREATE PROCEDURE sp_EliminarCanciones(
@nombre NVARCHAR(200)
)
AS
BEGIN
	DECLARE @codigoCancion INT
	SET @codigoCancion = (SELECT id FROM Music.Cancion WHERE Nombre = @nombre);
	
	DELETE FROM Music.Cancion WHERE id = @codigoCancion;
END