CREATE TRIGGER [security].[Feature_UpdateTrigger] ON [security].[Feature]
FOR UPDATE
AS
BEGIN


    IF UPDATE(FeatureCode)
    BEGIN
        RAISERROR('Column FeatureCode is read only.', 16, 1);
    END

    IF UPDATE(FeatureName)
    BEGIN
        RAISERROR('Column FeatureName is read only.', 16, 1);
    END
END