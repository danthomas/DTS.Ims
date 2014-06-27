CREATE TABLE [core].[ContractUnit]
(
  [ContractUnitId] TINYINT NOT NULL
, [ContractId] TINYINT NOT NULL
, [ContractUnitCode] VARCHAR(10) NOT NULL
, [NetSize] DECIMAL(18, 6) NOT NULL
, [UnitMeasureId] TINYINT NOT NULL
, [TolerancePercentage] DECIMAL(5, 2) NOT NULL
, CONSTRAINT PK_ContractUnit PRIMARY KEY CLUSTERED ( [ContractUnitId] )
, CONSTRAINT FK_ContractUnit_ContractId FOREIGN KEY ( ContractId ) REFERENCES core.Contract ( ContractId )
, CONSTRAINT FK_ContractUnit_UnitMeasureId FOREIGN KEY ( UnitMeasureId ) REFERENCES core.UnitMeasure ( UnitMeasureId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_ContractUnit_ContractId_ContractUnitCode ON [core].[ContractUnit]
(
	[ContractId] ASC, [ContractUnitCode] ASC
)
INCLUDE ([NetSize], [UnitMeasureId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]