CREATE TABLE [core].[BatchItem]
(
  [BatchId] INT NOT NULL
, [ItemId] INT NOT NULL
, CONSTRAINT PK_BatchItem PRIMARY KEY CLUSTERED ( [BatchId], [ItemId] )
, CONSTRAINT FK_BatchItem_BatchId FOREIGN KEY ( BatchId ) REFERENCES core.Batch ( BatchId )
)