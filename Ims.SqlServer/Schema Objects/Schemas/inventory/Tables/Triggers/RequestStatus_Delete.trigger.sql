CREATE TRIGGER [inventory].[RequestStatus_DeleteTrigger] ON [inventory].[RequestStatus]
FOR DELETE
AS
BEGIN
    RAISERROR('Cannot delete from table RequestStatus.', 16, 1);
END