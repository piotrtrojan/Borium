BEGIN
	IF EXISTS (
		SELECT Id 
		FROM Borium.Artists )
	BEGIN
		RAISERROR ('Artists already created.', 11, 1)
	END
	ELSE 
	BEGIN
		INSERT INTO Borium.Artists(Name, Surname, Nationality)
		VALUES
		('Johann Sebastian', 'Bach', 'DE'),
		('Fryderyk', 'Chopin', 'PL'),
		('Ludwig', 'van Beethoven', 'AU'),
		('Artur', 'Rubinstein', 'PL')
	END
END