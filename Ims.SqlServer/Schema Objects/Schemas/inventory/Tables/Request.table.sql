CREATE TABLE [inventory].[Request]
(
  [RequestId] INT NOT NULL IDENTITY (1, 1)
, [RequestTypeId] TINYINT NOT NULL
, [CreatedByCompanyId] SMALLINT NOT NULL
, [FromCompanyId] SMALLINT NOT NULL
, [ToCompanyId] SMALLINT NOT NULL
, [Total] SMALLINT NOT NULL
, [IncompleteCount] SMALLINT NOT NULL
, [AcceptedCount] SMALLINT NOT NULL
, [RejectedCount] SMALLINT NOT NULL
, [DateTimeCreated] DATETIME2(0) NOT NULL
, CONSTRAINT PK_Request PRIMARY KEY CLUSTERED ( [RequestId] )
, CONSTRAINT FK_Request_RequestTypeId FOREIGN KEY ( RequestTypeId ) REFERENCES inventory.RequestType ( RequestTypeId )
, CONSTRAINT FK_Request_CreatedByCompanyId FOREIGN KEY ( CreatedByCompanyId ) REFERENCES companies.Company ( CompanyId )
, CONSTRAINT FK_Request_FromCompanyId FOREIGN KEY ( FromCompanyId ) REFERENCES companies.Company ( CompanyId )
, CONSTRAINT FK_Request_ToCompanyId FOREIGN KEY ( ToCompanyId ) REFERENCES companies.Company ( CompanyId )
)