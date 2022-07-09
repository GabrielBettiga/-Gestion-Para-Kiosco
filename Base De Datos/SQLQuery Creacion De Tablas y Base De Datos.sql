--CREACION DE BASE DE DATOS
USE master
GO

CREATE DATABASE Programa_De_Gestion
ON
(	NAME = Programa_De_Gestion,
	FILENAME = 'C:\Bases De Datos Proyectos Personales\Programa_De_Gestion.mdf'
)
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

--3
CREATE TABLE VENTAS(
ID_Venta_V INT IDENTITY (1,1),
ID_Local_V INT, 
Metodo_De_Pago_V INT,
Monto_Total_V DECIMAL(8,2),
Fecha_Hora_V smalldatetime
CONSTRAINT PK_Ventas PRIMARY KEY (ID_Venta_V),
CONSTRAINT FK_Ventas_Locales FOREIGN KEY (ID_Local_V) REFERENCES Locales (ID_Local_L),
CONSTRAINT FK_Ventas_Metodo_De_Pago FOREIGN KEY (Metodo_De_Pago_V) REFERENCES METODO_DE_PAGO (ID_Metodo_MP)
)
GO

--4
CREATE TABLE PROVEEDORES(
ID_De_Proveedor_PV Varchar (100),
Razon_Social_PV Varchar (100),
Telefono_PV Varchar (100),
Email_PV Varchar (100),
Estado_PV BIT DEFAULT 1
CONSTRAINT PK_Proveedores PRIMARY KEY (ID_De_Proveedor_PV)
)
GO

--5
CREATE TABLE CATEGORIAS(
ID_Categoria_C INT,
Descripcipn_C Varchar (100),
Estado_C BIT DEFAULT 1
CONSTRAINT PK_Categorias PRIMARY KEY (ID_Categoria_C)
)
GO

--6
CREATE TABLE UNIDADES_DE_MEDIDAS(
ID_Medida_UM INT,
Descripcion_UM Varchar (100),
Estado_UM BIT DEFAULT 1
CONSTRAINT PK_UnidadesDeMedidas PRIMARY KEY (ID_Medida_UM)
)
GO

--7
CREATE TABLE PRODUCTOS(
ID_De_Proveedor_P Varchar (100),
ID_Producto_P Varchar (100),
ID_De_Categoria_P INT,
Unidad_De_Medida_P INT,
Descripcion_P Varchar (100),
Stock_P INT,
Punto_De_Pedido_P INT,
URL_imagen_P Varchar (100),
Precio_De_Compra_P DECIMAL(8,2),
Precio_De_Venta_P DECIMAL(8,2),
Estado_P BIT DEFAULT 1
CONSTRAINT PK_Productos PRIMARY KEY (ID_De_Proveedor_P,ID_Producto_P),
CONSTRAINT FK_Productos_Proveedores FOREIGN KEY (ID_De_Proveedor_p) REFERENCES PROVEEDORES (ID_De_Proveedor_PV),
CONSTRAINT FK_Productos_Categorias FOREIGN KEY (ID_De_Categoria_P) REFERENCES CATEGORIAS (ID_Categoria_C),
CONSTRAINT FK_Productos_UnidadesDeMedidas FOREIGN KEY (Unidad_De_Medida_P) REFERENCES UNIDADES_DE_MEDIDAS (ID_Medida_UM)
)
GO

--8
CREATE TABLE DETALLE_DE_VENTAS(
Posicion_De_Linea_DV INT,
ID_Detalle_De_Venta_DV INT IDENTITY (1,1),
ID_Venta_DV INT,
ID_Producto_DV Varchar (100),
ID_De_Proveedor_DV Varchar (100),
Cantidad_DV INT,
Precio_Unitario_DV DECIMAL(8,2)
CONSTRAINT PK_DetalleDeVentas PRIMARY KEY (Posicion_De_Linea_DV,ID_Detalle_De_Venta_DV),
CONSTRAINT FK_DetalleDeVentas_Ventas FOREIGN KEY (ID_Venta_DV) REFERENCES VENTAS (ID_Venta_V),
CONSTRAINT FK_DetalleDeVentas_Productos FOREIGN KEY (ID_De_Proveedor_DV,ID_Producto_DV) REFERENCES PRODUCTOS(ID_De_Proveedor_P,ID_Producto_P)
)
GO

--9
CREATE TABLE GASTOS(
ID_Gastos_G INT IDENTITY (1,1),
Monto_Total_G DECIMAL(8,2),
Fecha_Hora_G smalldatetime
CONSTRAINT PK_Gastos PRIMARY KEY (ID_Gastos_G)
)
GO

--10
CREATE TABLE DETALLE_DE_GASTOS(
ID_Detalle_DG INT IDENTITY (1,1),
ID_Gasto_DG INT,
ID_Producto_DG Varchar (100),
ID_De_Proveedor_DG Varchar (100),
Cantidad_DG INT,
Precio_Unitario_DG DECIMAL(8,2),
CONSTRAINT PK_DetalleDeGastos PRIMARY KEY (ID_Detalle_DG),
CONSTRAINT FK_DetalleDeGastos_Gastos FOREIGN KEY (ID_Gasto_DG) REFERENCES GASTOS (ID_Gastos_G),
CONSTRAINT FK_DetalleDeGastos_Productos FOREIGN KEY (ID_De_Proveedor_DG,ID_Producto_DG) REFERENCES PRODUCTOS(ID_De_Proveedor_P,ID_Producto_P)
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

--13
CREATE TABLE CIERRES_DE_CAJAS(
ID_Usuario_C INT,
ID_De_Cierre_C INT IDENTITY (1,1),
Monto_Inicio_C DECIMAL(8,2),
Monto_Gastos_C DECIMAL(8,2),
Efectivo_C DECIMAL(8,2),
Tarjeta_C DECIMAL(8,2),
Total_C DECIMAL(8,2),
Fecha_Hora_C smalldatetime
CONSTRAINT PK_CierresDeCajas PRIMARY KEY (ID_Usuario_C,ID_De_Cierre_C),
CONSTRAINT FK_CierresDeCajas_Usuarios FOREIGN KEY (ID_Usuario_C) REFERENCES USUARIOS (ID_Usuario_U)
)
GO

------------------INSERTAR DATOS------------------------------------

--PROVEEDORES
INSERT INTO PROVEEDORES (ID_De_Proveedor_PV,Razon_Social_PV,Telefono_PV,Email_PV,Estado_PV)
SELECT '1','Lacteos Norte (Los Troncos)','1155443322','LacteosNorte@gmail.com',1 
--CATEGORIAS
INSERT INTO CATEGORIAS (ID_Categoria_C,Descripcipn_C,Estado_C)
SELECT 1,'Harinas y Derivados',1
--UNIDAD DE MEDIDAS
INSERT INTO UNIDADES_DE_MEDIDAS (ID_Medida_UM,Descripcion_UM,Estado_UM)
SELECT 1,'Gramos',1
--PRODUCTOS
INSERT INTO PRODUCTOS (ID_De_Proveedor_P,ID_Producto_P,ID_De_Categoria_P,Unidad_De_Medida_P,Descripcion_P,Stock_P,Punto_De_Pedido_P,URL_imagen_P,Precio_De_Compra_P,Precio_De_Venta_P,Estado_P)
SELECT '1','1',1,1,'Fideos Luchetti Tallarin 500GR',15,7,'URL IMAGEN',50,100,1
--GASTOS
INSERT INTO GASTOS (Monto_Total_G,Fecha_Hora_G)
SELECT 750,GETDATE()
--DETALLES DE GASTOS
INSERT INTO DETALLE_DE_GASTOS (ID_Gasto_DG,ID_Producto_DG,ID_De_Proveedor_DG,Cantidad_DG,Precio_Unitario_DG)
SELECT 1,'1','1',15,50
--LOCALES
INSERT INTO LOCALES (ID_Local_L,Nombre_L,Direccion_L,Telefono_L,Informacion_Extra_L,Estado_L)
SELECT 1,'Kiosco Lacteos Norte','La Ralde 458','1177889944','-',1
--METODO DE PAGO
INSERT INTO METODO_DE_PAGO(ID_Metodo_MP,Descripcion_MP,Estado_MP)
SELECT 1,'Efectivo',1
--VENTAS
INSERT INTO VENTAS (ID_Local_V,Metodo_De_Pago_V,Monto_Total_V,Fecha_Hora_V)
SELECT 1,1,200,GETDATE()
--DETALLES DE VENTAS
INSERT INTO DETALLE_DE_VENTAS (Posicion_De_Linea_DV,ID_Venta_DV,ID_Producto_DV,ID_De_Proveedor_DV,Cantidad_DV,Precio_Unitario_DV)
SELECT 1,1,'1','1',2,100
--TIPOS DE USUARIOS
INSERT INTO TIPOS_DE_USUARIOS (ID_Tipo_De_Usuario_TU,Descripcion_TU,Estado_TU)
SELECT 1,'ADMINISTRADOR',1
--USUARIOS
INSERT INTO USUARIOS(DNI_U,Tipo_Usuario_U,Nombre_U,Apellido_U,Contraseña_U,Estado_U)
SELECT '41578324',1,'Gabriel','Bettiga','123',1
--CIERRES DE CAJAS
INSERT INTO CIERRES_DE_CAJAS(ID_Usuario_C,Monto_Inicio_C,Monto_Gastos_C,Efectivo_C,Tarjeta_C,Total_C,Fecha_Hora_C)
SELECT 1,1000,750,200,0,200,GETDATE()