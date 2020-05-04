ALTER TABLE dbo.Credit
ADD CONSTRAINT FR_Credit_Client
	FOREIGN KEY(IdClient) REFERENCES Clients (IdClient)