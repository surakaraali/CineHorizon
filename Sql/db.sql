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

ALTER TABLE Movies
ADD type varchar(50);

UPDATE movies
SET type = 'series'
WHERE movieid = '1';

UPDATE movies
SET type = 'movie'
WHERE movieid IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

UPDATE movies
SET type = 'series'
WHERE movieid IN (13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24);

ALTER TABLE movies ALTER COLUMN moviehour TYPE varchar(50) ; // change datatype

UPDATE movies
SET moviehour = '2m, 37 episodes'
WHERE movieid = '14';

UPDATE movies
SET moviehour = '7 seasons, 52 episodes per season'
WHERE movieid = '15';

UPDATE movies
SET moviehour = '22m, 236 episodes total'
WHERE movieid = '16';

UPDATE movies
SET moviehour = '60m, 73 episodes total'
WHERE movieid = '17';

UPDATE movies
SET moviehour = '3 seasons, 10 episodes per season'
WHERE movieid = '18';

UPDATE movies
SET moviehour = '3 seasons, 104 episodes'
WHERE movieid = '19';

UPDATE movies
SET moviehour = '3 seasons, 104 episodes'
WHERE movieid = '20';

UPDATE movies
SET moviehour = '3 seasons, 30 episodes per season'
WHERE movieid = '21';

UPDATE movies
SET moviehour = '9 seasons, 201 episodes'
WHERE movieid = '22';

UPDATE movies
SET moviehour = '35+ seasons, 700+ episodes'
WHERE movieid = '23';

UPDATE movies
SET moviehour = '6 seasons, 86 episodes'
WHERE movieid = '24';


CREATE TABLE comments (
    id SERIAL PRIMARY KEY,
    movieid INT NOT NULL,
    content TEXT NOT NULL,
    createdat TIMESTAMP NOT NULL,
    CONSTRAINT fk_movie_comment FOREIGN KEY (movieid) REFERENCES movies(movieid) ON DELETE CASCADE
);
