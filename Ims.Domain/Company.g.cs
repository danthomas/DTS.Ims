using System;

namespace Ims.Domain
{
    public class Company
    {
        public Company(short companyId, string companyCode, string companyName, byte companyTypeId, string address, string postCode, string telephone, bool isActive, DateTime lastModified)
        {
            CompanyId = companyId;
            CompanyCode = companyCode;
            CompanyName = companyName;
            CompanyTypeId = companyTypeId;
            Address = address;
            PostCode = postCode;
            Telephone = telephone;
            IsActive = isActive;
            LastModified = lastModified;
        }
    
        public short CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public byte CompanyTypeId { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastModified { get; set; }
    }
}