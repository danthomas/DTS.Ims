using System;

namespace Ims.Domain
{
    public class Warrant
    {
        public Warrant(int warrantId, string warrantNumber, short storageCompanyId, short storeId, short locationId, byte contractId, byte contractUnitId, DateTime dateIssued, decimal netSize, decimal grossSize, byte unitMeasureId, short? assignedToCompanyId, short? accountId)
        {
            WarrantId = warrantId;
            WarrantNumber = warrantNumber;
            StorageCompanyId = storageCompanyId;
            StoreId = storeId;
            LocationId = locationId;
            ContractId = contractId;
            ContractUnitId = contractUnitId;
            DateIssued = dateIssued;
            NetSize = netSize;
            GrossSize = grossSize;
            UnitMeasureId = unitMeasureId;
            AssignedToCompanyId = assignedToCompanyId;
            AccountId = accountId;
        }
    
        public int WarrantId { get; set; }
        public string WarrantNumber { get; set; }
        public short StorageCompanyId { get; set; }
        public short StoreId { get; set; }
        public short LocationId { get; set; }
        public byte ContractId { get; set; }
        public byte ContractUnitId { get; set; }
        public DateTime DateIssued { get; set; }
        public decimal NetSize { get; set; }
        public decimal GrossSize { get; set; }
        public byte UnitMeasureId { get; set; }
        public short? AssignedToCompanyId { get; set; }
        public short? AccountId { get; set; }
    }
}