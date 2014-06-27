CREATE TRIGGER [companies].[CompanyType_UpdateTrigger] ON [companies].[CompanyType]
FOR UPDATE
AS
BEGIN


    IF UPDATE(CompanyTypeCode)
    BEGIN
        RAISERROR('Column CompanyTypeCode is read only.', 16, 1);
    END

    IF UPDATE(CompanyTypeName)
    BEGIN
        RAISERROR('Column CompanyTypeName is read only.', 16, 1);
    END
END