using System;

namespace Ims.Domain
{
    public class Address
    {
        public Address(short addressId, string address1, string address2, string address3, string address4, string postCode, string country, string telephone)
        {
            AddressId = addressId;
            Address1 = address1;
            Address2 = address2;
            Address3 = address3;
            Address4 = address4;
            PostCode = postCode;
            Country = country;
            Telephone = telephone;
        }
    
        public short AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
    }
}