BEGIN
	IF EXISTS (
		SELECT Id 
		FROM Borium.Notes )
	BEGIN
		RAISERROR ('Notes already created.', 11, 1)
	END
	ELSE 
	BEGIN
		INSERT INTO Borium.Notes(WorkId, FileName, IsScan)
		VALUES
		(1, 'MyFile1', 1),
		(1, 'MyFile2', 0),
		(2, 'MyFile3', 1),
		(3, 'MyFile4', 1),
		(4, 'MyFile5', 1),
		(4, 'MyFile6', 1)
	END
END