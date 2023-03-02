BEGIN TRANSACTION;
CREATE DATABASE veterinaria;
USE veterinaria;
CREATE TABLE IF NOT EXISTS "clientes" (
	"DNI"	TEXT,
	"nombre"	TEXT,
	"apellidos"	TEXT,
	"direccion"	TEXT,
	"telefono"	TEXT,
	"email"	TEXT,
	PRIMARY KEY("DNI")
);
CREATE TABLE IF NOT EXISTS "mascotas" (
	"DNI_Cliente"	TEXT,
	"nombre"	TEXT,
	"raza"	TEXT,
	"edad"	TEXT,
	"Peso"	INTEGER,
	PRIMARY KEY("DNI_Cliente"),
	FOREIGN KEY("DNI_Cliente") REFERENCES "clientes"("DNI") ON DELETE SET NULL
);
INSERT INTO "clientes" ("DNI","nombre","apellidos","direccion","telefono","email") VALUES (`DNI`, `nombre`, `apellidos`, `direccion`, `telefono`, `email`) VALUES
('54555666G', 'Sara', 'Orrego Martín', 'C/Falsa, 5', '657889900', 'sara@lol.com');
INSERT INTO "mascotas" ("DNI_Cliente","nombre","raza","edad","Peso") VALUES INSERT INTO `mascota` (`DNI_Cliente`, `nombre`, `raza`, `edad`) VALUES
('54555666G', 'Lulu', 'perro', 4);
COMMIT;
