using System;

namespace Ims.Domain
{
    public class LookupEntity
    {
        public LookupEntity(int lookupEntityId, int lookupEntityTypeId, string lookupEntityDesc, string lookupEntityCode, bool isActive)
        {
            LookupEntityId = lookupEntityId;
            LookupEntityTypeId = lookupEntityTypeId;
            LookupEntityDesc = lookupEntityDesc;
            LookupEntityCode = lookupEntityCode;
            IsActive = isActive;
        }
    
        public int LookupEntityId { get; set; }
        public int LookupEntityTypeId { get; set; }
        public string LookupEntityDesc { get; set; }
        public string LookupEntityCode { get; set; }
        public bool IsActive { get; set; }
    }
}