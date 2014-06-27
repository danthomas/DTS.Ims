CREATE PROCEDURE [core].[Location_DeleteMany]
(
@Ids VARBINARY(MAX)
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

DELETE  x
FROM    [core].[Location] x
JOIN    [dbo].[ConvertBinaryToSmallInt](@Ids) ids on [x].[LocationId] = [ids].[Value]
