using System;

namespace Ims.Domain
{
    public class RequestWarrant
    {
        public RequestWarrant(int requestWarrantId, int requestId, int warrantId, byte requestStatusId, bool? isAccepted)
        {
            RequestWarrantId = requestWarrantId;
            RequestId = requestId;
            WarrantId = warrantId;
            RequestStatusId = requestStatusId;
            IsAccepted = isAccepted;
        }
    
        public int RequestWarrantId { get; set; }
        public int RequestId { get; set; }
        public int WarrantId { get; set; }
        public byte RequestStatusId { get; set; }
        public bool? IsAccepted { get; set; }
    }
}