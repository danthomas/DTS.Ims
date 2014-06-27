CREATE TABLE [inventory].[WarrantMovement]
(
  [WarrantMovementId] INT NOT NULL IDENTITY (1, 1)
, [WarrantId] INT NOT NULL
, [AccountHolderCompanyId] SMALLINT NOT NULL
, [AccountId] SMALLINT NULL
, [MovementDateTimeUtc] DATETIME2(0) NOT NULL
, [MovedByUserId] INT NOT NULL
, [RequestId] INT NULL
, CONSTRAINT PK_WarrantMovement PRIMARY KEY CLUSTERED ( [WarrantMovementId] )
, CONSTRAINT FK_WarrantMovement_WarrantId FOREIGN KEY ( WarrantId ) REFERENCES inventory.Warrant ( WarrantId )
, CONSTRAINT FK_WarrantMovement_AccountHolderCompanyId FOREIGN KEY ( AccountHolderCompanyId ) REFERENCES companies.Company ( CompanyId )
, CONSTRAINT FK_WarrantMovement_AccountId FOREIGN KEY ( AccountId ) REFERENCES companies.Account ( AccountId )
)
GO
CREATE NONCLUSTERED INDEX IX_WarrantMovement_WarrantId_AccountHolderCompanyId_AccountId_MovementDateTimeUtc ON [inventory].[WarrantMovement]
(
	[WarrantId] ASC, [AccountHolderCompanyId] ASC, [AccountId] ASC, [MovementDateTimeUtc] ASC
)
INCLUDE ([MovedByUserId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]