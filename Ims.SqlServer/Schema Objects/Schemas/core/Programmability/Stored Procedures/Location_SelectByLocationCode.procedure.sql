CREATE PROCEDURE [core].[Location_SelectByLocationCode]
(
@LocationCode VARCHAR(20)
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT  *
FROM    [core].[Location] x
WHERE   x.LocationCode = @LocationCode


