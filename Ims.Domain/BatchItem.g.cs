using System;

namespace Ims.Domain
{
    public class BatchItem
    {
        public BatchItem(int batchId, int itemId)
        {
            BatchId = batchId;
            ItemId = itemId;
        }
    
        public int BatchId { get; set; }
        public int ItemId { get; set; }
    }
}