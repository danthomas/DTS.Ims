CREATE TRIGGER [companies].[AccountType_InsertTrigger] ON [companies].[AccountType]
FOR INSERT
AS
BEGIN
    RAISERROR('Cannot insert into table AccountType.', 16, 1);
END