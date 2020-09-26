--exec SP_SEL_VENTAS 1

ALTER PROC SP_SEL_VENTAS(
	@idProducto int = 0
)
as
if @idProducto > 0
	select * from Venta V
	INNER JOIN Producto P
	ON P.IDProducto = V.IDProducto
	where V.IDProducto = @idProducto
ELSE
	SELECT * FROM Venta V
	INNER JOIN Producto P
	ON P.IDProducto = V.IDProducto