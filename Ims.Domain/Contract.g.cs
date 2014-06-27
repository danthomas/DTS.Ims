using System;

namespace Ims.Domain
{
    public class Contract
    {
        public Contract(byte contractId, string contractCode, string contractName, short exchangeCompanyId, byte productId, bool isActive)
        {
            ContractId = contractId;
            ContractCode = contractCode;
            ContractName = contractName;
            ExchangeCompanyId = exchangeCompanyId;
            ProductId = productId;
            IsActive = isActive;
        }
    
        public byte ContractId { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public short ExchangeCompanyId { get; set; }
        public byte ProductId { get; set; }
        public bool IsActive { get; set; }
    }
}