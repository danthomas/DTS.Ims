CREATE TRIGGER [core].[ProductType_InsertTrigger] ON [core].[ProductType]
FOR INSERT
AS
BEGIN
    RAISERROR('Cannot insert into table ProductType.', 16, 1);
END