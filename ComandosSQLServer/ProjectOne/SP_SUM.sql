--exec SP_SEL_VentasTotales

ALTER PROC SP_SEL_VentasTotales -- si no hay parametros, no colocar los ()
as
select SUM (precio*cantidad) VentasTotales from Venta V
inner join Producto P
on P.IDProducto = V.IDProducto