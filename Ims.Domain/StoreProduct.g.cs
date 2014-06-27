using System;

namespace Ims.Domain
{
    public class StoreProduct
    {
        public StoreProduct(short storeId, byte productId)
        {
            StoreId = storeId;
            ProductId = productId;
        }
    
        public short StoreId { get; set; }
        public byte ProductId { get; set; }
    }
}