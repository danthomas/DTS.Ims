using System;

namespace Ims.Domain
{
    public class ContractUnit
    {
        public ContractUnit(byte contractUnitId, byte contractId, string contractUnitCode, decimal netSize, byte unitMeasureId, decimal tolerancePercentage)
        {
            ContractUnitId = contractUnitId;
            ContractId = contractId;
            ContractUnitCode = contractUnitCode;
            NetSize = netSize;
            UnitMeasureId = unitMeasureId;
            TolerancePercentage = tolerancePercentage;
        }
    
        public byte ContractUnitId { get; set; }
        public byte ContractId { get; set; }
        public string ContractUnitCode { get; set; }
        public decimal NetSize { get; set; }
        public byte UnitMeasureId { get; set; }
        public decimal TolerancePercentage { get; set; }
    }
}