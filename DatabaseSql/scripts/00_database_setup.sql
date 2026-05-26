IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'todolistDB')
BEGIN
    CREATE DATABASE todolistDB;
END
GO
