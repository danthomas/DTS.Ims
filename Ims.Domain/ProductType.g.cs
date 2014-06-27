using System;

namespace Ims.Domain
{
    public class ProductType
    {
        public ProductType(byte productTypeId, string productTypeCode, string productTypeName)
        {
            ProductTypeId = productTypeId;
            ProductTypeCode = productTypeCode;
            ProductTypeName = productTypeName;
        }
    
        public byte ProductTypeId { get; set; }
        public string ProductTypeCode { get; set; }
        public string ProductTypeName { get; set; }
    }
}