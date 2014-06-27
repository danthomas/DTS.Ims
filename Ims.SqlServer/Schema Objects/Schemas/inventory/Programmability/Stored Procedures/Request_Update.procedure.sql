CREATE PROCEDURE [inventory].[Request_Update]
(
  @RequestId INT
, @RequestTypeId TINYINT
, @CreatedByCompanyId SMALLINT
, @FromCompanyId SMALLINT
, @ToCompanyId SMALLINT
, @Total SMALLINT
, @IncompleteCount SMALLINT
, @AcceptedCount SMALLINT
, @RejectedCount SMALLINT
, @DateTimeCreated DATETIME2(0)
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

UPDATE      [inventory].[Request]
SET         [RequestTypeId] = @RequestTypeId
          , [CreatedByCompanyId] = @CreatedByCompanyId
          , [FromCompanyId] = @FromCompanyId
          , [ToCompanyId] = @ToCompanyId
          , [Total] = @Total
          , [IncompleteCount] = @IncompleteCount
          , [AcceptedCount] = @AcceptedCount
          , [RejectedCount] = @RejectedCount
          , [DateTimeCreated] = @DateTimeCreated
WHERE       RequestId = @RequestId
