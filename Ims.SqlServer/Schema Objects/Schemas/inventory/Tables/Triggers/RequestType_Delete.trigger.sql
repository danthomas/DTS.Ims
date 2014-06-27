CREATE TRIGGER [inventory].[RequestType_DeleteTrigger] ON [inventory].[RequestType]
FOR DELETE
AS
BEGIN
    RAISERROR('Cannot delete from table RequestType.', 16, 1);
END