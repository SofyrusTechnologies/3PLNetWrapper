using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace _3PL.Net.Serializer
{
    internal class DefaultJsonSerializer : JsonSerializerSettings
    {
        public DefaultJsonSerializer()
        {
            NullValueHandling = NullValueHandling.Ignore;
            DefaultValueHandling = DefaultValueHandling.Ignore;
            ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
