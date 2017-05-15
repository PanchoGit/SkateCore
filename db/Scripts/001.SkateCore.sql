USE master
GO

IF (NOT EXISTS (SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'SkateCore' ))
BEGIN
     CREATE DATABASE SkateCore
END
GO

USE SkateCore
GO

-- SkateCore App

IF (NOT EXISTS (SELECT 1 FROM sys.syslogins where name = 'SkateCoreApp'))
BEGIN
     CREATE LOGIN SkateCoreApp WITH 
            PASSWORD = 'Autospawn!01',
            DEFAULT_DATABASE = SkateCore, 
            CHECK_EXPIRATION = OFF, 
            CHECK_POLICY = OFF;
END

IF (NOT EXISTS (SELECT 1 FROM SkateCore.sys.database_principals where name = 'SkateCoreApp' ))
BEGIN
     CREATE USER SkateCoreApp FOR LOGIN SkateCoreApp WITH DEFAULT_SCHEMA = app;
END

IF NOT EXISTS ( SELECT 1 FROM sys.schemas WHERE name = 'app')
BEGIN
     EXEC('CREATE SCHEMA app');
END

GRANT SELECT ON SCHEMA ::app TO SkateCoreApp
GRANT INSERT ON SCHEMA ::app TO SkateCoreApp
GRANT UPDATE ON SCHEMA ::app TO SkateCoreApp
GRANT DELETE ON SCHEMA ::app TO SkateCoreApp
