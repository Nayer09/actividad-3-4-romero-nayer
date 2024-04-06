CREATE DATABASE EMPRESA


CREATE TABLE Cliente (
    IDCliente INT IDENTITY (1,1) NOT NULL,
    Nombre NVARCHAR(50)NOT NULL,
    Apellido NVARCHAR(50)NOT NULL,
    CorreoElectronico NVARCHAR(100)NOT NULL,
    Telefono NVARCHAR(20)NOT NULL,
    Direccion NVARCHAR(100)NOT NULL,
	PRIMARY KEY (IDCliente),
);

CREATE TABLE Pedido (
    IDPedido INT IDENTITY(1,1),
    IDCliente INT NOT NULL,
    Fecha DATETIME NOT NULL,
    Total DECIMAL(10, 2) NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
	PRIMARY KEY (IDPedido),
    FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente)
);


INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Juan', 'Perez', 'juan@example.com', '1234567890', 'Calle 123');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('María', 'Gómez', 'maria@example.com', '0987654321', 'Avenida 456');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Carlos', 'López', 'carlos@example.com', '5551234567', 'Boulevard 789');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Ana', 'Martínez', 'ana@example.com', '7778889999', 'Plaza 101');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Pedro', 'Rodríguez', 'pedro@example.com', '9876543210', 'Avenida 202');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Laura', 'Hernández', 'laura@example.com', '1112223333', 'Calle 404');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Miguel', 'Díaz', 'miguel@example.com', '9998887777', 'Boulevard 606');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Sofía', 'García', 'sofia@example.com', '2223334444', 'Plaza 808');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Alejandro', 'López', 'alejandro@example.com', '4445556666', 'Avenida 909');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Lucía', 'Sánchez', 'lucia@example.com', '6667778888', 'Calle 111');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Eduardo', 'Pérez', 'eduardo@example.com', '3334445555', 'Boulevard 212');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Carmen', 'Martínez', 'carmen@example.com', '8889990000', 'Plaza 515');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Daniel', 'Gómez', 'daniel@example.com', '7776665555', 'Avenida 616');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Isabel', 'Fernández', 'isabel@example.com', '5556667777', 'Calle 717');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Fernando', 'Hernández', 'fernando@example.com', '6665554444', 'Boulevard 818');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Marcela', 'Ruiz', 'marcela@example.com', '4443332222', 'Plaza 919');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Roberto', 'Sánchez', 'roberto@example.com', '2223334444', 'Avenida 020');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Patricia', 'López', 'patricia@example.com', '3334445555', 'Calle 121');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Ricardo', 'Martínez', 'ricardo@example.com', '5554443333', 'Boulevard 222');
INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion)
VALUES ('Gabriela', 'González', 'gabriela@example.com', '4445556666', 'Plaza 323');


INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (1, '2024-04-01', 100.00, 'pendiente');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (2, '2024-04-02', 150.50, 'en proceso');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (3, '2024-04-03', 200.25, 'completado');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (4, '2024-04-04', 75.80, 'pendiente');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (5, '2024-04-05', 300.00, 'en proceso');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (6, '2024-04-06', 50.75, 'completado');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (7, '2024-04-07', 80.20, 'pendiente');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (8, '2024-04-08', 120.00, 'en proceso');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (9, '2024-04-09', 180.50, 'completado');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (10, '2024-04-10', 95.25, 'pendiente');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (11, '2024-04-11', 220.75, 'en proceso');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (12, '2024-04-12', 150.80, 'completado');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (13, '2024-04-13', 45.00, 'pendiente');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (14, '2024-04-14', 75.25, 'en proceso');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (15, '2024-04-15', 200.50, 'completado');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (16, '2024-04-16', 85.80, 'pendiente');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (17, '2024-04-17', 130.00, 'en proceso');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (18, '2024-04-18', 175.25, 'completado');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (19, '2024-04-19', 60.75, 'pendiente');
INSERT INTO Pedido (IDCliente, Fecha, Total, Estado) VALUES (20, '2024-04-20', 300.00, 'en proceso');

