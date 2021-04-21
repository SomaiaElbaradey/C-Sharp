IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210406172716_initialCreate', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [frontend] (
    [ID] int NOT NULL IDENTITY,
    [User_name] nvarchar(50) NOT NULL,
    [Pass_word] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_frontend] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [kitchen] (
    [ID] int NOT NULL IDENTITY,
    [User_name] nvarchar(50) NOT NULL,
    [Pass_word] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_kitchen] PRIMARY KEY ([ID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210406175014_frontend and Kitchen', N'5.0.5');
GO

COMMIT;
GO

