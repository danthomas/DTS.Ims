CREATE TRIGGER [inventory].[RequestType_InsertTrigger] ON [inventory].[RequestType]
FOR INSERT
AS
BEGIN
    RAISERROR('Cannot insert into table RequestType.', 16, 1);
END