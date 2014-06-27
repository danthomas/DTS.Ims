using System;

namespace Ims.Domain
{
    public class Feature
    {
        public Feature(short featureId, string featureCode, string featureName)
        {
            FeatureId = featureId;
            FeatureCode = featureCode;
            FeatureName = featureName;
        }
    
        public short FeatureId { get; set; }
        public string FeatureCode { get; set; }
        public string FeatureName { get; set; }
    }
}