CREATE PROCEDURE [core].[Location_Insert]
(
  @LocationId SMALLINT
, @LocationCode VARCHAR(20)
, @LocationName VARCHAR(100)
, @IsActive BIT
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

INSERT INTO [core].[Location] ([LocationCode], [LocationName], [IsActive])
VALUES (@LocationCode, @LocationName, @IsActive)


SET @LocationId = SCOPE_IDENTITY()

SELECT @LocationId