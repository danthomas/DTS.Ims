CREATE TRIGGER [core].[ProductType_UpdateTrigger] ON [core].[ProductType]
FOR UPDATE
AS
BEGIN


    IF UPDATE(ProductTypeCode)
    BEGIN
        RAISERROR('Column ProductTypeCode is read only.', 16, 1);
    END

    IF UPDATE(ProductTypeName)
    BEGIN
        RAISERROR('Column ProductTypeName is read only.', 16, 1);
    END
END