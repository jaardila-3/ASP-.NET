select * from BDPasaje.dbo.Empleado as e 
join BDPasaje.dbo.TipoUsuario as t 
on e.IIDTIPOUSUARIO=t.IIDTIPOUSUARIO
join BDPasaje.dbo.TipoContrato as c
on e.IIDTIPOCONTRATO=c.IIDTIPOCONTRATO