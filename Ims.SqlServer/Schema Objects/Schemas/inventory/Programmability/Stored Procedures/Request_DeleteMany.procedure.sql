CREATE PROCEDURE [inventory].[Request_DeleteMany]
(
@Ids VARBINARY(MAX)
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

DELETE  x
FROM    [inventory].[Request] x
JOIN    [dbo].[ConvertBinaryToInt](@Ids) ids on [x].[RequestId] = [ids].[Value]
