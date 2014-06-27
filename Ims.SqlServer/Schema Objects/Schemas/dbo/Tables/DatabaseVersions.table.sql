CREATE TABLE [dbo].[DatabaseVersions]
(
  [DatabaseVersionId] INT NOT NULL IDENTITY (1, 1)
, [VersionNumber] VARCHAR(20) NULL
, CONSTRAINT PK_DatabaseVersions PRIMARY KEY CLUSTERED ( [DatabaseVersionId] )
)