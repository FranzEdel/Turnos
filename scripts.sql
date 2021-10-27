SELECT * FROM Especialidades;

DELETE FROM Especialidades;

INSERT INTO Especialidades VALUES('Cardiología'),
                                 ('Cirugía'),
                                 ('Medicina General'),
                                 ('Medicina Interna');

SELECT * FROM Medicos;
INSERT INTO Medicos VALUES
('Juan','Lopez','Junin #100','11223344','juan@mail.com','2021/09/28 08:00','2021/09/28 18:00',2),
('Maria','Perez','Loa #100','55443322','maria@mail.com','2021/10/28 08:00','2021/10/28 18:00',4),
('Javier','Barrero','Av Jaime Mendoza #100','11223344','javier@mail.com','2021/09/28 08:00','2021/09/28 18:00',3);

SELECT * FROM Pacientes;
INSERT INTO Pacientes VALUES
('Juan','Lopez','Junin #100','11223344','juan@mail.com'),
('Maria','Perez','Loa #100','55443322','maria@mail.com'),
('Jhonny','Torres','Colon #100','11223344','jhonny@mail.com'),
('Moises','Quispe','Calvo #500','55443322','moises@mail.com'),
('Ariel','Barrero','Siles #600','11223344','ariel@mail.com'),
('Carla','Duran','Loa #150','55443322','carla@mail.com'),
('Ruth','Gomez','Av Jaime Mendoza #500','11223344','ruth@mail.com');

SELECT * FROM Especialidades e JOIN Medicos m ON e.IdEspecialidad = m.IdMedico
WHERE m.IdMedico = 3


INSERT INTO [Login] VALUES('admin',CONVERT(VARCHAR(128),HASHBYTES('SHA2_256','admin'),2))
SELECT * FROM [Login]
