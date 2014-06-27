using System;

namespace Ims.Domain
{
    public class RoleFeature
    {
        public RoleFeature(short roleId, short featureId)
        {
            RoleId = roleId;
            FeatureId = featureId;
        }
    
        public short RoleId { get; set; }
        public short FeatureId { get; set; }
    }
}