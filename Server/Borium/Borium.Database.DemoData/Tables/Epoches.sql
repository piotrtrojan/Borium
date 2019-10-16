BEGIN
	IF EXISTS (
		SELECT Id 
		FROM Borium.Epoches )
	BEGIN
		RAISERROR ('Epoches already created.', 11, 1)
	END
	ELSE 
	BEGIN
		INSERT INTO Borium.Epoches(Name, Description, StartYear, EndYear)
		VALUES
		('Epoch1', 'Desc1', 500, 1200),
		('Epoch2', 'Desc2', 1200, 1400)
	END
END