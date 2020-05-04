ALTER TABLE dbo.TypeCredit
ADD CONSTRAINT FR_TypeCredit_Credit
	FOREIGN KEY(IdCredit) REFERENCES Credit (IdCredit)