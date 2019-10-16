BEGIN
	IF EXISTS (
		SELECT Id 
		FROM Borium.Works )
	BEGIN
		RAISERROR ('Works already created.', 11, 1)
	END
	ELSE 
	BEGIN
		INSERT INTO Borium.Works(Title, EpochId)
		VALUES
		('Four Orchestral Suites', 1),
		('St Matthew Passion', 1),
		('BWV 21', 2),
		('BWV 551', 2)
	END
END