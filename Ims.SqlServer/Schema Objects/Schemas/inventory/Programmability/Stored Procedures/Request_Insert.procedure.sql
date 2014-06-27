CREATE PROCEDURE [inventory].[Request_Insert]
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

INSERT INTO [inventory].[Request] ([RequestTypeId], [CreatedByCompanyId], [FromCompanyId], [ToCompanyId], [Total], [IncompleteCount], [AcceptedCount], [RejectedCount], [DateTimeCreated])
VALUES (@RequestTypeId, @CreatedByCompanyId, @FromCompanyId, @ToCompanyId, @Total, @IncompleteCount, @AcceptedCount, @RejectedCount, @DateTimeCreated)


SET @RequestId = SCOPE_IDENTITY()

SELECT @RequestId