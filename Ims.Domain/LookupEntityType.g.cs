using System;

namespace Ims.Domain
{
    public class LookupEntityType
    {
        public LookupEntityType(int lookupEntityTypeId, string lookupEntityTypeDesc, string lookupEntityTypeCode)
        {
            LookupEntityTypeId = lookupEntityTypeId;
            LookupEntityTypeDesc = lookupEntityTypeDesc;
            LookupEntityTypeCode = lookupEntityTypeCode;
        }
    
        public int LookupEntityTypeId { get; set; }
        public string LookupEntityTypeDesc { get; set; }
        public string LookupEntityTypeCode { get; set; }
    }
}