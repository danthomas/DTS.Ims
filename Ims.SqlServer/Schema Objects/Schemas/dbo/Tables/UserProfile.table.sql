CREATE TABLE [dbo].[UserProfile]
(
  [UserId] INT NOT NULL IDENTITY (1, 1)
, [CompanyId] SMALLINT NOT NULL
, [UserName] NVARCHAR(30) NOT NULL
, [EmailAddress] NVARCHAR(255) NOT NULL
, [FirstName] NVARCHAR(255) NOT NULL
, [LastName] NVARCHAR(255) NOT NULL
, [MemorableWord] NVARCHAR(50) NULL
, [MemorableWordIndices] NVARCHAR(11) NULL
, [ActiveStatus] BIT NOT NULL
, [IsConfirmed] BIT NOT NULL
, [IsWindowsUser] BIT NOT NULL
, [LastModified] DATETIME NOT NULL
, CONSTRAINT PK_UserProfile PRIMARY KEY CLUSTERED ( [UserId] )
, CONSTRAINT FK_UserProfile_CompanyId FOREIGN KEY ( CompanyId ) REFERENCES companies.Company ( CompanyId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_UserProfile_UserName ON [dbo].[UserProfile]
(
	[UserName] ASC
)
INCLUDE ([EmailAddress], [FirstName], [LastName], [ActiveStatus], [LastModified])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]