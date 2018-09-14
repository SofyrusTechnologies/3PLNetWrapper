using System;

namespace _3PL.Net.Results
{

    public class Rootobject
    {
        public ReadOnly readOnly { get; set; }
        public int itemId { get; set; }
        public string sku { get; set; }
        public string upc { get; set; }
        public string description { get; set; }
        public string description2 { get; set; }
        public string inventoryCategory { get; set; }
        public Options options { get; set; }
        public _Links _links { get; set; }
        public _Embedded _embedded { get; set; }
    }

    public class ReadOnly
    {
        public Customeridentifier customerIdentifier { get; set; }
        public int itemId { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime lastModifiedDate { get; set; }
        public bool deactivated { get; set; }
    }

    public class Customeridentifier
    {
        public string externalId { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Options
    {
        public Inventoryunit inventoryUnit { get; set; }
        public Packageunit packageUnit { get; set; }
        public Trackbys trackBys { get; set; }
        public Pallets pallets { get; set; }
        public Hazmat hazMat { get; set; }
        public Directedputaway directedPutAway { get; set; }
        public bool autoHoldOnReceive { get; set; }
    }

    public class Inventoryunit
    {
        public Unitidentifier unitIdentifier { get; set; }
        public int inventoryMethod { get; set; }
    }

    public class Unitidentifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Packageunit
    {
        public Imperial imperial { get; set; }
        public Metric metric { get; set; }
        public Unitidentifier1 unitIdentifier { get; set; }
        public float inventoryUnitsPerUnit { get; set; }
    }

    public class Imperial
    {
        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
    }

    public class Metric
    {
        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
    }

    public class Unitidentifier1
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Trackbys
    {
        public int trackLotNumber { get; set; }
        public int trackSerialNumber { get; set; }
        public int trackExpirationDate { get; set; }
        public float trackCost { get; set; }
        public int outboundMobileSerialization { get; set; }
    }

    public class Pallets
    {
    }

    public class Hazmat
    {
        public bool isHazMat { get; set; }
    }

    public class Directedputaway
    {
        public bool forceIntoPreferredLocation { get; set; }
        public bool allowMixedItemStorage { get; set; }
        public bool allowMixedLotStorage { get; set; }
    }

    public class _Links
    {
        public Self self { get; set; }
        public Edit edit { get; set; }
        public HttpApi3PlcentralComRelsCustomersItemactivate httpapi3plcentralcomrelscustomersitemactivate { get; set; }
        public HttpApi3PlcentralComRelsCustomersCustomer httpapi3plcentralcomrelscustomerscustomer { get; set; }
        public HttpApi3PlcentralComRelsCustomersItemrates httpapi3plcentralcomrelscustomersitemrates { get; set; }
        public HttpApi3PlcentralComRelsCustomersItemimage httpapi3plcentralcomrelscustomersitemimage { get; set; }
        public ItemLocation item { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Edit
    {
        public string href { get; set; }
    }

    public class HttpApi3PlcentralComRelsCustomersItemactivate
    {
        public string href { get; set; }
    }

    public class HttpApi3PlcentralComRelsCustomersCustomer
    {
        public string href { get; set; }
    }

    public class HttpApi3PlcentralComRelsCustomersItemrates
    {
        public string href { get; set; }
    }

    public class HttpApi3PlcentralComRelsCustomersItemimage
    {
        public string href { get; set; }
    }

    public class ItemLocation
    {
        public string href { get; set; }
    }

    public class _Embedded
    {
        public Item1[] item { get; set; }
    }

    public class Item1
    {
        public string qualifier { get; set; }
        public ItemLinks _links { get; set; }
    }

    public class ItemLinks
    {
        public Self1 self { get; set; }
        public HttpApi3PlcentralComRelsInventoryStocksummaries httpapi3plcentralcomrelsinventorystocksummaries { get; set; }
    }

    public class Self1
    {
        public object href { get; set; }
    }

    public class HttpApi3PlcentralComRelsInventoryStocksummaries
    {
        public string href { get; set; }
    }

}
