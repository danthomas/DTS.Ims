CREATE TRIGGER [core].[Contract_UpdateTrigger] ON [core].[Contract]
FOR UPDATE
AS
BEGIN


    IF UPDATE(ContractCode)
    BEGIN
        RAISERROR('Column ContractCode is read only.', 16, 1);
    END

    IF UPDATE(ContractName)
    BEGIN
        RAISERROR('Column ContractName is read only.', 16, 1);
    END
END