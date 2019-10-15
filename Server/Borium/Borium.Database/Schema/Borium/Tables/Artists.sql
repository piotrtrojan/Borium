CREATE TABLE Borium.Artists
(
	Id			int				IDENTITY(1,1) NOT NULL,
	Name		nvarchar(max)	NULL,
	Surname		nvarchar(max)	NULL,
	Nationality nvarchar(max)	NULL,
	
	CONSTRAINT PK_Artists 
		PRIMARY KEY(Id ASC)
)