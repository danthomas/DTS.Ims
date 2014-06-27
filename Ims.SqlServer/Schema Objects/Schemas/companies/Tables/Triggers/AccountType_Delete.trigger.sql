CREATE TRIGGER [companies].[AccountType_DeleteTrigger] ON [companies].[AccountType]
FOR DELETE
AS
BEGIN
    RAISERROR('Cannot delete from table AccountType.', 16, 1);
END