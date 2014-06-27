using System;

namespace Ims.Domain
{
    public class Store
    {
        public Store(short storeId, short storageCompanyId, string storeCode, string storeName, short locationId, bool isActive)
        {
            StoreId = storeId;
            StorageCompanyId = storageCompanyId;
            StoreCode = storeCode;
            StoreName = storeName;
            LocationId = locationId;
            IsActive = isActive;
        }
    
        public short StoreId { get; set; }
        public short StorageCompanyId { get; set; }
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
        public short LocationId { get; set; }
        public bool IsActive { get; set; }
    }
}