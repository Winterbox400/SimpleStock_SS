/*CREACIÓN DE VISTAS PARA LA APP "SIMPLESTOCK SS"	*/
/*Author	@JUSTIN STEVEN DETRINIDAD SANDIGO		*/
/*Nickname	@WINTERBOX400							*/
GO

USE BD_SimpleStock_SS
GO

/*Mostrar datos en la tabla de "Categoria de Productos"
Al ser datos que el usuario administrador puede crear, modificar u eliminar dentro de la aplicación
Se condiciono de que solo se puedan mostrar los datos "Activos" dentro de la tabla
*/
CREATE VIEW vw_Categorias AS
SELECT
C.IdCategoria AS Codigo,
C.Nombre AS Categoria,
C.Descripcion
FROM Categorias C
WHERE C.Activo = 1
GO

/*Mostrar datos en la tabla de "Marca de Productos"
Al ser datos que el usuario administrador puede crear, modificar u eliminar dentro de la aplicación
Se condiciono de que solo se puedan mostrar los datos "Activos" dentro de la tabla
*/
CREATE VIEW vw_Marcas AS
SELECT
M.IdMarca AS Codigo,
M.Nombre AS Marcas,
M.Descripcion
FROM Marcas M
WHERE M.Activo = 1
GO

/*Mostrar datos en la tabla de "Proveedores de Productos"
Al ser datos que el usuario administrador puede crear, modificar u eliminar dentro de la aplicación
Se condiciono de que solo se puedan mostrar los datos "Activos" dentro de la tabla
*/
CREATE VIEW vw_Proveedores AS
SELECT
PE.IdProveedor AS Codigo,
PE.Nombre AS Proveedores,
PE.Correo,
PE.Telefono
FROM Proveedores PE
WHERE Pe.Activo = 1
GO

/*Mostrar datos en la tabla de "Clientes"
Al ser datos que el usuario administrador puede crear, modificar u eliminar dentro de la aplicación
Se condiciono de que solo se puedan mostrar los datos "Activos" dentro de la tabla
*/
CREATE VIEW vw_Clientes AS
SELECT
CL.IdCliente AS Codigo,
CL.Nombre AS Clientes,
CL.Correo,
CL.Telefono
FROM Clientes CL
WHERE CL.Activo = 1
GO

/*Mostrar datos de la tabla "Catalogo de Productos"
Al ser datos que el usuario administrador puede crear, modificar u eliminar dentro de la aplicación
Se condiciono de que solo se puedan mostrar los datos "Activos" dentro de la tabla, Además 
se realizo la unión con las tablas Categoria, Marca y Proveedor de las cuales solo se mostrará el campo nombre
(Estos campos serán agregados por medio de ComboBox en la UI)
*/
CREATE VIEW vw_CatalogoProductos AS
SELECT
P.IdProducto AS ID,
P.Nombre AS Productos,
P.Almacen,
P.Ubicacion,
C.Nombre AS Categoria,
M.Nombre AS Marca,
PE.Nombre AS Proveedor
FROM Productos P
INNER JOIN Categorias C ON P.IdCategoria = C.IdCategoria
INNER JOIN Marcas M ON P.IdMarca = M.IdMarca
INNER JOIN Proveedores PE ON P.IdProveedore = PE.IdProveedor
WHERE P.Activo = 1
GO

/*Mostrar valores en ComboBox de Categorías
Se mostrará los registros de la tabla categoría en "Formulario Nuevo Producto" y "Actualizar Un Producto"
esto atravez de un ComboBox, dado que el usuario administrador puede Crear, Actualizar o Eliminar categorías
se dejará dentro de la vista la clausula de que solo se mostrarán las categorías activas.
*/
CREATE VIEW vCBoxCategorias AS
SELECT
C.IdCategoria AS Id,
C.Nombre AS Categoria
FROM Categorias C
WHERE C.Activo = 1
GO

/*Mostrar valores en ComboBox de Marcas
Se mostrará los registros de la tabla Marcas en "Formulario Nuevo Producto" y "Actualizar Un Producto"
esto atravez de un ComboBox, dado que el usuario administrador puede Crear, Actualizar o Eliminar categorías
se dejará dentro de la vista la clausula de que solo se mostrarán las categorías activas.
*/
CREATE VIEW vCBoxMarcas AS
SELECT
M.IdMarca AS Id,
M.Nombre AS Marca
FROM Marcas M
WHERE M.Activo = 1
GO

/*Mostrar valores en ComboBox de Proveedores
Se mostrará los registros de la tabla Proveedores en "Formulario Nuevo Producto" y "Actualizar Un Producto"
esto atravez de un ComboBox, dado que el usuario administrador puede Crear, Actualizar o Eliminar categorías
se dejará dentro de la vista la clausula de que solo se mostrarán las categorías activas.
*/
CREATE VIEW vCBoxProveedores AS
SELECT
PE.IdProveedor AS Id,
PE.Nombre AS Proveedor
FROM Proveedores PE
WHERE PE.Activo = 1
GO
