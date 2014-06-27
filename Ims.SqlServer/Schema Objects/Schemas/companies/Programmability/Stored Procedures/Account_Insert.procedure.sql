CREATE PROCEDURE [companies].[Account_Insert]
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

INSERT INTO [companies].[Account] ([AccountCode], [AccountName], [AccountTypeCode], [CompanyId], [IsActive])
VALUES (@AccountCode, @AccountName, @AccountTypeCode, @CompanyId, @IsActive)


SET @AccountId = SCOPE_IDENTITY()

SELECT @AccountId