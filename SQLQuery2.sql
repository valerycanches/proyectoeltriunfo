create table Dsemanas
(
id int identity (1,1) primary key,
dia varchar(10) not null,
  docenteId int NOT NULL,
  FOREIGN KEY (docenteId) REFERENCES docente(id)	
)

insert into Dsemanas(dia,docenteId)values('lunes',1),
('martes',2),('miercoles',3),('jueves',4),('viernes',5),
('sabado',3),('domingo',5)

select*from Dsemanas

drop table admins

SELECT nombre, apellido
FROM docente
WHERE codigoD = 990;

select*from docente


create database asistenciaDocente

use asistenciaDocente

create table docentes
(
codigoD int not null,
nombre varchar(30) not null,
apellido varchar(30) not null,
sexo varchar(1) not null,
direccion varchar(20) not null,
telefono int not null,
)
select*from docentes

INSERT INTO docentes (codigoD, nombre, apellido, sexo, direccion, telefono ) 
VALUES(111, 'jakeline','maynas tamani', 'f', 'psje.pebas',961565666)


select*from docentes
