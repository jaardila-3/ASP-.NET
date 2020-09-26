--select * from Venta
--exec SP_UPD_VENTA 1, 1, 50, '2020-09-21'

CREATE PROC SP_UPD_VENTA(
	@idVenta int,
	@idProducto int,
	@cantidad int,
	@fechaVenta datetime
)
as
update Venta
set IDProducto = @idProducto,
cantidad = @cantidad,
fechaVenta = @fechaVenta
where IDVenta = @idVenta