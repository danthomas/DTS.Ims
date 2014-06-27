using System;

namespace Ims.Domain
{
    public class RequestType
    {
        public RequestType(byte requestTypeId, string requestTypeCode, string requestTypeName)
        {
            RequestTypeId = requestTypeId;
            RequestTypeCode = requestTypeCode;
            RequestTypeName = requestTypeName;
        }
    
        public byte RequestTypeId { get; set; }
        public string RequestTypeCode { get; set; }
        public string RequestTypeName { get; set; }
    }
}