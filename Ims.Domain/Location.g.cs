using System;

namespace Ims.Domain
{
    public class Location
    {
        public Location(short locationId, string locationCode, string locationName, bool isActive)
        {
            LocationId = locationId;
            LocationCode = locationCode;
            LocationName = locationName;
            IsActive = isActive;
        }
    
        public short LocationId { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public bool IsActive { get; set; }
    }
}