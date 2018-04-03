using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace RestBasicProject.poco
{
    [DeserializeAs(Name = "oddballRootName")]
    public class Oddball
    {
        public string Sid { get; set; }

        public string FriendlyName { get; set; }

        [RestSharp.Deserializers.DeserializeAs(Name = "oddballPropertyName")]
        public string GoodPropertyName { get; set; }

        [RestSharp.Deserializers.DeserializeAs(Name = "oddballListName")]
        public System.Collections.Generic.List<string> ListWithGoodName { get; set; }
    }
}
