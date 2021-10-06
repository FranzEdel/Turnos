SELECT * FROM Especialidades;

INSERT INTO Especialidades VALUES('Cardiología'),
                                 ('Cirugía'),
                                 ('Medicina General'),
                                 ('Medicina Interna');

SELECT * FROM Medicos;
INSERT INTO Medicos VALUES('Juan','Lopez','Junin #100','11223344','juan@mail.com','2021/09/28 08:00','2021/09/28 18:00');

SELECT * FROM Especialidades e JOIN Medicos m ON e.IdEspecialidad = m.IdMedico
WHERE m.IdMedico = 3


INSERT INTO [Login] VALUES('admin',CONVERT(VARCHAR(128),HASHBYTES('SHA2_256','admin'),2))
SELECT * FROM [Login]
