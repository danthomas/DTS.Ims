CREATE TRIGGER [messaging].[MessageType_UpdateTrigger] ON [messaging].[MessageType]
FOR UPDATE
AS
BEGIN


    IF UPDATE(MessageTypeCode)
    BEGIN
        RAISERROR('Column MessageTypeCode is read only.', 16, 1);
    END

    IF UPDATE(MessageTypeName)
    BEGIN
        RAISERROR('Column MessageTypeName is read only.', 16, 1);
    END
END