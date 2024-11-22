CREATE DATABASE BD_SimpleStock_SS
GO

USE BD_SimpleStock_SS
GO

CREATE TABLE Categorias(
IdCategoria INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(20) NOT NULL,
Descripcion VARCHAR(250) NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE Marcas(
IdMarca INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(20) NOT NULL,
Descripcion VARCHAR(250) NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE Proveedores(
IdProveedor INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(20) NOT NULL,
Telefono VARCHAR(20) NOT NULL,
Correo VARCHAR(50) NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE Productos(
IdProducto INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(50) NOT NULL,
Descripcion VARCHAR(250) NOT NULL,
Almacen VARCHAR(50) NOT NULL,
Ubicacion VARCHAR(50) NOT NULL,
IdCategoria INT FOREIGN KEY REFERENCES Categorias(IdCategoria),
IdMarca INT FOREIGN KEY REFERENCES Marcas(IdMarca),
IdProveedore INT FOREIGN KEY REFERENCES Proveedores(IdProveedor),
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE TipoEntradaSalida(--Compra, Venta, Devolucion sobre compra, Devolución sobre venta
IdTipo INT PRIMARY KEY IDENTITY,
Tipo VARCHAR(20) NOT NULL,
Descripcion VARCHAR(250) NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE Clientes(
IdCliente INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(50) NOT NULL,
Telefono VARCHAR(15) NOT NULL,
Correo VARCHAR(100) NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE RegistroEntradas(
IdRegistroEntrada INT PRIMARY KEY IDENTITY,
FechaEntrada DATETIME NOT NULL,
IdTipo INT FOREIGN KEY REFERENCES TipoEntradaSalida(IdTipo),
Descripcion VARCHAR(250) NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE RegistroSalidas(
IdRegistroSalida INT PRIMARY KEY IDENTITY,
FechaSalida DATETIME NOT NULL,
IdTipo INT FOREIGN KEY REFERENCES TipoEntradaSalida(IdTipo),
IdCliente INT FOREIGN KEY REFERENCES Clientes(IdCliente),
Descripcion VARCHAR(250) NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE DetalleRegistroEntrada(
IdDetalleRegistroEntrada INT PRIMARY KEY IDENTITY,
IdRegistroEntrada INT FOREIGN KEY REFERENCES RegistroEntradas(IdRegistroEntrada),
IdProducto INT FOREIGN KEY REFERENCES Productos(IdProducto),
Cantidad INT NOT NULL,
PrecioCompra DECIMAL(20,2) NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE DetalleRegistroSalida(
IdDetalleRegistroSalida INT PRIMARY KEY IDENTITY,
IdProducto INT FOREIGN KEY REFERENCES Productos(IdProducto),
Cantidad INT NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE Roles(
IdRol INT PRIMARY KEY IDENTITY,
Rol VARCHAR(20) NOT NULL
)
GO

CREATE TABLE Usuarios(
IdUsuario INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(50) NOT NULL,
IdRol INT FOREIGN KEY REFERENCES Roles(IdRol)
)
GO

CREATE TABLE MovimientosInventario(
IdMovimientoInventario INT PRIMARY KEY IDENTITY,
TipoMovimiento BIT NOT NULL, -- 1 será entrada, 0 será salida
IdDetalleRegistroEntrada INT FOREIGN KEY REFERENCES DetalleRegistroEntrada(IdDetalleRegistroEntrada) NULL,
IdDetalleRegistroSalida INT FOREIGN KEY REFERENCES DetalleRegistroSalida(IdDetalleRegistroSalida) NULL,
IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario),
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO

CREATE TABLE StockInventario(
IdStrockInventario INT PRIMARY KEY IDENTITY,
IdMovimientoInventario INT FOREIGN KEY REFERENCES MovimientosInventario(IdMovimientoInventario),
CantidadActual INT NOT NULL,
StockMinimmo INT NOT NULL,
Activo BIT NOT NULL,--InicioPistasAuditoria
IdUsuarioRegistro INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL--FinPistasAuditoria
)
GO