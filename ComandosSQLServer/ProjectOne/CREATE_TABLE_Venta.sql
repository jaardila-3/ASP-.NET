CREATE TABLE Venta(
	IDVenta int,
	IDProducto int,
	cantidad int,
	fechaVenta datetime,
	CONSTRAINT PK_venta primary key (IDVenta)
)