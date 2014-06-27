CREATE TABLE [storage].[StoreProduct]
(
  [StoreId] SMALLINT NOT NULL
, [ProductId] TINYINT NOT NULL
, CONSTRAINT PK_StoreProduct PRIMARY KEY CLUSTERED ( [StoreId], [ProductId] )
, CONSTRAINT FK_StoreProduct_StoreId FOREIGN KEY ( StoreId ) REFERENCES storage.Store ( StoreId )
, CONSTRAINT FK_StoreProduct_ProductId FOREIGN KEY ( ProductId ) REFERENCES core.Product ( ProductId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_StoreProduct_StoreId_ProductId ON [storage].[StoreProduct]
(
	[StoreId] ASC, [ProductId] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]