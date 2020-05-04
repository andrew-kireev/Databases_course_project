USE Bank
IF OBJECT_ID('dbo.Deposit', 'U') IS NOT NULL DROP TABLE dbo.Deposit;
CREATE TABLE dbo.Deposit
(
IdDeposit INT IDENTITY(1,1) CONSTRAINT pk_Deposit PRIMARY KEY,
IdClient INT NOT NULL,
[DepostiInformation] char(30),
BeginData date,
EndDate date,
Amount money,
Term date,
Procent INT
);