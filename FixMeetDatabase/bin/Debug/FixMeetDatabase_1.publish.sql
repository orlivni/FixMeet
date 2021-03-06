﻿/*
Deployment script for FixMeetDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "FixMeetDatabase"
:setvar DefaultFilePrefix "FixMeetDatabase"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The column [dbo].[Supplier].[Address] is being dropped, data loss could occur.

The column [dbo].[Supplier].[Category] is being dropped, data loss could occur.

The column [dbo].[Supplier].[Password] is being dropped, data loss could occur.
*/

IF EXISTS (select top 1 1 from [dbo].[Supplier])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Dropping unnamed constraint on [dbo].[Supplier]...';


GO
ALTER TABLE [dbo].[Supplier] DROP CONSTRAINT [FK__Supplier__Catego__145C0A3F];


GO
PRINT N'Dropping unnamed constraint on [dbo].[Supplier]...';


GO
ALTER TABLE [dbo].[Supplier] DROP CONSTRAINT [FK__Supplier__Addres__15502E78];


GO
PRINT N'Altering [dbo].[Supplier]...';


GO
ALTER TABLE [dbo].[Supplier] DROP COLUMN [Address], COLUMN [Category], COLUMN [Password];


GO
PRINT N'Update complete.';


GO
