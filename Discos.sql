select * from DISCOS
select * from ESTILOS
select * from TIPOSEDICION

insert into DISCOS(Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)
values ('Paranoid','1970-09-18','8','https://upload.wikimedia.org/wikipedia/en/6/64/Black_Sabbath_-_Paranoid.jpg',3,2)

SELECT D.Id,D.Titulo,D.FechaLanzamiento AS Lanzamiento,D.CantidadCanciones,D.UrlImagenTapa,E.Descripcion AS Genero,T.Descripcion AS Edicion FROM DISCOS AS D, ESTILOS AS E, TIPOSEDICION AS T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id;

UPDATE DISCOS 
SET UrlImagenTapa = 'https://static.nationalgeographic.es/files/styles/image_3200/public/20652.600x450.jpg?w=1600'
WHERE Id = 26