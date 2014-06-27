using System;

namespace Ims.Domain
{
    public class AccountType
    {
        public AccountType(string accountTypeCode, string accountTypeName, bool isActive)
        {
            AccountTypeCode = accountTypeCode;
            AccountTypeName = accountTypeName;
            IsActive = isActive;
        }
    
        public string AccountTypeCode { get; set; }
        public string AccountTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}