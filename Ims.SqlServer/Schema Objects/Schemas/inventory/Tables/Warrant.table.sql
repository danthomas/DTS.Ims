CREATE TABLE [inventory].[Warrant]
(
  [WarrantId] INT NOT NULL IDENTITY (1, 1)
, [WarrantNumber] VARCHAR(30) NOT NULL
, [StorageCompanyId] SMALLINT NOT NULL
, [StoreId] SMALLINT NOT NULL
, [LocationId] SMALLINT NOT NULL
, [ContractId] TINYINT NOT NULL
, [ContractUnitId] TINYINT NOT NULL
, [DateIssued] DATE NOT NULL
, [NetSize] DECIMAL(18, 6) NOT NULL
, [GrossSize] DECIMAL(18, 6) NOT NULL
, [UnitMeasureId] TINYINT NOT NULL
, [AssignedToCompanyId] SMALLINT NULL
, [AccountId] SMALLINT NULL
, CONSTRAINT PK_Warrant PRIMARY KEY CLUSTERED ( [WarrantId] )
, CONSTRAINT FK_Warrant_StorageCompanyId FOREIGN KEY ( StorageCompanyId ) REFERENCES companies.Company ( CompanyId )
, CONSTRAINT FK_Warrant_StoreId FOREIGN KEY ( StoreId ) REFERENCES storage.Store ( StoreId )
, CONSTRAINT FK_Warrant_LocationId FOREIGN KEY ( LocationId ) REFERENCES core.Location ( LocationId )
, CONSTRAINT FK_Warrant_ContractId FOREIGN KEY ( ContractId ) REFERENCES core.Contract ( ContractId )
, CONSTRAINT FK_Warrant_ContractUnitId FOREIGN KEY ( ContractUnitId ) REFERENCES core.ContractUnit ( ContractUnitId )
, CONSTRAINT FK_Warrant_UnitMeasureId FOREIGN KEY ( UnitMeasureId ) REFERENCES core.UnitMeasure ( UnitMeasureId )
, CONSTRAINT FK_Warrant_AssignedToCompanyId FOREIGN KEY ( AssignedToCompanyId ) REFERENCES companies.Company ( CompanyId )
, CONSTRAINT FK_Warrant_AccountId FOREIGN KEY ( AccountId ) REFERENCES companies.Account ( AccountId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Warrant_WarrantNumber_StorageCompanyId_LocationId ON [inventory].[Warrant]
(
	[WarrantNumber] ASC, [StorageCompanyId] ASC, [LocationId] ASC
)
INCLUDE ([ContractId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_Warrant_AssignedToCompanyId_AccountId ON [inventory].[Warrant]
(
	[AssignedToCompanyId] ASC, [AccountId] ASC
)
INCLUDE ([WarrantNumber], [StorageCompanyId], [ContractId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]