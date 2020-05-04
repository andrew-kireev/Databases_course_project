USE Bank
IF OBJECT_ID('dbo.TypeCredit', 'U') IS NOT NULL DROP TABLE dbo.TypeCredit;
CREATE TABLE dbo.TypeCredit
(
IdCredit INT NOT NULL,
Amount money,
TypeCurrency char(30),
Procent INT
);

