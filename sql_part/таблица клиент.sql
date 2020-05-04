USE Bank
IF OBJECT_ID('dbo.Clients', 'U') IS NOT NULL DROP TABLE dbo.Clients;
CREATE TABLE dbo.Clients
(
IdClient INT IDENTITY(1,1) CONSTRAINT pk_client PRIMARY KEY,
[FullName] char(30),
[Work] char(30),
[AdressLiving] char(30),
[BankPlace] char(30),
[passport data] char(30),
IdBank INT NOT NUll
);