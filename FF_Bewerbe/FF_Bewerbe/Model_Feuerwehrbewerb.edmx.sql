
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/03/2016 09:07:17
-- Generated from EDMX file: C:\GitHub\DBA\FF_Bewerbe\FF_Bewerbe\Model_Feuerwehrbewerb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_Bewerb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_tBewerbZOT_Bewerb_Mannschaft]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tTeilnehmendeMannschaftSet] DROP CONSTRAINT [FK_tBewerbZOT_Bewerb_Mannschaft];
GO
IF OBJECT_ID(N'[dbo].[FK_tMannschafttTeilnehmer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tTeilnehmerSet] DROP CONSTRAINT [FK_tMannschafttTeilnehmer];
GO
IF OBJECT_ID(N'[dbo].[FK_tBahntLauf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tLaufSet] DROP CONSTRAINT [FK_tBahntLauf];
GO
IF OBJECT_ID(N'[dbo].[FK_tTyptLauf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tLaufSet] DROP CONSTRAINT [FK_tTyptLauf];
GO
IF OBJECT_ID(N'[dbo].[FK_tMannschaftZOT_Bewerb_Mannschaft]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tTeilnehmendeMannschaftSet] DROP CONSTRAINT [FK_tMannschaftZOT_Bewerb_Mannschaft];
GO
IF OBJECT_ID(N'[dbo].[FK_ZOT_Bewerb_MannschafttLauf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tLaufSet] DROP CONSTRAINT [FK_ZOT_Bewerb_MannschafttLauf];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tBewerbSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tBewerbSet];
GO
IF OBJECT_ID(N'[dbo].[tMannschaftSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tMannschaftSet];
GO
IF OBJECT_ID(N'[dbo].[tTeilnehmendeMannschaftSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tTeilnehmendeMannschaftSet];
GO
IF OBJECT_ID(N'[dbo].[tBahnSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tBahnSet];
GO
IF OBJECT_ID(N'[dbo].[tTypSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tTypSet];
GO
IF OBJECT_ID(N'[dbo].[tTeilnehmerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tTeilnehmerSet];
GO
IF OBJECT_ID(N'[dbo].[tLaufSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tLaufSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tBewerbSet'
CREATE TABLE [dbo].[tBewerbSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Datum] datetime  NOT NULL
);
GO

-- Creating table 'tMannschaftSet'
CREATE TABLE [dbo].[tMannschaftSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tTeilnehmendeMannschaftSet'
CREATE TABLE [dbo].[tTeilnehmendeMannschaftSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Startnummer] nvarchar(max)  NOT NULL,
    [Platzierung] int  NOT NULL,
    [tBewerb_Id] int  NOT NULL,
    [tMannschaft_Id] int  NOT NULL
);
GO

-- Creating table 'tBahnSet'
CREATE TABLE [dbo].[tBahnSet] (
    [Nummer] int  NOT NULL,
    [Bezeichnung] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tTypSet'
CREATE TABLE [dbo].[tTypSet] (
    [Kuerzel] nvarchar(max)  NOT NULL,
    [Bezeichnung] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tTeilnehmerSet'
CREATE TABLE [dbo].[tTeilnehmerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Vorname] nvarchar(max)  NOT NULL,
    [Nachname] nvarchar(max)  NOT NULL,
    [tMannschaft_Id] int  NOT NULL
);
GO

-- Creating table 'tLaufSet'
CREATE TABLE [dbo].[tLaufSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nettozeit] datetime  NOT NULL,
    [Strafsekunden] datetime  NOT NULL,
    [tBahn_Nummer] int  NOT NULL,
    [tTyp_Kuerzel] nvarchar(max)  NOT NULL,
    [ZOT_Bewerb_Mannschaft_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'tBewerbSet'
ALTER TABLE [dbo].[tBewerbSet]
ADD CONSTRAINT [PK_tBewerbSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tMannschaftSet'
ALTER TABLE [dbo].[tMannschaftSet]
ADD CONSTRAINT [PK_tMannschaftSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tTeilnehmendeMannschaftSet'
ALTER TABLE [dbo].[tTeilnehmendeMannschaftSet]
ADD CONSTRAINT [PK_tTeilnehmendeMannschaftSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Nummer] in table 'tBahnSet'
ALTER TABLE [dbo].[tBahnSet]
ADD CONSTRAINT [PK_tBahnSet]
    PRIMARY KEY CLUSTERED ([Nummer] ASC);
GO

-- Creating primary key on [Kuerzel] in table 'tTypSet'
ALTER TABLE [dbo].[tTypSet]
ADD CONSTRAINT [PK_tTypSet]
    PRIMARY KEY CLUSTERED ([Kuerzel] ASC);
GO

-- Creating primary key on [Id] in table 'tTeilnehmerSet'
ALTER TABLE [dbo].[tTeilnehmerSet]
ADD CONSTRAINT [PK_tTeilnehmerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tLaufSet'
ALTER TABLE [dbo].[tLaufSet]
ADD CONSTRAINT [PK_tLaufSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [tBewerb_Id] in table 'tTeilnehmendeMannschaftSet'
ALTER TABLE [dbo].[tTeilnehmendeMannschaftSet]
ADD CONSTRAINT [FK_tBewerbZOT_Bewerb_Mannschaft]
    FOREIGN KEY ([tBewerb_Id])
    REFERENCES [dbo].[tBewerbSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tBewerbZOT_Bewerb_Mannschaft'
CREATE INDEX [IX_FK_tBewerbZOT_Bewerb_Mannschaft]
ON [dbo].[tTeilnehmendeMannschaftSet]
    ([tBewerb_Id]);
GO

-- Creating foreign key on [tMannschaft_Id] in table 'tTeilnehmerSet'
ALTER TABLE [dbo].[tTeilnehmerSet]
ADD CONSTRAINT [FK_tMannschafttTeilnehmer]
    FOREIGN KEY ([tMannschaft_Id])
    REFERENCES [dbo].[tMannschaftSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tMannschafttTeilnehmer'
CREATE INDEX [IX_FK_tMannschafttTeilnehmer]
ON [dbo].[tTeilnehmerSet]
    ([tMannschaft_Id]);
GO

-- Creating foreign key on [tBahn_Nummer] in table 'tLaufSet'
ALTER TABLE [dbo].[tLaufSet]
ADD CONSTRAINT [FK_tBahntLauf]
    FOREIGN KEY ([tBahn_Nummer])
    REFERENCES [dbo].[tBahnSet]
        ([Nummer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tBahntLauf'
CREATE INDEX [IX_FK_tBahntLauf]
ON [dbo].[tLaufSet]
    ([tBahn_Nummer]);
GO

-- Creating foreign key on [tTyp_Kuerzel] in table 'tLaufSet'
ALTER TABLE [dbo].[tLaufSet]
ADD CONSTRAINT [FK_tTyptLauf]
    FOREIGN KEY ([tTyp_Kuerzel])
    REFERENCES [dbo].[tTypSet]
        ([Kuerzel])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tTyptLauf'
CREATE INDEX [IX_FK_tTyptLauf]
ON [dbo].[tLaufSet]
    ([tTyp_Kuerzel]);
GO

-- Creating foreign key on [tMannschaft_Id] in table 'tTeilnehmendeMannschaftSet'
ALTER TABLE [dbo].[tTeilnehmendeMannschaftSet]
ADD CONSTRAINT [FK_tMannschaftZOT_Bewerb_Mannschaft]
    FOREIGN KEY ([tMannschaft_Id])
    REFERENCES [dbo].[tMannschaftSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tMannschaftZOT_Bewerb_Mannschaft'
CREATE INDEX [IX_FK_tMannschaftZOT_Bewerb_Mannschaft]
ON [dbo].[tTeilnehmendeMannschaftSet]
    ([tMannschaft_Id]);
GO

-- Creating foreign key on [ZOT_Bewerb_Mannschaft_Id] in table 'tLaufSet'
ALTER TABLE [dbo].[tLaufSet]
ADD CONSTRAINT [FK_ZOT_Bewerb_MannschafttLauf]
    FOREIGN KEY ([ZOT_Bewerb_Mannschaft_Id])
    REFERENCES [dbo].[tTeilnehmendeMannschaftSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZOT_Bewerb_MannschafttLauf'
CREATE INDEX [IX_FK_ZOT_Bewerb_MannschafttLauf]
ON [dbo].[tLaufSet]
    ([ZOT_Bewerb_Mannschaft_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------