CREATE PROCEDURE [companies].[Account_SelectManyByCompanyId]
(
  @CompanyId SMALLINT
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT  *
FROM    [companies].[Account] x
WHERE   x.CompanyId = @CompanyId

