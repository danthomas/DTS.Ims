CREATE TABLE [core].[Contract]
(
  [ContractId] TINYINT NOT NULL
, [ContractCode] VARCHAR(20) NOT NULL
, [ContractName] VARCHAR(100) NOT NULL
, [ExchangeCompanyId] SMALLINT NOT NULL
, [ProductId] TINYINT NOT NULL
, [IsActive] BIT NOT NULL
, CONSTRAINT PK_Contract PRIMARY KEY CLUSTERED ( [ContractId] )
, CONSTRAINT FK_Contract_ExchangeCompanyId FOREIGN KEY ( ExchangeCompanyId ) REFERENCES companies.Company ( CompanyId )
, CONSTRAINT FK_Contract_ProductId FOREIGN KEY ( ProductId ) REFERENCES core.Product ( ProductId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Contract_ContractCode ON [core].[Contract]
(
	[ContractCode] ASC
)
INCLUDE ([ContractName], [ExchangeCompanyId], [ProductId], [IsActive])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Contract_ContractName ON [core].[Contract]
(
	[ContractName] ASC
)
INCLUDE ([ContractCode], [ExchangeCompanyId], [ProductId], [IsActive])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]