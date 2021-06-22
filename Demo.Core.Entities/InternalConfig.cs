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
    public class InternalConfig
    {
        [DataMember]
        public string ListarItemsCommand { get; set; }

        private NameValueCollection Config { get; set; }

        public InternalConfig()
        {
            Config = (NameValueCollection)ConfigurationManager.GetSection("internalConfig");
            ListarItemsCommand = Config["ListarItemsCommand"];
        }
    }
}
