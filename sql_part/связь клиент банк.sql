ALTER TABLE dbo.Clients
ADD CONSTRAINT FR_Clients_Bank
	FOREIGN KEY(IdBank) REFERENCES Bank (IdBank)