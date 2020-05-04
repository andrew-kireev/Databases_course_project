USE Bank
IF OBJECT_ID('dbo.Credit', 'U') IS NOT NULL DROP TABLE dbo.Credit;
CREATE TABLE dbo.Credit
(
IdCredit INT IDENTITY(1,1) CONSTRAINT pk_Credit PRIMARY KEY,
IdClient INT NOT NULL,
BeginData date,
EndDate date,
Amount money,
Term date
);

