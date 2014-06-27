using System;

namespace Ims.Domain
{
    public class Config
    {
        public Config(int configId, string configName, string configValue, bool? isActive)
        {
            ConfigId = configId;
            ConfigName = configName;
            ConfigValue = configValue;
            IsActive = isActive;
        }
    
        public int ConfigId { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
        public bool? IsActive { get; set; }
    }
}