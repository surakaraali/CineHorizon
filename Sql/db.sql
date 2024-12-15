-- Movies Tablosu
CREATE TABLE Movies (
    MovieId SERIAL PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Description TEXT,
    PosterUrl TEXT,
    Rating FLOAT,
    ReleaseYear INT,
    MovieHour VARCHAR(10),
    Director VARCHAR(255),
    Writer VARCHAR(255),
    Trailer TEXT
);

-- Genres Tablosu
CREATE TABLE Genres (
    GenreId SERIAL PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);

-- Actors Tablosu
CREATE TABLE Actors (
    ActorId SERIAL PRIMARY KEY,
    Name VARCHAR(255) NOT NULL
);

-- Many-to-Many: MovieGenres
CREATE TABLE MovieGenres (
    MovieId INT NOT NULL,
    GenreId INT NOT NULL,
    PRIMARY KEY (MovieId, GenreId),
    FOREIGN KEY (MovieId) REFERENCES Movies(MovieId) ON DELETE CASCADE,
    FOREIGN KEY (GenreId) REFERENCES Genres(GenreId) ON DELETE CASCADE
);

-- Many-to-Many: MovieActors
CREATE TABLE MovieActors (
    MovieId INT NOT NULL,
    ActorId INT NOT NULL,
    PRIMARY KEY (MovieId, ActorId),
    FOREIGN KEY (MovieId) REFERENCES Movies(MovieId) ON DELETE CASCADE,
    FOREIGN KEY (ActorId) REFERENCES Actors(ActorId) ON DELETE CASCADE
);
