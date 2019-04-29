alter table [dbo].[productos_detalle] with check add constraint [FK_productos]
foreign key ([IdProducto])
references [dbo].[productos] ([IdProducto])
GO

alter table [dbo].[productos_detalle] with check add constraint [FK_color]
foreign key ([IdColor])
references [dbo].[color] ([IdColor])
GO

alter table [dbo].[productos_detalle] with check add constraint [FK_acabado]
foreign key ([IdAcabado])
references [dbo].[acabado] ([IdAcabado])
GO

alter table [dbo].[productos_detalle] with check add constraint [FK_concepto]
foreign key ([IdConcepto])
references [dbo].[concepto] ([IdConcepto])
GO


alter table [dbo].[productos_detalle] with check add constraint [FK_clasificacion]
foreign key ([IdClasificacion])
references [dbo].[Clasificacion] ([IdClasificacion])
GO

alter table [dbo].[productos_detalle] with check add constraint [FK_marca]
foreign key ([IdMarca])
references [dbo].[Marca] ([IdMarca])
GO

alter table [dbo].[productos_detalle] with check add constraint [FK_linea]
foreign key ([IdLinea])
references [dbo].[Linea] ([IdLinea])
GO

alter table [dbo].[productos_detalle] with check add constraint [FK_tienda]
foreign key ([IdTienda])
references [dbo].[tienda] ([Idtienda])
GO

