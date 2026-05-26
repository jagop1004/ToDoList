USE todolistDB;
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'BoardsUsers')
BEGIN
    CREATE TABLE BoardsUsers(
        Id INT PRIMARY KEY IDENTITY(1,1),
        BoardsId INT NOT NULL,
        UsersId INT NOT NULL,

        -- Define Foreign Keys
        FOREIGN KEY (BoardsId) REFERENCES Boards(Id),
        FOREIGN KEY (UsersId) REFERENCES Users(Id),

        -- Add a combined unique constraint to prevent duplicates
        UNIQUE (BoardsId, UsersId)
    );
END
GO