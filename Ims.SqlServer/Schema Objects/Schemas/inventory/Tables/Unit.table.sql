CREATE TABLE [inventory].[Unit]
(
  [UnitId] INT NOT NULL IDENTITY (1, 1)
, [UnitNumber] VARCHAR(30) NOT NULL
, [StoreId] SMALLINT NOT NULL
, [StorageCompanyId] SMALLINT NOT NULL
, [LocationId] SMALLINT NOT NULL
, [ProductId] TINYINT NOT NULL
, [DateStored] DATE NULL
, [NetSize] DECIMAL(18, 6) NULL
, [GrossSize] DECIMAL(18, 6) NULL
, [UnitMeasureId] TINYINT NULL
, [Owner] VARCHAR(50) NOT NULL
, [Reference1] VARCHAR(50) NOT NULL
, [Reference2] VARCHAR(50) NOT NULL
, [Reference3] VARCHAR(50) NOT NULL
, [Notes1] VARCHAR(1000) NOT NULL
, [Notes2] VARCHAR(1000) NOT NULL
, [Notes3] VARCHAR(1000) NOT NULL
, [WarrantId] INT NULL
, CONSTRAINT PK_Unit PRIMARY KEY CLUSTERED ( [UnitId] )
, CONSTRAINT FK_Unit_StoreId FOREIGN KEY ( StoreId ) REFERENCES storage.Store ( StoreId )
, CONSTRAINT FK_Unit_StorageCompanyId FOREIGN KEY ( StorageCompanyId ) REFERENCES companies.Company ( CompanyId )
, CONSTRAINT FK_Unit_LocationId FOREIGN KEY ( LocationId ) REFERENCES core.Location ( LocationId )
, CONSTRAINT FK_Unit_ProductId FOREIGN KEY ( ProductId ) REFERENCES core.Product ( ProductId )
, CONSTRAINT FK_Unit_UnitMeasureId FOREIGN KEY ( UnitMeasureId ) REFERENCES core.UnitMeasure ( UnitMeasureId )
, CONSTRAINT FK_Unit_WarrantId FOREIGN KEY ( WarrantId ) REFERENCES inventory.Warrant ( WarrantId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Unit_UnitNumber_StorageCompanyId_LocationId ON [inventory].[Unit]
(
	[UnitNumber] ASC, [StorageCompanyId] ASC, [LocationId] ASC
)
INCLUDE ([StoreId], [ProductId], [WarrantId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]