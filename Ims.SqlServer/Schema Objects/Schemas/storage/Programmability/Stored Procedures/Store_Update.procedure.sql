CREATE PROCEDURE [storage].[Store_Update]
(
  @StoreId SMALLINT
, @StorageCompanyId SMALLINT
, @StoreCode NVARCHAR(50)
, @StoreName NVARCHAR(100)
, @LocationId SMALLINT
, @IsActive BIT
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

UPDATE      [storage].[Store]
SET         [StorageCompanyId] = @StorageCompanyId
          , [StoreCode] = @StoreCode
          , [StoreName] = @StoreName
          , [LocationId] = @LocationId
          , [IsActive] = @IsActive
WHERE       StoreId = @StoreId
