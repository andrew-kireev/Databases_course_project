USE Bank
IF OBJECT_ID('dbo.Card', 'U') IS NOT NULL DROP TABLE dbo.Card;
CREATE TABLE dbo.Card
(
IdCard INT IDENTITY(1,1) CONSTRAINT pk_Card PRIMARY KEY,
IdClient INT NOT NULL,
[CardiInformation] char(30),
BeginData date,
EndDate date,
[Debet] char(5),
[Credit] char(5),
);