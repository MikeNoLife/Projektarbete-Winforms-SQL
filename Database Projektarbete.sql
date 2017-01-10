USE Projektarbete;

DROP TABLE Employee;
DROP TABLE Department;

CREATE TABLE Department
(
	[Id] INT PRIMARY KEY IDENTITY (0, 1) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
);

INSERT INTO Department ([Name]) 
VALUES	('Ekonomi'),
		('Försäljning'),
		('IT'),
		('Forskning'),
		('Kundsupport');

CREATE TABLE Employee
(
	[Id] INT PRIMARY KEY IDENTITY (0, 1) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(MAX) NOT NULL,
	[Salary] INT NOT NULL,
	[DateOfBirth] DATE NOT NULL,
	[OnParentalLeave] BIT NOT NULL,
	[DepartmentId] INT FOREIGN KEY REFERENCES Department(Id) NOT NULL,
);

INSERT INTO Employee([Name], [Email], [Salary], [DateOfBirth], [OnParentalLeave], [DepartmentId]) 
VALUES	('Adam Ask',		'adam.ask@gmail.com',			310000, '1981-04-16', 0, 0 ),
		('Benjamin Box',	'benjamin-box@hotmail.com',		290000, '1992-05-11', 0, 2 ),
		('Celine Casket',	'celine.casket@hotmail.com',	295000, '1980-12-18', 0, 3 ),
		('David Dynga',		'david.dynga@yahoo.se',			315000, '1989-11-05', 0, 0 ),
		('Eva Ek',			'eva.ek@gmail.com',				330000, '1992-10-29', 0, 1 ),
		('Felicia Falk',	'fiffi.fagel@falkmail.com',		320000, '1988-07-09', 1, 2 ),
		('Gothic Grov',		'grov@gothmail.com',			285000, '1985-09-11', 0, 4 ),
		('Henrik Hagel',	'henrik.hagel@hotmail.com',		295000, '1978-01-25', 0, 3 ),
		('Ida Ivrig',		'idaxx@xxxmail.com',			305000, '1985-04-04', 1, 4 ),
		('Joel Jodel',		'jodlarn@jodel.se',				310000, '1979-02-25', 0, 0 );
