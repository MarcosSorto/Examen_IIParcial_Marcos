USE BulletProofRecords
GO

CREATE PROCEDURE sp_AgregarCanciones(
@nombre NVARCHAR(200),
@artista NVARCHAR(150),
@album NVARCHAR(150),
@genero NVARCHAR(100),
@anio NVARCHAR(4)
)
AS
BEGIN
	DECLARE @codigoArtista INT
	SET @codigoArtista = (SELECT id FROM Music.Artista WHERE Nombre = @artista);

	DECLARE @codigoAlbum INT
	SET @codigoAlbum = (SELECT id FROM Music.Album WHERE Nombre = @album);

	INSERT INTO Music.Cancion(Nombre,Artista,Album,Genero,AñoCreacion)
	VALUES(@nombre,@codigoArtista,@codigoAlbum,@genero,@anio);
END