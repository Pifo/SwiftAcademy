
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/21/2015 13:13:54
-- Generated from EDMX file: D:\IDE\VS_Comunity_2013\SwiftAcad\MovieStore\MovieStore\DbRentals.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db_rentals];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserRent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rents] DROP CONSTRAINT [FK_UserRent];
GO
IF OBJECT_ID(N'[dbo].[FK_RentDvd]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Dvds] DROP CONSTRAINT [FK_RentDvd];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Dvds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dvds];
GO
IF OBJECT_ID(N'[dbo].[Rents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rents];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [CardNumber] int  NOT NULL,
    [NumberOfCharges] int  NOT NULL
);
GO

-- Creating table 'Dvds'
CREATE TABLE [dbo].[Dvds] (
    [DvdId] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [DvdNumber] int  NOT NULL,
    [Available] bit  NULL,
    [Price] decimal(18,0)  NOT NULL,
    [Genre] int  NOT NULL,
    [RentId] int  NULL
);
GO

-- Creating table 'Rents'
CREATE TABLE [dbo].[Rents] (
    [RentId] int IDENTITY(1,1) NOT NULL,
    [DueDate] datetime  NULL,
    [ReturnDate] datetime  NULL,
    [OverduedDays] int  NULL,
    [Charge] decimal(18,0)  NULL,
    [UserId] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [DvdId] in table 'Dvds'
ALTER TABLE [dbo].[Dvds]
ADD CONSTRAINT [PK_Dvds]
    PRIMARY KEY CLUSTERED ([DvdId] ASC);
GO

-- Creating primary key on [RentId] in table 'Rents'
ALTER TABLE [dbo].[Rents]
ADD CONSTRAINT [PK_Rents]
    PRIMARY KEY CLUSTERED ([RentId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'Rents'
ALTER TABLE [dbo].[Rents]
ADD CONSTRAINT [FK_UserRent]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserRent'
CREATE INDEX [IX_FK_UserRent]
ON [dbo].[Rents]
    ([UserId]);
GO

-- Creating foreign key on [RentId] in table 'Dvds'
ALTER TABLE [dbo].[Dvds]
ADD CONSTRAINT [FK_RentDvd]
    FOREIGN KEY ([RentId])
    REFERENCES [dbo].[Rents]
        ([RentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RentDvd'
CREATE INDEX [IX_FK_RentDvd]
ON [dbo].[Dvds]
    ([RentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------