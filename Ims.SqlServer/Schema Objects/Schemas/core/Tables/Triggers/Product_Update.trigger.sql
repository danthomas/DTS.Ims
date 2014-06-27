CREATE TRIGGER [core].[Product_UpdateTrigger] ON [core].[Product]
FOR UPDATE
AS
BEGIN


    IF UPDATE(ProductCode)
    BEGIN
        RAISERROR('Column ProductCode is read only.', 16, 1);
    END

    IF UPDATE(ProductName)
    BEGIN
        RAISERROR('Column ProductName is read only.', 16, 1);
    END
END