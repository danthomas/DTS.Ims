CREATE TRIGGER [core].[Config_UpdateTrigger] ON [core].[Config]
FOR UPDATE
AS
BEGIN


    IF UPDATE(ConfigName)
    BEGIN
        RAISERROR('Column ConfigName is read only.', 16, 1);
    END
END