using Newtonsoft.Json;

namespace _3PL.Net.Results
{

    public class ItemCollectionResultType
    {
        public int TotalResults { get; set; }
        [JsonProperty("_links")]
        public Paging _links { get; set; }
        [JsonProperty("_embedded")]
        public ItemCollection _embedded { get; set; }
    }

    public class Paging
    {
        public Self self { get; set; }
        public Next next { get; set; }
        [JsonProperty("http://api.3plcentral.com/rels/customers/item")]
        public HttpApi3PlcentralComRelsCustomersItem httpapi3plcentralcomrelscustomersitem { get; set; }
    }


    public class Next
    {
        public string href { get; set; }
    }

    public class HttpApi3PlcentralComRelsCustomersItem
    {
        public string href { get; set; }
        public bool templated { get; set; }
    }

    public class ItemCollection
    {
        [JsonProperty("http://api.3plCentral.com/rels/customers/item")]
        public HttpApi3PlcentralComRelsCustomersItem1[] httpapi3plCentralcomrelscustomersitem { get; set; }
    }

    public class HttpApi3PlcentralComRelsCustomersItem1
    {
        public OrderReadonlyProperties readOnly { get; set; }
        public int itemId { get; set; }
        public string sku { get; set; }
        public string upc { get; set; }
        public string description { get; set; }
        public string description2 { get; set; }
        public string inventoryCategory { get; set; }
        public Options options { get; set; }
        public _Links1 _links { get; set; }
        public _Embedded1 _embedded { get; set; }
    }



    public class _Links1
    {
        public Self self { get; set; }
        public Edit edit { get; set; }
        public HttpApi3PlcentralComRelsCustomersItemactivate httpapi3plcentralcomrelscustomersitemactivate { get; set; }
        public HttpApi3PlcentralComRelsCustomersCustomer httpapi3plcentralcomrelscustomerscustomer { get; set; }
        public HttpApi3PlcentralComRelsCustomersItemrates httpapi3plcentralcomrelscustomersitemrates { get; set; }
        public HttpApi3PlcentralComRelsCustomersItemimage httpapi3plcentralcomrelscustomersitemimage { get; set; }
        public ItemSummaryLinks item { get; set; }
    }


    public class ItemSummaryLinks
    {
        [JsonProperty("http://api.3plcentral.com/rels/inventory/stocksummaries")]
        public string href { get; set; }
    }

    public class _Embedded1
    {
        public Item1[] item { get; set; }
    }
}
