BEGIN
	IF EXISTS (
		SELECT Id 
		FROM Borium.ArtistWork)
	BEGIN
		RAISERROR ('ArtistWork already created.', 11, 1)
	END
	ELSE 
	BEGIN
		INSERT INTO Borium.ArtistWork(ArtistId, WorkId)
		VALUES
		(1, 1),
		(1, 2),
		(1, 3),
		(1, 4),
		(2, 4)
	END
END