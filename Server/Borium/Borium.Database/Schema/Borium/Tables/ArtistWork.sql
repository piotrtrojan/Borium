CREATE TABLE Borium.ArtistWork
(
	Id			int		IDENTITY(1,1) NOT NULL,
	ArtistId	int		NOT NULL,
	WorkId		int		NOT NULL,

	CONSTRAINT PK_ArtistWork
		PRIMARY KEY (Id ASC),

	CONSTRAINT FK_ArtistWork_Artists_ArtistId
		FOREIGN KEY (ArtistId)
		REFERENCES Borium.Artists(Id),

	CONSTRAINT FK_ArtistWork_Works_WorkId
		FOREIGN KEY (WorkId)
		REFERENCES Borium.Works(Id)
)
