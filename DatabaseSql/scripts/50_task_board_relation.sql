USE todolistDB;
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TasksBoards')
BEGIN
    CREATE TABLE TasksBoards(
        Id INT PRIMARY KEY IDENTITY(1,1),
        TasksId INT NOT NULL,
        BoardsId INT NOT NULL,

        -- Define Foreign Keys
        FOREIGN KEY (TasksId) REFERENCES Tasks(Id),
        FOREIGN KEY (BoardsId) REFERENCES Boards(Id),

        -- Add a combined unique constraint
        UNIQUE (TasksId, BoardsId)
    );
END
GO