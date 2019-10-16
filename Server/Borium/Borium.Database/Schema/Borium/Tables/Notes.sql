CREATE TABLE Borium.Notes
(
	Id			INT				IDENTITY(1,1) NOT NULL,
	WorkId		int				NOT NULL,
	IsScan		bit				NOT NULL,
	FileName	nvarchar(max)	NULL,

	CONSTRAINT PK_Notes
		PRIMARY KEY (Id ASC),

	CONSTRAINT FK_Notes_Works_WorkId
		FOREIGN KEY (WorkId)
		REFERENCES Borium.Works(Id)
)
