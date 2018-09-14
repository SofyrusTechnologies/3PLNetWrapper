using System;

namespace _3PL.Net.Results
{

    public class StockDetailsResultType
    {
        public int TotalResults { get; set; }
        public InventoryItems _embedded { get; set; }
    }

    public class InventoryItems
    {
        public StockItem[] item { get; set; }
    }

    public class StockItem
    {
        public Itemidentifier itemIdentifier { get; set; }
        public string description { get; set; }
        public string qualifier { get; set; }
        public float received { get; set; }
        public float available { get; set; }
        public float onHold { get; set; }
        public float vAvailable { get; set; }
        public float onHand { get; set; }
        public string lotNumber { get; set; }
        public string serialNumber { get; set; }
        public DateTime expirationDate { get; set; }
        public float cost { get; set; }
        public string supplierName { get; set; }
        public string locationName { get; set; }
        public string palletName { get; set; }
        public string unitOfMeasureName { get; set; }
        public int receiverId { get; set; }
        public DateTime receivedDate { get; set; }
        public string referenceNum { get; set; }
        public string poNum { get; set; }
        public string trailerNumber { get; set; }
        public Receiveiteminfo[] receiveItemInfos { get; set; }
    }

    public class Itemidentifier
    {
        public string sku { get; set; }
        public int id { get; set; }
    }

    public class Receiveiteminfo
    {
        public int receiveItemId { get; set; }
        public float received { get; set; }
        public float available { get; set; }
        public float onHold { get; set; }
        public float vAvailable { get; set; }
        public float onHand { get; set; }
        public DateTime receivedDate { get; set; }
        public Savedelement[] savedElements { get; set; }
    }

    public class Savedelement
    {
        public string name { get; set; }
        public string value { get; set; }
    }

}
