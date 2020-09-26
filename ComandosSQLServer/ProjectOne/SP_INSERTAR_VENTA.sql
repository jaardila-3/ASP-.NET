--exec SP_INS_VENTA 3, 10
--select * from Venta

CREATE PROC SP_INS_VENTA(
	@IDProducto int,
	@cantidad int
)
as
--con getdate() obtenemos la fecha y hora actual
insert into venta values(@IDProducto, @cantidad, GETDATE())