CREATE TRIGGER [inventory].[RequestStatus_InsertTrigger] ON [inventory].[RequestStatus]
FOR INSERT
AS
BEGIN
    RAISERROR('Cannot insert into table RequestStatus.', 16, 1);
END