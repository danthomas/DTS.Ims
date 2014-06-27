using System;

namespace Ims.Domain
{
    public class Request
    {
        public Request(int requestId, byte requestTypeId, short createdByCompanyId, short fromCompanyId, short toCompanyId, short total, short incompleteCount, short acceptedCount, short rejectedCount, DateTime dateTimeCreated)
        {
            RequestId = requestId;
            RequestTypeId = requestTypeId;
            CreatedByCompanyId = createdByCompanyId;
            FromCompanyId = fromCompanyId;
            ToCompanyId = toCompanyId;
            Total = total;
            IncompleteCount = incompleteCount;
            AcceptedCount = acceptedCount;
            RejectedCount = rejectedCount;
            DateTimeCreated = dateTimeCreated;
        }
    
        public int RequestId { get; set; }
        public byte RequestTypeId { get; set; }
        public short CreatedByCompanyId { get; set; }
        public short FromCompanyId { get; set; }
        public short ToCompanyId { get; set; }
        public short Total { get; set; }
        public short IncompleteCount { get; set; }
        public short AcceptedCount { get; set; }
        public short RejectedCount { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}