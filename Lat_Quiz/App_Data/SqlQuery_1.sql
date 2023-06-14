CREATE TABLE MsSong(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	SongName VARCHAR(100) NOT NULL,
	ArtistName VARCHAR(100) NOT NULL,
	ReleaseDate DATE NOT NULL,
	SongDescription VARCHAR(255) NOT NULL
)

INSERT INTO MsSong (SongName, ArtistName, ReleaseDate, SongDescription) VALUES 
('123', '123', '2022-01-23', '123')

SELECT * FROM MsSong
