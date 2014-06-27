CREATE TRIGGER [companies].[AccountType_UpdateTrigger] ON [companies].[AccountType]
FOR UPDATE
AS
BEGIN


    IF UPDATE(AccountTypeCode)
    BEGIN
        RAISERROR('Column AccountTypeCode is read only.', 16, 1);
    END

    IF UPDATE(AccountTypeName)
    BEGIN
        RAISERROR('Column AccountTypeName is read only.', 16, 1);
    END
END