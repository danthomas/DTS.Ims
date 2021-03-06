CREATE TABLE [messaging].[MessageType]
(
  [MessageTypeId] TINYINT NOT NULL
, [MessageTypeCode] VARCHAR(50) NOT NULL
, [MessageTypeName] VARCHAR(100) NOT NULL
, CONSTRAINT PK_MessageType PRIMARY KEY CLUSTERED ( [MessageTypeId] )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_MessageType_MessageTypeCode ON [messaging].[MessageType]
(
	[MessageTypeCode] ASC
)
INCLUDE ([MessageTypeName])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_MessageType_MessageTypeName ON [messaging].[MessageType]
(
	[MessageTypeName] ASC
)
INCLUDE ([MessageTypeCode])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]