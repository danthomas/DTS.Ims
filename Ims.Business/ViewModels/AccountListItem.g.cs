namespace Ims.Business.ViewModels
{
    public class AccountListItem
    {
        public AccountListItem()
        {
            
        }

        public AccountListItem(short accountId, string accountCode, string accountName, string accountTypeCode, string companyCode, bool isActive)
        {
            AccountId = accountId;
            AccountCode = accountCode;
            AccountName = accountName;
            AccountTypeCode = accountTypeCode;
            CompanyCode = companyCode;
            IsActive = isActive;
        }
    
        public short AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string AccountTypeCode { get; set; }
        public string CompanyCode { get; set; }
        public bool IsActive { get; set; }
    }
}