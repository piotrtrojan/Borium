CREATE TABLE Borium.Works
(
	Id		INT				NOT NULL PRIMARY KEY,
	Title	nvarchar(max)	NULL,
	Age		int				NULL,
	EpochId int				NOT NULL,

	CONSTRAINT PK_Works
		PRIMARY KEY (Id ASC),
	
	CONSTRAINT FK_Works_Epoches_EpochId
		FOREIGN KEY (EpochId)
		REFERENCES Borium.Epoches(Id)
)
