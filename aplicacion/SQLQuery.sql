use master
go

if db_id('base') is not null
  begin
     drop database base
  end
go

create database base
go

use base
go

/*
Producto
idproducto int
nombre varchar(100)
descripcion varchar(100)
precio_compra money
fecha_ingreso date
precio_venta money
*/

create table Producto
(idproducto int primary key identity,
nombre varchar(100), descripcion varchar(100), precio_compra money,
fecha_ingreso date, precio_venta money)
go

---procedimientos almacenados----
create procedure insertar_producto
@nombre varchar(100), @descripcion varchar(100), @precio_compra money,
@fecha_ingreso date, @precio_venta money
as 
insert Producto(nombre, descripcion, precio_compra, fecha_ingreso, precio_venta)
  values (@nombre, @descripcion, @precio_compra, @fecha_ingreso, @precio_venta)
go   

--2---
go
create procedure modificar_producto
@idproducto int, @nombre varchar(100), @descripcion varchar(100), @precio_compra money,
@fecha_ingreso date, @precio_venta money
as
UPDATE [dbo].[Producto]
   SET [nombre] = @nombre
      ,[descripcion] = @descripcion
	  ,[precio_compra] = @precio_compra
	  ,[fecha_ingreso] = @fecha_ingreso
	  ,[precio_venta] = @precio_venta
 WHERE idproducto = @idproducto
GO

---3---
create procedure consultar_producto
@nombre varchar(100)
as
select idproducto, nombre, descripcion, precio_compra, fecha_ingreso, precio_venta from producto
where nombre like '%'+@nombre+'%'
go

---4---
create procedure eliminar_producto
@idproducto int
as
delete from Producto
where idproducto = @idproducto
go

