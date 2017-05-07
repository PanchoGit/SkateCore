	USE SkateCore
	GO

	IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
					 WHERE TABLE_SCHEMA = 'app' 
	                 AND  TABLE_NAME = 'Skater'))
	BEGIN
		CREATE TABLE app.[Skater] (
		    [Id]     INT         IDENTITY (1, 1) NOT NULL,
		    [Name]   NVARCHAR(255) NULL,
		    [Brand]  NVARCHAR(255) NULL,
		    [Stance] NVARCHAR(100) NULL,
			[Created] [DATETIME] NULL CONSTRAINT [DF_Skater_Created] DEFAULT (GETUTCDATE()),
			[Modified] [DATETIME],
		    CONSTRAINT [PK_Skater] PRIMARY KEY CLUSTERED ([Id] ASC)
		);
	END

	IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
					 WHERE TABLE_SCHEMA = 'app' 
	                 AND  TABLE_NAME = 'Type'))
	BEGIN
		CREATE TABLE app.[Type] (
		    [Id]   INT         IDENTITY (1, 1) NOT NULL,
		    [Name] NVARCHAR(255) NULL,
			[Created] [DATETIME] NULL CONSTRAINT [DF_Type_Created] DEFAULT (GETUTCDATE()),
		    CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED ([Id] ASC)
		);
	END

	IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
					 WHERE TABLE_SCHEMA = 'app' 
	                 AND  TABLE_NAME = 'Location'))
	BEGIN
		CREATE TABLE app.[Location] (
		    [Id]   INT         IDENTITY (1, 1) NOT NULL,
		    [Name] NVARCHAR (255) NULL,
			[Created] [DATETIME] NULL CONSTRAINT [DF_Location_Created] DEFAULT (GETUTCDATE()),
		    CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([Id] ASC)
		);
	END

	IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
	                 WHERE TABLE_SCHEMA = 'app' 
	                 AND  TABLE_NAME = 'Event'))
	BEGIN
		CREATE TABLE app.[Event] (
		    [Id]         INT         IDENTITY (1, 1) NOT NULL,
		    [Name]       NVARCHAR (255) NULL,
		    [TypeId]     INT         NULL,
		    [LocationId] INT         NULL,
		    [Date]       DATE        NULL,
			[Created] [DATETIME] NULL CONSTRAINT [DF_Event_Created] DEFAULT (GETUTCDATE()),
		    CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED ([Id] ASC),
		    CONSTRAINT [FK_EventLocation] FOREIGN KEY ([LocationId]) REFERENCES app.[Location] ([Id]),
		    CONSTRAINT [FK_EventType] FOREIGN KEY ([TypeId]) REFERENCES app.[Type] ([Id])
		);
	END

	IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
	                 WHERE TABLE_SCHEMA = 'app' 
	                 AND  TABLE_NAME = 'Score'))
	BEGIN
		CREATE TABLE app.[Score] (
		    [Id]       INT  IDENTITY (1, 1) NOT NULL,
		    [SkaterId] INT  NOT NULL,
		    [EventId]  INT  NOT NULL,
		    [Date]     DATE NULL,
		    [Value]    INT  NULL,
		    [Position] INT  NULL,
			[Created] [DATETIME] NULL CONSTRAINT [DF_Score_Created] DEFAULT (GETUTCDATE()),
		    CONSTRAINT [PK_Score] PRIMARY KEY CLUSTERED ([Id] ASC),
		    CONSTRAINT [FK_ScoreEvent] FOREIGN KEY ([EventId]) REFERENCES app.[Event] ([Id]),
		    CONSTRAINT [FK_ScoreSkater] FOREIGN KEY ([SkaterId]) REFERENCES app.[Skater] ([Id])
		);
	END