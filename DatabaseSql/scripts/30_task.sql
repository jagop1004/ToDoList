USE todolistDB;
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tasks')
BEGIN
    CREATE TABLE Tasks (
        Id INT PRIMARY KEY IDENTITY(1,1),
        BoardId INT NOT NULL, -- FK to Boards
        Title NVARCHAR(255) NOT NULL,
        Description NVARCHAR(MAX),
        DueDate DATETIME,
        IsCompleted BIT,
        Status INT,
        AssignedTo INT, -- FK to User

        -- Define Foreign Keys here
        FOREIGN KEY (BoardId) REFERENCES Boards(Id),
        FOREIGN KEY (AssignedTo) REFERENCES Users(Id)
    );
END
GO