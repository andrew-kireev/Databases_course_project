ALTER TABLE dbo.Employees
ADD CONSTRAINT FR_Employee_Bank
	FOREIGN KEY(IdBank) REFERENCES Bank (IdBank)