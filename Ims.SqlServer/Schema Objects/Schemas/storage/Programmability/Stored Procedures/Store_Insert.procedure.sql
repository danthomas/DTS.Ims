CREATE PROCEDURE [storage].[Store_Insert]
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

INSERT INTO [storage].[Store] ([StorageCompanyId], [StoreCode], [StoreName], [LocationId], [IsActive])
VALUES (@StorageCompanyId, @StoreCode, @StoreName, @LocationId, @IsActive)


SET @StoreId = SCOPE_IDENTITY()

SELECT @StoreId