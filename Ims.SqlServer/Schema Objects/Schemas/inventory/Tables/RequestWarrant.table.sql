CREATE TABLE [inventory].[RequestWarrant]
(
  [RequestWarrantId] INT NOT NULL IDENTITY (1, 1)
, [RequestId] INT NOT NULL
, [WarrantId] INT NOT NULL
, [RequestStatusId] TINYINT NOT NULL
, [IsAccepted] BIT NULL
, CONSTRAINT PK_RequestWarrant PRIMARY KEY CLUSTERED ( [RequestWarrantId] )
, CONSTRAINT FK_RequestWarrant_RequestId FOREIGN KEY ( RequestId ) REFERENCES inventory.Request ( RequestId )
, CONSTRAINT FK_RequestWarrant_WarrantId FOREIGN KEY ( WarrantId ) REFERENCES inventory.Warrant ( WarrantId )
, CONSTRAINT FK_RequestWarrant_RequestStatusId FOREIGN KEY ( RequestStatusId ) REFERENCES inventory.RequestStatus ( RequestStatusId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_RequestWarrant_WarrantId ON [inventory].[RequestWarrant]
(
	[WarrantId] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]