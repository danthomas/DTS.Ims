CREATE TABLE [core].[ProductType]
(
  [ProductTypeId] TINYINT NOT NULL
, [ProductTypeCode] VARCHAR(50) NOT NULL
, [ProductTypeName] VARCHAR(100) NOT NULL
, CONSTRAINT PK_ProductType PRIMARY KEY CLUSTERED ( [ProductTypeId] )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_ProductType_ProductTypeCode ON [core].[ProductType]
(
	[ProductTypeCode] ASC
)
INCLUDE ([ProductTypeName])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_ProductType_ProductTypeName ON [core].[ProductType]
(
	[ProductTypeName] ASC
)
INCLUDE ([ProductTypeCode])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]