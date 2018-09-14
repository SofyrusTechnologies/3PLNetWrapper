using Newtonsoft.Json;

namespace _3PL.Net.Model
{

    public class Order
    {
        public Customeridentifier CustomerIdentifier { get; set; }
        public Facilityidentifier FacilityIdentifier { get; set; }
        public string ReferenceNum { get; set; }
        public string BillingCode { get; set; }
        public Routinginfo RoutingInfo { get; set; }
        public Shipto ShipTo { get; set; }
        [JsonProperty("_embedded")]
        public OrderItems Items { get; set; }
    }

    public class Customeridentifier
    {
        public string Id { get; set; }
    }

    public class Facilityidentifier
    {
        public string Id { get; set; }
    }

    public class Routinginfo
    {
        public string Carrier { get; set; }
        public string Mode { get; set; }
        public string Account { get; set; }
        public string ShipPointZip { get; set; }
    }

    public class Shipto
    {
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
    }

    public class OrderItems
    {
        [JsonProperty("http://api.3plCentral.com/rels/orders/item")]
        public HttpApi3PlcentralComRelsOrdersItem[] Httpapi3plCentralcomrelsordersitem { get; set; }
    }

    public class HttpApi3PlcentralComRelsOrdersItem
    {
        public Itemidentifier ItemIdentifier { get; set; }
        public float Qty { get; set; }
    }

    public class Itemidentifier
    {
        public string Sku { get; set; }
    }

}
