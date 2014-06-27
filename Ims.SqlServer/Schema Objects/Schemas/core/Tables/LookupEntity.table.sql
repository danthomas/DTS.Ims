CREATE TABLE [core].[LookupEntity]
(
  [LookupEntityId] INT NOT NULL IDENTITY (1, 1)
, [LookupEntityTypeId] INT NOT NULL
, [LookupEntityDesc] NVARCHAR(50) NULL
, [LookupEntityCode] VARCHAR(10) NOT NULL
, [IsActive] BIT NOT NULL
, CONSTRAINT PK_LookupEntity PRIMARY KEY CLUSTERED ( [LookupEntityId] )
, CONSTRAINT FK_LookupEntity_LookupEntityTypeId FOREIGN KEY ( LookupEntityTypeId ) REFERENCES core.LookupEntityType ( LookupEntityTypeId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_LookupEntity_LookupEntityTypeId_LookupEntityCode ON [core].[LookupEntity]
(
	[LookupEntityTypeId] ASC, [LookupEntityCode] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]