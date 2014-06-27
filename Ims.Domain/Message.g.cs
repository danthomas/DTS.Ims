using System;

namespace Ims.Domain
{
    public class Message
    {
        public Message(int messageId, byte messageTypeId, short fromCompanyId, short toCompanyId, string title, string body, DateTime sent, int? requestId)
        {
            MessageId = messageId;
            MessageTypeId = messageTypeId;
            FromCompanyId = fromCompanyId;
            ToCompanyId = toCompanyId;
            Title = title;
            Body = body;
            Sent = sent;
            RequestId = requestId;
        }
    
        public int MessageId { get; set; }
        public byte MessageTypeId { get; set; }
        public short FromCompanyId { get; set; }
        public short ToCompanyId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Sent { get; set; }
        public int? RequestId { get; set; }
    }
}