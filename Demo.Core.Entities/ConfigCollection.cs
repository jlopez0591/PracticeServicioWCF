using System.Runtime.Serialization;

namespace Demo.Core.Entities
{
    [DataContract]
    public class ConfigCollection
    {
        [DataMember]
        public ExternalServiceConfig ExternalServiceConfig { get; set; }
        [DataMember]
        public InternalConfig InternalConfig { get; set; }

        public ConfigCollection()
        {
            ExternalServiceConfig = new ExternalServiceConfig();
            InternalConfig = new InternalConfig();
        }
    }
}
