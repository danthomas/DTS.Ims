CREATE PROCEDURE [core].[Location_SelectByLocationId]
(
@LocationId SMALLINT
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT  *
FROM    [core].[Location] x
WHERE   x.LocationId = @LocationId


