CREATE PROCEDURE [companies].[Account_DeleteMany]
(
@Ids VARBINARY(MAX)
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

DELETE  x
FROM    [companies].[Account] x
JOIN    [dbo].[ConvertBinaryToSmallInt](@Ids) ids on [x].[AccountId] = [ids].[Value]
