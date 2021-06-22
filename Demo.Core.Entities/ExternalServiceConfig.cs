using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Entities
{
    [DataContract]
    public class ExternalServiceConfig
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Endpoint { get; set; }
        [DataMember]
        public int Port { get; set; }

        private static NameValueCollection Config { get; set; }

        public ExternalServiceConfig()
        {
            Config = (NameValueCollection) ConfigurationManager.GetSection("externalServiceConfig");
            Username = Config["Username"];
            Password = Config["Password"];
            Endpoint = Config["Endpoint"];
            Port = int.Parse(Config["Port"]);
        }

        public string GetDecryptedPassword() => GetDecryptedString(this.Password);

        private string GetDecryptedString(string text) => text;
    }
}
