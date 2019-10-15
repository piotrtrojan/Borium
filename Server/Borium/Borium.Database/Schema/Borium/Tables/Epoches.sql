CREATE TABLE Borium.Epoches
(
	Id			INT NOT NULL PRIMARY KEY,
	Name		nvarchar(max) NULL,
	Description nvarchar(max) NULL,
	StartYear	int NULL,
	EndYear		int NULL,

	CONSTRAINT PK_Epoches
		PRIMARY KEY (Id ASC),
)
