CREATE TRIGGER [companies].[CompanyType_DeleteTrigger] ON [companies].[CompanyType]
FOR DELETE
AS
BEGIN
    RAISERROR('Cannot delete from table CompanyType.', 16, 1);
END