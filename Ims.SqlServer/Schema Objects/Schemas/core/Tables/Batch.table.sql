CREATE TABLE [core].[Batch]
(
  [BatchId] INT NOT NULL IDENTITY (1, 1)
, [GridId] TINYINT NOT NULL
, [UserId] INT NOT NULL
, [BatchName] VARCHAR(50) NOT NULL
, CONSTRAINT PK_Batch PRIMARY KEY CLUSTERED ( [BatchId] )
, CONSTRAINT FK_Batch_GridId FOREIGN KEY ( GridId ) REFERENCES core.Grid ( GridId )
, CONSTRAINT FK_Batch_UserId FOREIGN KEY ( UserId ) REFERENCES dbo.UserProfile ( UserId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Batch_GridId_UserId_BatchName ON [core].[Batch]
(
	[GridId] ASC, [UserId] ASC, [BatchName] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]