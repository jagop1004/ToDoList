USE todolistDB;
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Boards')
BEGIN
     CREATE TABLE Boards (
        Id INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(255) NOT NULL
    );
END
GO