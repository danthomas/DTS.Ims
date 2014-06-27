using System;

namespace Ims.Domain
{
    public class Unit
    {
        public Unit(int unitId, string unitNumber, short storeId, short storageCompanyId, short locationId, byte productId, DateTime? dateStored, decimal? netSize, decimal? grossSize, byte? unitMeasureId, string owner, string reference1, string reference2, string reference3, string notes1, string notes2, string notes3, int? warrantId)
        {
            UnitId = unitId;
            UnitNumber = unitNumber;
            StoreId = storeId;
            StorageCompanyId = storageCompanyId;
            LocationId = locationId;
            ProductId = productId;
            DateStored = dateStored;
            NetSize = netSize;
            GrossSize = grossSize;
            UnitMeasureId = unitMeasureId;
            Owner = owner;
            Reference1 = reference1;
            Reference2 = reference2;
            Reference3 = reference3;
            Notes1 = notes1;
            Notes2 = notes2;
            Notes3 = notes3;
            WarrantId = warrantId;
        }
    
        public int UnitId { get; set; }
        public string UnitNumber { get; set; }
        public short StoreId { get; set; }
        public short StorageCompanyId { get; set; }
        public short LocationId { get; set; }
        public byte ProductId { get; set; }
        public DateTime? DateStored { get; set; }
        public decimal? NetSize { get; set; }
        public decimal? GrossSize { get; set; }
        public byte? UnitMeasureId { get; set; }
        public string Owner { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public string Notes1 { get; set; }
        public string Notes2 { get; set; }
        public string Notes3 { get; set; }
        public int? WarrantId { get; set; }
    }
}