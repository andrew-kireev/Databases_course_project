ALTER TABLE dbo.Card
ADD CONSTRAINT FR_Card_Client
	FOREIGN KEY(IdClient) REFERENCES Clients (IdClient)