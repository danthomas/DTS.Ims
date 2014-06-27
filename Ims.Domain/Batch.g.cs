using System;

namespace Ims.Domain
{
    public class Batch
    {
        public Batch(int batchId, byte gridId, int userId, string batchName)
        {
            BatchId = batchId;
            GridId = gridId;
            UserId = userId;
            BatchName = batchName;
        }
    
        public int BatchId { get; set; }
        public byte GridId { get; set; }
        public int UserId { get; set; }
        public string BatchName { get; set; }
    }
}