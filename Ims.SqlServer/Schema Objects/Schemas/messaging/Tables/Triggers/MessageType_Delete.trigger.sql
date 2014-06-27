CREATE TRIGGER [messaging].[MessageType_DeleteTrigger] ON [messaging].[MessageType]
FOR DELETE
AS
BEGIN
    RAISERROR('Cannot delete from table MessageType.', 16, 1);
END