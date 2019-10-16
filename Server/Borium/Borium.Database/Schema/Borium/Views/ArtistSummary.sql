CREATE VIEW [Borium].[ArtistSummary] AS
	SELECT 
		a.Id,
		a.Name,
		COUNT (DISTINCT aw.WorkId) as WorksCount,
		COUNT (DISTINCT n.FileName)as NotesCount

	FROM Borium.Artists a
	LEFT JOIN Borium.ArtistWork aw
		ON aw.ArtistId = a.Id
	LEFT JOIN Borium.Notes n
		ON n.WorkId = aw.WorkId
	GROUP BY a.Id, a.Name

