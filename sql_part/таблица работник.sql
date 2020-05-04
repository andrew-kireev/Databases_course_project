USE Bank
IF OBJECT_ID('dbo.Employees', 'U') IS NOT NULL DROP TABLE dbo.Employees;
CREATE TABLE dbo.Employees
(
IdEmployee INT IDENTITY(1,1) CONSTRAINT pk_employee PRIMARY KEY,
IdBank INT NOT NULL,
[FullName] char(30),
[EmployeeInformation] char(30)
);
