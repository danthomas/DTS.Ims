using System;

namespace Ims.Domain
{
    public class Account
    {
        public Account(short accountId, string accountCode, string accountName, string accountTypeCode, short companyId, bool isActive)
        {
            AccountId = accountId;
            AccountCode = accountCode;
            AccountName = accountName;
            AccountTypeCode = accountTypeCode;
            CompanyId = companyId;
            IsActive = isActive;
        }
    
        public short AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string AccountTypeCode { get; set; }
        public short CompanyId { get; set; }
        public bool IsActive { get; set; }
    }
}