using System;

namespace Ims.Domain
{
    public class MessageType
    {
        public MessageType(byte messageTypeId, string messageTypeCode, string messageTypeName)
        {
            MessageTypeId = messageTypeId;
            MessageTypeCode = messageTypeCode;
            MessageTypeName = messageTypeName;
        }
    
        public byte MessageTypeId { get; set; }
        public string MessageTypeCode { get; set; }
        public string MessageTypeName { get; set; }
    }
}