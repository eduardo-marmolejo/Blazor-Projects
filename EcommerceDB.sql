IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'EcommerceDB')
CREATE DATABASE EcommerceDB
GO

USE EcommerceDB
GO

CREATE TABLE Categoria(
idCategoria INT PRIMARY KEY IDENTITY,
Nombre VARCHAR (250) NOT NULL,
FechaCreacion DATETIME DEFAULT GETDATE()
);

CREATE TABLE Producto(
idProducto INT PRIMARY KEY IDENTITY,
idCategoria INT NOT NULL,
Nombre VARCHAR (250) NOT NULL,
Descripcion VARCHAR (1000) NOT NULL,
Precio DECIMAL (10,2) NOT NULL,
PrecioOferta DECIMAL (10,2) NOT NULL,
Cantidad INT NOT NULL,
Imagen VARCHAR (MAX) NOT NULL,
FechaCreacion DATETIME DEFAULT GETDATE()

FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
);

CREATE TABLE Usuario(
idUsuario INT PRIMARY KEY IDENTITY,
NombreCompleto VARCHAR (250) NOT NULL,
Correo VARCHAR (250) NOT NULL,
Clave VARCHAR (250) NOT NULL,
Rol VARCHAR (250) NOT NULL,   --Administrador, cliente
FechaCreacion DATETIME DEFAULT GETDATE()
);

create table Venta(
idVenta int primary key identity,
idUsuario INT NOT NULL,
Total decimal(10,2) NOT NULL,
FechaCreacion datetime default getdate()

FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario)
);

create table DetalleVenta
(
idDetalleVenta int primary key identity,
idVenta INT NOT NULL,
idProducto INT NOT NULL,
Cantidad int NOT NULL,
Total decimal(10,2) NOT NULL,

FOREIGN KEY (idVenta) REFERENCES Venta(idVenta),
FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);

--insertamos un usuario para poder iniciar sesion

insert into Usuario(NombreCompleto,Correo,Clave,Rol) values
('Admin','admin@example.com','12345678','Administrador');