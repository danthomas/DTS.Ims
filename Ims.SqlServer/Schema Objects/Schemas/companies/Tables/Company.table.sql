CREATE TABLE [companies].[Company]
(
  [CompanyId] SMALLINT NOT NULL IDENTITY (1, 1)
, [CompanyCode] VARCHAR(5) NOT NULL
, [CompanyName] VARCHAR(100) NOT NULL
, [CompanyTypeId] TINYINT NOT NULL
, [Address] VARCHAR(250) NOT NULL
, [PostCode] VARCHAR(10) NOT NULL
, [Telephone] VARCHAR(20) NOT NULL
, [IsActive] BIT NOT NULL
, [LastModified] DATETIME2(0) NOT NULL
, CONSTRAINT PK_Company PRIMARY KEY CLUSTERED ( [CompanyId] )
, CONSTRAINT FK_Company_CompanyTypeId FOREIGN KEY ( CompanyTypeId ) REFERENCES companies.CompanyType ( CompanyTypeId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Company_CompanyName_CompanyTypeId ON [companies].[Company]
(
	[CompanyName] ASC, [CompanyTypeId] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Company_CompanyCode_CompanyTypeId ON [companies].[Company]
(
	[CompanyCode] ASC, [CompanyTypeId] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]