ALTER TABLE dbo.Deposit
ADD CONSTRAINT FR_Deposit_Client
	FOREIGN KEY(IdClient) REFERENCES Clients (IdClient)