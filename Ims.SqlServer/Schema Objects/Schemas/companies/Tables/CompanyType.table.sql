CREATE TABLE [companies].[CompanyType]
(
  [CompanyTypeId] TINYINT NOT NULL
, [CompanyTypeCode] VARCHAR(50) NOT NULL
, [CompanyTypeName] VARCHAR(50) NOT NULL
, [CanSeeAllData] BIT NOT NULL
, CONSTRAINT PK_CompanyType PRIMARY KEY CLUSTERED ( [CompanyTypeId] )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_CompanyType_CompanyTypeName ON [companies].[CompanyType]
(
	[CompanyTypeName] ASC
)
INCLUDE ([CompanyTypeCode], [CanSeeAllData])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_CompanyType_CompanyTypeCode ON [companies].[CompanyType]
(
	[CompanyTypeCode] ASC
)
INCLUDE ([CompanyTypeName], [CanSeeAllData])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]