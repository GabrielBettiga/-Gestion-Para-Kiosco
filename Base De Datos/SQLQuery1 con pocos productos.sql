--CREACION DE BASE DE DATOS
USE master
GO

CREATE DATABASE Programa_De_Gestion
GO

USE Programa_De_Gestion
GO


--1
CREATE TABLE METODO_DE_PAGO(
ID_Metodo_MP INT,
Descripcion_MP VARCHAR (100),
Estado_MP BIT DEFAULT 1,
CONSTRAINT PK_MetodoDePago PRIMARY KEY (ID_Metodo_MP)
)
GO

--2
CREATE TABLE LOCALES(
ID_Local_L INT,
Nombre_L VARCHAR (100),
Direccion_L VARCHAR (100),
Telefono_L VARCHAR (100),
Informacion_Extra_L VARCHAR (100),
Estado_L BIT DEFAULT 1,
CONSTRAINT PK_Locales PRIMARY KEY (ID_Local_L)
)
GO

--11
CREATE TABLE TIPOS_DE_USUARIOS(
ID_Tipo_De_Usuario_TU bit,
Descripcion_TU Varchar (100),
Estado_TU bit DEFAULT 1,
CONSTRAINT PK_TipoDeUsuarios PRIMARY KEY (ID_Tipo_De_Usuario_TU)
)
GO

--12
CREATE TABLE USUARIOS(
ID_Usuario_U INT IDENTITY (1,1),
DNI_U Varchar (100),
Tipo_Usuario_U bit,
Nombre_U Varchar (100),
Apellido_U Varchar (100),
Contraseña_U Varchar (100),
Estado_U bit DEFAULT 1
CONSTRAINT PK_Usuarios PRIMARY KEY (ID_Usuario_U),
CONSTRAINT FK_Usuarios_TipoDeUsuario FOREIGN KEY (Tipo_Usuario_U) REFERENCES TIPOS_DE_USUARIOS (ID_Tipo_De_Usuario_TU),
CONSTRAINT UQ_UsuariosDNI Unique (DNI_U)
)
GO

--3
CREATE TABLE VENTAS(
ID_Venta_V INT IDENTITY (1,1),
ID_Local_V INT, 
Metodo_De_Pago_V INT,
Monto_Total_V MONEY,
ID_Usuario_V INT,
Fecha_Hora_V smalldatetime
CONSTRAINT PK_Ventas PRIMARY KEY (ID_Venta_V),
CONSTRAINT FK_Ventas_Locales FOREIGN KEY (ID_Local_V) REFERENCES Locales (ID_Local_L),
CONSTRAINT FK_Ventas_Metodo_De_Pago FOREIGN KEY (Metodo_De_Pago_V) REFERENCES METODO_DE_PAGO (ID_Metodo_MP),
CONSTRAINT FK_Ventas_Usuarios FOREIGN KEY (ID_Usuario_V) REFERENCES USUARIOS (ID_Usuario_U)
)
GO

--4
CREATE TABLE PROVEEDORES(
ID_De_Proveedor_PV Varchar(100),
Razon_Social_PV Varchar (100),
Telefono_PV Varchar (100),
Email_PV Varchar (100),
Estado_PV BIT DEFAULT 1
CONSTRAINT PK_Proveedores PRIMARY KEY (ID_De_Proveedor_PV)
)
GO

--7
CREATE TABLE PRODUCTOS(
Numero_P int identity (1,1),
ID_Producto_P Varchar (100),
Categoria_P Varchar(100),
Descripcion_P Varchar (100),
Stock_P INT DEFAULT 0,
Punto_De_Pedido_P INT,
Porcentaje_De_Venta_P MONEY,
Estado_P BIT DEFAULT 1,
URL_P Varchar (100)
CONSTRAINT PK_Productos PRIMARY KEY (ID_Producto_P)
)
GO

--8
CREATE TABLE DETALLE_DE_VENTAS(
ID_Detalle_De_Venta_DV INT IDENTITY (1,1),
ID_Venta_DV INT,
ID_Producto_DV Varchar (100),
Cantidad_DV INT,
Precio_Unitario_DV MONEY,
CONSTRAINT PK_DetalleDeVentas PRIMARY KEY (ID_Detalle_De_Venta_DV),
CONSTRAINT FK_DetalleDeVentas_Ventas FOREIGN KEY (ID_Venta_DV) REFERENCES VENTAS (ID_Venta_V),
CONSTRAINT FK_DetalleDeVentas_Productos FOREIGN KEY (ID_Producto_DV) REFERENCES PRODUCTOS(ID_Producto_P)
)
GO

--9
CREATE TABLE FACTURAS(
ID_Factura_F INT IDENTITY (1,1),
ID_Proveedor_F Varchar (100),
ID_Usuario_F INT,
Monto_Total_F DECIMAL(8,2),
Fecha_Hora_F smalldatetime
CONSTRAINT PK_Facturas PRIMARY KEY (ID_Factura_F),
CONSTRAINT FK_Facturas_Proveedor FOREIGN KEY (ID_Proveedor_F) REFERENCES PROVEEDORES (ID_De_Proveedor_PV),
CONSTRAINT FK_Facturas_Usuarios FOREIGN KEY (ID_Usuario_F) REFERENCES USUARIOS (ID_Usuario_U)
)
GO

--10
CREATE TABLE DETALLE_DE_FACTURAS(
ID_Detalle_DF INT IDENTITY (1,1),
ID_Factura_DF INT,
ID_Producto_DF Varchar (100),
Cantidad_DF INT,
Precio_Unitario_DG MONEY,
Iva_DF MONEY,
Descuento_DF MONEY,
CONSTRAINT PK_DetalleDeFacturas PRIMARY KEY (ID_Detalle_DF),
CONSTRAINT FK_DetalleDeFacturas_Facturas FOREIGN KEY (ID_Factura_DF) REFERENCES FACTURAS (ID_Factura_F),
CONSTRAINT FK_DetalleDeFacturas_Productos FOREIGN KEY (ID_Producto_DF) REFERENCES PRODUCTOS(ID_Producto_P)
)
GO



--13
CREATE TABLE CIERRES_DE_CAJAS(
ID_De_Cierre_C INT IDENTITY (1,1),
ID_Usuario_C INT,
Monto_Inicio_C MONEY,
Monto_Gastos_C MONEY,
Ganancia_En_Efectivo_C MONEY,
Ganancia_En_Tarjeta_C MONEY,
Ganancia_Total_C MONEY,
Efectivo_En_Caja_C MONEY,
Total_C MONEY,
Arqueo_C MONEY,
Fecha_Hora_C smalldatetime
CONSTRAINT PK_CierresDeCajas PRIMARY KEY (ID_De_Cierre_C),
CONSTRAINT FK_CierresDeCajas_Usuarios FOREIGN KEY (ID_Usuario_C) REFERENCES USUARIOS (ID_Usuario_U)
)
GO

------------------INSERTAR DATOS------------------------------------

--PROVEEDORES
INSERT INTO PROVEEDORES (ID_De_Proveedor_PV,Razon_Social_PV,Telefono_PV,Email_PV,Estado_PV)
SELECT '1','Lacteos Norte (Los Troncos)','1155443322','LacteosNorte@gmail.com',1 
--TIPOS DE USUARIOS
INSERT INTO TIPOS_DE_USUARIOS (ID_Tipo_De_Usuario_TU,Descripcion_TU,Estado_TU)
SELECT 1,'ADMINISTRADOR',1
--USUARIOS
INSERT INTO USUARIOS(DNI_U,Tipo_Usuario_U,Nombre_U,Apellido_U,Contraseña_U,Estado_U)
SELECT '41578324',1,'Gabriel','Bettiga','123',1
--LOCALES
INSERT INTO LOCALES (ID_Local_L,Nombre_L,Direccion_L,Telefono_L,Informacion_Extra_L,Estado_L)
SELECT 1,'Kiosco Lacteos Norte','La Ralde 458','1177889944','-',1
--METODO DE PAGO
INSERT INTO METODO_DE_PAGO(ID_Metodo_MP,Descripcion_MP,Estado_MP)
SELECT 1,'Efectivo',1
go
-----------------PROCEDIMIENTOS-------------------------

---PRODUCTOS---

CREATE PROCEDURE sp_AgregarProducto
@IDPRODUCTO Varchar (100),
@CATEGORIA Varchar (100),
@DESCRIPCION Varchar (100),
@STOCK int,
@PUNTODEPEDIDO int,
@PORCENTAJEDEVENTA Money,
@URL Varchar (100)
AS
	INSERT INTO	PRODUCTOS (ID_Producto_P,Categoria_P,Descripcion_P,Stock_P,Punto_De_Pedido_P,Porcentaje_De_Venta_P,URL_P)
	VALUES (@IDPRODUCTO,@CATEGORIA,@DESCRIPCION,@STOCK,@PUNTODEPEDIDO,@PORCENTAJEDEVENTA,@URL)
GO





/*
CREATE procedure [dbo].[sp_listar_productos]
@tab_inicio int,
@tab_final int
as
select * from PRODUCTOS where  Numero_P between @tab_inicio and @tab_final
GO

CREATE PROCEDURE [dbo].[sp_AgregarVentas]
@ID_LOCAL INT,
@METODO_DE_PAGO INT,
@ID_USUARIO INT
AS
	INSERT INTO VENTAS (ID_Local_V,Metodo_De_Pago_V,ID_Usuario_V,Fecha_Hora_V)
	VALUES (@ID_LOCAL,@METODO_DE_PAGO,@ID_USUARIO,GETDATE())

GO

CREATE PROCEDURE [dbo].[sp_AgregarDetalleDeVenta]
@ID_VENTA INT,
@ID_PRODUCTO VARCHAR(100),
@CANTIDAD INT,
@PRECIO_UNITARIO MONEY
AS
	INSERT INTO DETALLE_DE_VENTAS (ID_Venta_DV,ID_Producto_DV,Cantidad_DV,Precio_Unitario_DV)
	VALUES (@ID_VENTA,@ID_PRODUCTO,@CANTIDAD,@PRECIO_UNITARIO)

GO

DECLARE @myVar int
SET @myVar = 0
UPDATE
  PRODUCTOS
SET
   Numero_P =  @myvar ,
   @myvar = @myVar + 1
GO
*/