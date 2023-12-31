DROP TABLE IF EXISTS TBLROLES CASCADE;
DROP TABLE IF EXISTS TBLCLIENTES CASCADE;
DROP TABLE IF EXISTS TBLCATEGORIA_PROD CASCADE;
DROP TABLE IF EXISTS TBLESTADO_FACTURA CASCADE;
DROP TABLE IF EXISTS TBLEMPLEADO CASCADE;
DROP TABLE IF EXISTS TBLSEGURIDAD CASCADE;
DROP TABLE IF EXISTS TBLFACTURA CASCADE;
DROP TABLE IF EXISTS TBLDETALLE_FACTURA CASCADE;
DROP TABLE IF EXISTS TBLPRODUCTO CASCADE;


DROP SEQUENCE IF EXISTS id_categoria_producto_seq CASCADE;
DROP SEQUENCE IF EXISTS id_cliente_seq CASCADE;
DROP SEQUENCE IF EXISTS id_detalle_factura_seq CASCADE;
DROP SEQUENCE IF EXISTS id_empleado_seq CASCADE;
DROP SEQUENCE IF EXISTS id_estado_factura_seq CASCADE;
DROP SEQUENCE IF EXISTS id_factura_seq CASCADE;
DROP SEQUENCE IF EXISTS id_producto_seq CASCADE;
DROP SEQUENCE IF EXISTS id_seguridad_seq CASCADE;
DROP SEQUENCE IF EXISTS id_rol_seq CASCADE;
DROP TYPE IF EXISTS estado_factura CASCADE;


-- Crear secuencias, para poder tener un mayor control en la base de datos 
CREATE SEQUENCE id_categoria_producto_seq START WITH 1 INCREMENT BY 1 MAXVALUE 999 MINVALUE 1;
CREATE SEQUENCE id_cliente_seq START WITH 1000 INCREMENT BY 1 MAXVALUE 1999 MINVALUE 1000;
CREATE SEQUENCE id_detalle_factura_seq START WITH 2000 INCREMENT BY 1 MAXVALUE 2999 MINVALUE 2000;
CREATE SEQUENCE id_empleado_seq START WITH 3000 INCREMENT BY 1 MAXVALUE 3999 MINVALUE 3000;
CREATE SEQUENCE id_estado_factura_seq START WITH 4000 INCREMENT BY 1 MAXVALUE 4999 MINVALUE 4000;
CREATE SEQUENCE id_factura_seq START WITH 5000 INCREMENT BY 1 MAXVALUE 5999 MINVALUE 5000;
CREATE SEQUENCE id_producto_seq START WITH 6000 INCREMENT BY 1 MAXVALUE 6999 MINVALUE 6000;
CREATE SEQUENCE id_seguridad_seq START WITH 7000 INCREMENT BY 1 MAXVALUE 7999 MINVALUE 7000;
CREATE SEQUENCE id_rol_seq START WITH 8000 INCREMENT BY 1 MAXVALUE 8999 MINVALUE 8000;
CREATE TYPE estado_factura AS ENUM ('Pendiente', 'Pagada', 'Cancelada');
-- ID 8000
CREATE TABLE TBLROLES(
	IdRolEmpleado INT DEFAULT NEXTVAL('id_rol_seq') NOT NULL,
	StrDescripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_TBLROLES PRIMARY KEY(IdRolEmpleado)
);
-- ID 1
CREATE TABLE TBLCATEGORIA_PROD (
	IdCategoria INT DEFAULT NEXTVAL('id_categoria_producto_seq'),
	StrDescripcion varchar(60) NOT NULL,
	DtmFechaModifica timestamp NOT NULL,
	StrUsuarioModifico varchar(40),
	CONSTRAINT PK_TBLCATEGORIA_PROD PRIMARY KEY (IdCategoria)
);
-- ID 4000
CREATE TABLE TBLESTADO_FACTURA(
	IdEstadoFactura INT DEFAULT NEXTVAL('id_estado_factura_seq'),
	StrDescripcion estado_factura NOT NULL,
	CONSTRAINT PK_TBLESTADO_FACTURA PRIMARY KEY(IdEstadoFactura)
);
-- ID 1000
CREATE TABLE TBLCLIENTES (
	IdCliente INT DEFAULT NEXTVAL('id_cliente_seq'),
	StrNombre varchar(55) NOT NULL,
	NumDocumento bigint NOT NULL,
	StrDireccion varchar(70),
	StrTelefono varchar(30) NOT NULL,
	StrEmail varchar(50) NOT NULL,
	DtmFechaModifica timestamp NOT NULL,
	StrUsuarioModifica varchar(40),
	CONSTRAINT PK_TBLCLIENTES PRIMARY KEY(IdCliente)
);
-- ID 3000
CREATE TABLE TBLEMPLEADO (
	IdEmpleado INT DEFAULT NEXTVAL('id_empleado_seq'),
	strNombre varchar(50) NOT NULL,
	NumDocumento bigint NOT NULL,
	StrDireccion varchar(100) NOT NULL,
	StrTelefono varchar(50) NOT NULL,
	StrEmail varchar(50) NOT NULL,
	IdRolEmpleado int NOT NULL,
	DtmIngreso timestamp NOT NULL,
	DtmRetiro timestamp NOT NULL,
	strDatosAdicionales text NOT NULL,
	DtmFechaModifica timestamp NOT NULL,
	StrUsuarioModifico varchar(50),
	CONSTRAINT PK_TBLEMPLEADO PRIMARY KEY(IdEmpleado),
	CONSTRAINT FK_TBLEMPLEADO_Y_TBLROLES FOREIGN KEY (IdRolEmpleado) REFERENCES TBLROLES(IdRolEmpleado) ON DELETE CASCADE
);
-- ID 7000
CREATE TABLE TBLSEGURIDAD(
	IdSeguridad INT DEFAULT NEXTVAL('id_seguridad_seq'),
	IdEmpleado INT NOT NULL,
	StrUsuario VARCHAR(50),
	StrClave VARCHAR(50),
	DtmFechaModifica TIMESTAMP,
	StrUsuarioModifico VARCHAR(50),
	CONSTRAINT PK_TBLSEGURIDAD PRIMARY KEY(IdSeguridad),
	CONSTRAINT FK_TBLSEGURIDAD_Y_TBLEMPLEADO FOREIGN KEY (IdEmpleado) REFERENCES TBLEMPLEADO(IdEmpleado) ON DELETE CASCADE
);
-- ID 5000
CREATE TABLE TBLFACTURA (
	IdFactura INT DEFAULT NEXTVAL('id_factura_seq'),
	DtmFecha timestamp NOT NULL,
	IdCliente int NOT NULL,
	IdEmpleado int NOT NULL,
	NumDescuento int NOT NULL,
	NumImpuesto int NOT NULL,
	NumValorTotal int NOT NULL,
	IdEstado int NOT NULL,
	DtmFechaModifica timestamp NOT NULL,
	StrUsuarioModifica varchar(40),
	CONSTRAINT PK_TBLFACTURA PRIMARY KEY(IdFactura),
	CONSTRAINT FK_TBLFACTURA_Y_TBLCLIENTES FOREIGN KEY (IdCliente) REFERENCES TBLCLIENTES(IdCliente) ON DELETE CASCADE,
	CONSTRAINT FK_TBLFACTURA_Y_TBLEMPLEADO FOREIGN KEY (IdEmpleado) REFERENCES TBLEMPLEADO(IdEmpleado) ON DELETE CASCADE,
	CONSTRAINT FK_TBLFACTURA_Y_TBLESTADO_FACTURA FOREIGN KEY (IdEstado) REFERENCES TBLESTADO_FACTURA(IdEstadoFactura) ON DELETE CASCADE
);
-- ID 2000
CREATE TABLE TBLDETALLE_FACTURA (
	IdDetalle INT DEFAULT NEXTVAL('id_detalle_factura_seq'),
	IdFactura int NOT NULL,
	NumCantidad int NOT NULL,
	IdProducto int NOT NULL,
	NumPrecio float NOT NULL,
	CONSTRAINT PK_TBLDETALLE_FACTURA PRIMARY KEY(IdDetalle),
	CONSTRAINT FK_TBLDETALLE_FACTURA_Y_TBLFACTURA FOREIGN KEY (IdFactura) REFERENCES TBLFACTURA(IdFactura) ON DELETE CASCADE
);
-- ID 6000
CREATE TABLE TBLPRODUCTO(
	IdProducto INT DEFAULT NEXTVAL('id_producto_seq'),
	StrNombre VARCHAR(70) NOT NULL,
	StrCodigo VARCHAR(30) NOT NULL,
	NumPrecioCompra int NOT NULL,
	NumPrecioVenta int NOT NULL,
	IdCategoria INTEGER NOT NULL,
	StrDetalle VARCHAR(50) NOT NULL,
	strFoto VARCHAR(50) NOT NULL,
	NumStock INT NOT NULL,
	DtmFechaModifica TIMESTAMP NOT NULL,
	StrUsuarioModifica VARCHAR(40),
	CONSTRAINT PK_TBLPRODUCTO PRIMARY KEY(IdProducto),
	CONSTRAINT FK_TBLPRODUCTO_Y_TBLCATEGORIA_PROD FOREIGN KEY (IdCategoria) REFERENCES TBLCATEGORIA_PROD(IdCategoria) ON DELETE CASCADE
);


-- Valores de ejemplo

INSERT INTO TBLROLES (StrDescripcion)
VALUES ('Role 1'),
	('Role 2'),
	('Role 3');

INSERT INTO TBLCATEGORIA_PROD (StrDescripcion, DtmFechaModifica)
VALUES ('Category 1', current_timestamp),
	('Category 2', current_timestamp),
	('Category 3', current_timestamp);
INSERT INTO TBLESTADO_FACTURA (StrDescripcion)
VALUES ('Pendiente'),
	('Pagada'),
	('Cancelada');

INSERT INTO TBLCLIENTES (
		StrNombre,
		NumDocumento,
		StrDireccion,
		StrTelefono,
		StrEmail,
		DtmFechaModifica
	)
VALUES (
		'Client 1',
		123456789,
		'Address 1',
		'1234567890',
		'client1@example.com',
		current_timestamp
	),
	(
		'Client 2',
		987654321,
		'Address 2',
		'9876543210',
		'client2@example.com',
		current_timestamp
	),
	(
		'Client 3',
		456789123,
		'Address 3',
		'4567891230',
		'client3@example.com',
		current_timestamp
	);

INSERT INTO TBLEMPLEADO (
		strNombre,
		NumDocumento,
		StrDireccion,
		StrTelefono,
		StrEmail,
		IdRolEmpleado,
		DtmIngreso,
		DtmRetiro,
		strDatosAdicionales,
		DtmFechaModifica
	)
VALUES (
		'Employee 1',
		123456789,
		'Address 1',
		'1234567890',
		'employee1@example.com',
		8000,
		current_timestamp,
		current_timestamp,
		'Additional data 1',
		current_timestamp
	),
	(
		'Employee 2',
		987654321,
		'Address 2',
		'9876543210',
		'employee2@example.com',
		8001,
		current_timestamp,
		current_timestamp,
		'Additional data 2',
		current_timestamp
	),
	(
		'Employee 3',
		456789123,
		'Address 3',
		'4567891230',
		'employee3@example.com',
		8002,
		current_timestamp,
		current_timestamp,
		'Additional data 3',
		current_timestamp
	);


INSERT INTO TBLSEGURIDAD (
		IdEmpleado,
		StrUsuario,
		StrClave,
		DtmFechaModifica
	)
VALUES (
		3000,
		'admin',
		'123',
		current_timestamp
	),
	(
		3001,
		'user2',
		'password2',
		current_timestamp
	),
	(
		3002,
		'user3',
		'password3',
		current_timestamp
	);
INSERT INTO TBLFACTURA (
		DtmFecha,
		IdCliente,
		IdEmpleado,
		NumDescuento,
		NumImpuesto,
		NumValorTotal,
		IdEstado,
		DtmFechaModifica
	)
VALUES (
		current_timestamp,
		1000,
		3000,
		1,
		2,
		100,
		4000,
		current_timestamp
	),
	(
		current_timestamp,
		1001,
		3001,
		2,
		3,
		200,
		4001,
		current_timestamp
	),
	(
		current_timestamp,
		1002,
		3002,
		3,
		4,
		300,
		4002,
		current_timestamp
	);


INSERT INTO TBLDETALLE_FACTURA (IdFactura, NumCantidad, IdProducto, NumPrecio)
VALUES (5000, 1, 6000, 10.0),
	(5001, 2, 6001, 20.0),
	(5002, 3, 6002, 30.0);
INSERT INTO TBLPRODUCTO (
		StrNombre,
		StrCodigo,
		NumPrecioCompra,
		NumPrecioVenta,
		IdCategoria,
		StrDetalle,
		strFoto,
		NumStock,
		DtmFechaModifica
	)
VALUES (
		'Product 1',
		'Code 1',
		5,
		10,
		1,
		'Detail 1',
		'photo1.jpg',
		100,
		current_timestamp
	),
	(
		'Product 2',
		'Code 2',
		5,
		10,
		2,
		'Detail 1',
		'photo1.jpg',
		100,
		current_timestamp
	),
	(
		'Product 3',
		'Code 3',
		5,
		10,
		3,
		'Detail 1',
		'photo1.jpg',
		100,
		current_timestamp
	);	


	SELECT *
	FROM TBLPRODUCTO;

	SELECT *
	FROM TBLROLES;

	SELECT *
	FROM TBLDETALLE_FACTURA;

	SELECT *
	FROM TBLFACTURA;

	SELECT *
	FROM TBLSEGURIDAD;

	SELECT *
	FROM TBLEMPLEADO;

	SELECT *
	FROM TBLCLIENTES;

	SELECT *
	FROM TBLESTADO_FACTURA;

	SELECT *
	FROM TBLCATEGORIA_PROD;

