--EXEC SP_SEL_PRODUCTO 4

CREATE PROC SP_SEL_PRODUCTO(
	@IDProducto int = 0 --se inicializa en cero por si no envian parametro
)
AS
IF @IDProducto > 0
	SELECT * FROM Producto WHERE IDProducto = @IDProducto
ELSE
	SELECT * FROM Producto ORDER BY descripcion