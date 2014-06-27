using System;

namespace Ims.Domain
{
    public class Product
    {
        public Product(byte productId, string productCode, string productName, byte productTypeId, byte unitMeasureId, byte sizeMaxDp, bool autoIssueWarrants, bool isActive)
        {
            ProductId = productId;
            ProductCode = productCode;
            ProductName = productName;
            ProductTypeId = productTypeId;
            UnitMeasureId = unitMeasureId;
            SizeMaxDp = sizeMaxDp;
            AutoIssueWarrants = autoIssueWarrants;
            IsActive = isActive;
        }
    
        public byte ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public byte ProductTypeId { get; set; }
        public byte UnitMeasureId { get; set; }
        public byte SizeMaxDp { get; set; }
        public bool AutoIssueWarrants { get; set; }
        public bool IsActive { get; set; }
    }
}