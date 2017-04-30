using System.Configuration;

namespace MPKNetworkManager.Configuration
{
    public class Command : ConfigurationElement
    {
        [ConfigurationProperty("value", IsKey = true, IsRequired = true)]
        public string value
        {
            get
            {
                return (string)base["value"];
            }
            set
            {
                base["value"] = value;
            }
        }
    }
}
