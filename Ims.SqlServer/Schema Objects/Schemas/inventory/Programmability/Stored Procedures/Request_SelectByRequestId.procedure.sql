CREATE PROCEDURE [inventory].[Request_SelectByRequestId]
(
@RequestId INT
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT  *
FROM    [inventory].[Request] x
WHERE   x.RequestId = @RequestId


