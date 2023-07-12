drop database bd_comercial;

create database bd_comercial
go

use bd_comercial

go

create table tb_personal(
	dni int not null primary key,
	nombre varchar(20) not null,
	ap_paterno varchar(20)not null,
	ap_materno varchar(20) not null,
	fecha_nacimiento date,
	genero char(1))
go

set dateformat 'dmy'
go


insert into tb_personal values
('40414243','Carla','Ramos','Flores','12-04-2001','F'),
('40414244','Raul','Torres','Mejia','31-05-2002','M'),
('40414245','Xiomara','Ramos','Flores','29-04-2002','F'),
('40414246','Maria','Torres','Mejia','20-09-2004','F'),
('40414247','Lucia','Ramos','Flores','20-10-2005','F'),
('40414248','Pedro','Torres','Mejia','20-01-2006','M'),
('40414249','Cocoa','Ramos','Flores','20-04-2007','M'),
('40414250','Vega','Torres','Mejia','20-06-2008','M'),
('40414251','Rene','Ramos','Flores','10-08-2009','M'),
('40414252','Yohana','Torres','Mejia','15-12-2010','F'),
('40414253','Rasputia','Ramos','Flores','12-01-2011','F'),
('40414254','Michel','Torres','Mejia','10-05-2012','M'),
('40414255','Juan','Gamboa','Quispe','23-01-2004','M')
go


-----------------------------------------------------------
    CREATE TABLE HistorialVuelos (
    id INT PRIMARY KEY,
    fecha_vuelo DATE,
    origen VARCHAR(50),
    destino VARCHAR(50),
    duracion INT,
    aeronave_id INT,
    piloto_id INT,
    FOREIGN KEY (aeronave_id) REFERENCES Aeronaves(id),
    FOREIGN KEY (piloto_id) REFERENCES tb_personal(dni)
);


   CREATE TABLE Aeronaves (
   id INT PRIMARY KEY,
   nombre VARCHAR(50),
   descripcion TEXT
	);

	CREATE TABLE Personal (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    puesto VARCHAR(50),
    salario DECIMAL(10, 2),
    fecha_contrato DATE
    );

    CREATE TABLE Destinos (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    ubicacion VARCHAR(100),
    descripcion TEXT
    );

   
    CREATE TABLE PlanesVuelo (
    id INT PRIMARY KEY,
    fecha_salida DATETIME,
    fecha_llegada DATETIME,
    destino_id INT,
    FOREIGN KEY (destino_id) REFERENCES Destinos(id)
    );

    
-----------------------------------------------------------


select * from tb_personal
go

create procedure sp_ListarPersonal
as
begin
select * from tb_personal
end
go

use bd_comercial