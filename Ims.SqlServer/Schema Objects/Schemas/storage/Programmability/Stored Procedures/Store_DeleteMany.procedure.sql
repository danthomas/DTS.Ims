CREATE PROCEDURE [storage].[Store_DeleteMany]
(
@Ids VARBINARY(MAX)
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

DELETE  x
FROM    [storage].[Store] x
JOIN    [dbo].[ConvertBinaryToSmallInt](@Ids) ids on [x].[StoreId] = [ids].[Value]
