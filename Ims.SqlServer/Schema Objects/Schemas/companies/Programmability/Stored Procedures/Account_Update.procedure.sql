CREATE PROCEDURE [companies].[Account_Update]
(
  @AccountId SMALLINT
, @AccountCode VARCHAR(20)
, @AccountName VARCHAR(100)
, @AccountTypeCode CHAR(1)
, @CompanyId SMALLINT
, @IsActive BIT
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

UPDATE      [companies].[Account]
SET         [AccountCode] = @AccountCode
          , [AccountName] = @AccountName
          , [AccountTypeCode] = @AccountTypeCode
          , [CompanyId] = @CompanyId
          , [IsActive] = @IsActive
WHERE       AccountId = @AccountId
