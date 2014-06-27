using System;

namespace Ims.Domain
{
    public class CompanyType
    {
        public CompanyType(byte companyTypeId, string companyTypeCode, string companyTypeName, bool canSeeAllData)
        {
            CompanyTypeId = companyTypeId;
            CompanyTypeCode = companyTypeCode;
            CompanyTypeName = companyTypeName;
            CanSeeAllData = canSeeAllData;
        }
    
        public byte CompanyTypeId { get; set; }
        public string CompanyTypeCode { get; set; }
        public string CompanyTypeName { get; set; }
        public bool CanSeeAllData { get; set; }
    }
}