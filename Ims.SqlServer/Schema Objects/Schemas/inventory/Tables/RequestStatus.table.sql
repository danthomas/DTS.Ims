CREATE TABLE [inventory].[RequestStatus]
(
  [RequestStatusId] TINYINT NOT NULL
, [RequestStatusCode] VARCHAR(20) NOT NULL
, [RequestStatusName] VARCHAR(30) NOT NULL
, [RequestTypeId] TINYINT NOT NULL
, [IsAccepted] BIT NULL
, CONSTRAINT PK_RequestStatus PRIMARY KEY CLUSTERED ( [RequestStatusId] )
, CONSTRAINT FK_RequestStatus_RequestTypeId FOREIGN KEY ( RequestTypeId ) REFERENCES inventory.RequestType ( RequestTypeId )
)
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_RequestStatus_RequestStatusCode ON [inventory].[RequestStatus]
(
	[RequestStatusCode] ASC
)
INCLUDE ([RequestStatusName])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX AK_RequestStatus_RequestStatusName ON [inventory].[RequestStatus]
(
	[RequestStatusName] ASC
)
INCLUDE ([RequestStatusCode])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]