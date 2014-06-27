CREATE TRIGGER [messaging].[MessageType_InsertTrigger] ON [messaging].[MessageType]
FOR INSERT
AS
BEGIN
    RAISERROR('Cannot insert into table MessageType.', 16, 1);
END