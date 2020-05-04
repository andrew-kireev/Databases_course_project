USE Bank
IF OBJECT_ID('dbo.Bank', 'U') IS NOT NULL DROP TABLE dbo.Bank;
CREATE TABLE dbo.Bank
(
IdBank INT IDENTITY(1,1) CONSTRAINT pk_bank PRIMARY KEY,
IdClient INT,
employees INT,
);