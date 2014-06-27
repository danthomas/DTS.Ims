CREATE TABLE [admin].[AppVersion]
(
  [AppVersionId] TINYINT NOT NULL IDENTITY (1, 1)
, [VersionNumber] VARCHAR(50) NOT NULL
, [ComponentCode] VARCHAR(50) NOT NULL
, [ComponentName] VARCHAR(200) NOT NULL
, [IsSolution] BIT NOT NULL
, [Notes] VARCHAR(MAX) NULL
, [ServerList] VARCHAR(MAX) NULL
, [CreateDateTimeUtc] SMALLDATETIME NOT NULL
, [CreateUserName] VARCHAR(100) NOT NULL
, [UpdateDateTimeUtc] SMALLDATETIME NULL
, [UpdateUserName] VARCHAR(100) NULL
, CONSTRAINT PK_AppVersion PRIMARY KEY CLUSTERED ( [AppVersionId] )
)