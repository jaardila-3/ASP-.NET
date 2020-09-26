--SP=STORED PROCEDURE= PROCEDIMIENTO ALMACENADO
--insertaremos productos

--select * from Producto

--execute sp_ins_producto 'pantalon', 'gris', 525

create procedure SP_INS_Producto(
	@descripcion varchar(50),
	@color varchar(50),
	@precio money
)
as
insert into Producto values(@descripcion, @color, @precio)