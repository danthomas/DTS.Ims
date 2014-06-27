using System;

namespace Ims.Domain
{
    public class RequestStatus
    {
        public RequestStatus(byte requestStatusId, string requestStatusCode, string requestStatusName, byte requestTypeId, bool? isAccepted)
        {
            RequestStatusId = requestStatusId;
            RequestStatusCode = requestStatusCode;
            RequestStatusName = requestStatusName;
            RequestTypeId = requestTypeId;
            IsAccepted = isAccepted;
        }
    
        public byte RequestStatusId { get; set; }
        public string RequestStatusCode { get; set; }
        public string RequestStatusName { get; set; }
        public byte RequestTypeId { get; set; }
        public bool? IsAccepted { get; set; }
    }
}