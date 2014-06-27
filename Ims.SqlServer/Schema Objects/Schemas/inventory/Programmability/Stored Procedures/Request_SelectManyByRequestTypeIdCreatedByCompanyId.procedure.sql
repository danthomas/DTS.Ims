CREATE PROCEDURE [inventory].[Request_SelectManyByRequestTypeIdCreatedByCompanyId]
(
  @RequestTypeId TINYINT
, @CreatedByCompanyId SMALLINT
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT  *
FROM    [inventory].[Request] x
WHERE   x.RequestTypeId = @RequestTypeId
AND     x.CreatedByCompanyId = @CreatedByCompanyId

