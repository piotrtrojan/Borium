CREATE TABLE Borium.Epoches
(
	Id			INT IDENTITY(1,1) NOT NULL,
	Name		nvarchar(max) NULL,
	Description nvarchar(max) NULL,
	StartYear	int NULL,
	EndYear		int NULL,

	CONSTRAINT PK_Epoches
		PRIMARY KEY (Id ASC),
)
