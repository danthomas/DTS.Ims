CREATE PROCEDURE [companies].[Account_SelectByAccountId]
(
@AccountId SMALLINT
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT  *
FROM    [companies].[Account] x
WHERE   x.AccountId = @AccountId


