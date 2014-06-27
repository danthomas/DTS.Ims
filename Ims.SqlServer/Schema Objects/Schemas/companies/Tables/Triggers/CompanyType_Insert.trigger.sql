CREATE TRIGGER [companies].[CompanyType_InsertTrigger] ON [companies].[CompanyType]
FOR INSERT
AS
BEGIN
    RAISERROR('Cannot insert into table CompanyType.', 16, 1);
END