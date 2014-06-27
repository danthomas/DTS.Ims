CREATE TABLE [companies].[Account]
(
  [AccountId] SMALLINT NOT NULL IDENTITY (1, 1)
, [AccountCode] VARCHAR(20) NOT NULL
, [AccountName] VARCHAR(100) NULL
, [AccountTypeCode] CHAR(1) NOT NULL
, [CompanyId] SMALLINT NOT NULL
, [IsActive] BIT NOT NULL
, CONSTRAINT PK_Account PRIMARY KEY CLUSTERED ( [AccountId] )
, CONSTRAINT FK_Account_AccountTypeCode FOREIGN KEY ( AccountTypeCode ) REFERENCES companies.AccountType ( AccountTypeCode )
, CONSTRAINT FK_Account_CompanyId FOREIGN KEY ( CompanyId ) REFERENCES companies.Company ( CompanyId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_Account_AccountCode_CompanyId ON [companies].[Account]
(
	[AccountCode] ASC, [CompanyId] ASC
)
INCLUDE ([AccountName], [AccountTypeCode], [IsActive])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]