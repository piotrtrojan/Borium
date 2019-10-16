CREATE TABLE Borium.Works
(
	Id		INT				IDENTITY(1,1) NOT NULL,
	Title	nvarchar(max)	NULL,
	EpochId int				NOT NULL,

	CONSTRAINT PK_Works
		PRIMARY KEY (Id ASC),
	
	CONSTRAINT FK_Works_Epoches_EpochId
		FOREIGN KEY (EpochId)
		REFERENCES Borium.Epoches(Id)
)
