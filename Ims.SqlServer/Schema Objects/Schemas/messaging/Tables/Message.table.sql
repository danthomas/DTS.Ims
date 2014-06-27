CREATE TABLE [messaging].[Message]
(
  [MessageId] INT NOT NULL IDENTITY (1, 1)
, [MessageTypeId] TINYINT NOT NULL
, [FromCompanyId] SMALLINT NOT NULL
, [ToCompanyId] SMALLINT NOT NULL
, [Title] VARCHAR(100) NOT NULL
, [Body] VARCHAR(MAX) NOT NULL
, [Sent] DATETIME2(0) NOT NULL
, [RequestId] INT NULL
, CONSTRAINT PK_Message PRIMARY KEY CLUSTERED ( [MessageId] )
, CONSTRAINT FK_Message_MessageTypeId FOREIGN KEY ( MessageTypeId ) REFERENCES messaging.MessageType ( MessageTypeId )
, CONSTRAINT FK_Message_FromCompanyId FOREIGN KEY ( FromCompanyId ) REFERENCES companies.Company ( CompanyId )
, CONSTRAINT FK_Message_ToCompanyId FOREIGN KEY ( ToCompanyId ) REFERENCES companies.Company ( CompanyId )
)