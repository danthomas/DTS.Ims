CREATE TRIGGER [core].[ProductType_DeleteTrigger] ON [core].[ProductType]
FOR DELETE
AS
BEGIN
    RAISERROR('Cannot delete from table ProductType.', 16, 1);
END