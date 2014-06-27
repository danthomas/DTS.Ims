CREATE PROCEDURE [core].[Location_Update]
(
  @LocationId SMALLINT
, @LocationCode VARCHAR(20)
, @LocationName VARCHAR(100)
, @IsActive BIT
)
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

UPDATE      [core].[Location]
SET         [LocationCode] = @LocationCode
          , [LocationName] = @LocationName
          , [IsActive] = @IsActive
WHERE       LocationId = @LocationId
