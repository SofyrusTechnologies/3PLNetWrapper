using Newtonsoft.Json;
using System;

namespace _3PL.Net.Results
{

    public class OrderDetailResultType
    {
        public OrderReadonlyProperties readOnly { get; set; }
        public string referenceNum { get; set; }
        public string description { get; set; }
        public string poNum { get; set; }
        public string externalId { get; set; }
        public DateTime earliestShipDate { get; set; }
        public DateTime shipCancelDate { get; set; }
        public string notes { get; set; }
        public float numUnits1 { get; set; }
        public Unit1identifier unit1Identifier { get; set; }
        public float numUnits2 { get; set; }
        public Unit2identifier unit2Identifier { get; set; }
        public float totalWeight { get; set; }
        public float totalVolume { get; set; }
        public string billingCode { get; set; }
        public string asnNumber { get; set; }
        public float upsServiceOptionCharge { get; set; }
        public float upsTransportationCharge { get; set; }
        public bool addFreightToCod { get; set; }
        public bool upsIsResidential { get; set; }
        public Exportchannelidentifier exportChannelIdentifier { get; set; }
        public DateTime routePickupDate { get; set; }
        public string shippingNotes { get; set; }
        public string masterBillOfLadingId { get; set; }
        public string invoiceNumber { get; set; }
        public Fulfillinvinfo fulfillInvInfo { get; set; }
        public Routinginfo routingInfo { get; set; }
        public Billing billing { get; set; }
        public Shipto shipTo { get; set; }
        public Soldto soldTo { get; set; }
        public Billto billTo { get; set; }
        public Savedelement1[] savedElements { get; set; }
        [JsonProperty("_embedded")]
        public OrderItems Items { get; set; }
    }

    public class OrderReadonlyProperties
    {
        public int orderId { get; set; }
        public int asnCandidate { get; set; }
        public int routeCandidate { get; set; }
        public bool fullyAllocated { get; set; }
        public int importModuleId { get; set; }
        public string exportModuleIds { get; set; }
        public bool deferNotification { get; set; }
        public bool isClosed { get; set; }
        public DateTime processDate { get; set; }
        public DateTime pickDoneDate { get; set; }
        public DateTime pickTicketPrintDate { get; set; }
        public DateTime packDoneDate { get; set; }
        public bool labelsExported { get; set; }
        public DateTime invoiceExportedDate { get; set; }
        public DateTime invoiceDeliveredDate { get; set; }
        public int loadedState { get; set; }
        public DateTime loadOutDoneDate { get; set; }
        public DateTime reallocatedAfterPickTicketDate { get; set; }
        public bool routeSent { get; set; }
        public DateTime asnSentDate { get; set; }
        public bool asnSent { get; set; }
        public bool pkgsExported { get; set; }
        public Batchidentifier batchIdentifier { get; set; }
        public Package[] packages { get; set; }
        public Outboundserialnumber[] outboundSerialNumbers { get; set; }
        public int parcelLabelType { get; set; }
        public Customeridentifier customerIdentifier { get; set; }
        public Facilityidentifier facilityIdentifier { get; set; }
        public int warehouseTransactionSourceType { get; set; }
        public int transactionEntryType { get; set; }
        public Importchannelidentifier importChannelIdentifier { get; set; }
        public DateTime creationDate { get; set; }
        public Createdbyidentifier createdByIdentifier { get; set; }
        public DateTime lastModifiedDate { get; set; }
        public Lastmodifiedbyidentifier lastModifiedByIdentifier { get; set; }
        public int status { get; set; }
    }

    public class Batchidentifier
    {
        public Namekey nameKey { get; set; }
        public int id { get; set; }
    }

    public class Namekey
    {
        public Customeridentifier customerIdentifier { get; set; }
        public string name { get; set; }
    }

     

    public class Facilityidentifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Importchannelidentifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Createdbyidentifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Lastmodifiedbyidentifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Package
    {
        public int packageId { get; set; }
        public int packageTypeId { get; set; }
        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public float codAmount { get; set; }
        public float insuredAmount { get; set; }
        public string trackingNumber { get; set; }
        public string description { get; set; }
        public DateTime createDate { get; set; }
        public bool oversize { get; set; }
        public bool cod { get; set; }
        public int ucc128 { get; set; }
        public string label { get; set; }
        public Packagecontent[] packageContents { get; set; }
    }

    public class Packagecontent
    {
        public int packageContentId { get; set; }
        public int packageId { get; set; }
        public int orderItemId { get; set; }
        public int receiveItemId { get; set; }
        public int orderItemPickExceptionId { get; set; }
        public float qty { get; set; }
        public string lotNumber { get; set; }
        public string serialNumber { get; set; }
        public DateTime expirationDate { get; set; }
        public DateTime createDate { get; set; }
        public string[] serialNumbers { get; set; }
    }

    public class Outboundserialnumber
    {
        public Itemidentifier itemIdentifier { get; set; }
        public string qualifier { get; set; }
        public string[] serialNumbers { get; set; }
    }

   
    public class Unit1identifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Unit2identifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Exportchannelidentifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Fulfillinvinfo
    {
        public float fulfillInvShippingAndHandling { get; set; }
        public float fulfillInvTax { get; set; }
        public string fulfillInvDiscountCode { get; set; }
        public float fulfillInvDiscountAmount { get; set; }
        public string fulfillInvGiftMessage { get; set; }
    }

    public class Routinginfo
    {
        public bool isCod { get; set; }
        public bool isInsurance { get; set; }
        public bool requiresDeliveryConf { get; set; }
        public bool requiresReturnReceipt { get; set; }
        public string scacCode { get; set; }
        public string carrier { get; set; }
        public string mode { get; set; }
        public string account { get; set; }
        public string shipPointZip { get; set; }
        public Capacitytypeidentifier capacityTypeIdentifier { get; set; }
        public string loadNumber { get; set; }
        public string billOfLading { get; set; }
        public string trackingNumber { get; set; }
        public string trailerNumber { get; set; }
        public string sealNumber { get; set; }
        public string doorNumber { get; set; }
        public DateTime pickupDate { get; set; }
    }

    public class Capacitytypeidentifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Billing
    {
        public Billingcharge[] billingCharges { get; set; }
    }

    public class Billingcharge
    {
        public int chargeType { get; set; }
        public float subtotal { get; set; }
        public Detail[] details { get; set; }
    }

    public class Detail
    {
        public int warehouseTransactionPriceCalcId { get; set; }
        public float numUnits { get; set; }
        public string chargeLabel { get; set; }
        public string unitDescription { get; set; }
        public float chargePerUnit { get; set; }
        public string glAcctNum { get; set; }
        public string sku { get; set; }
        public string ptItem { get; set; }
        public string ptItemDescription { get; set; }
        public string ptArAcct { get; set; }
        public bool systemGenerated { get; set; }
    }

    public class Shipto
    {
        public int sameAs { get; set; }
        public int retailerId { get; set; }
        public bool isQuickLookup { get; set; }
        public int contactId { get; set; }
        public string companyName { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string phoneNumber { get; set; }
        public string fax { get; set; }
        public string emailAddress { get; set; }
        public string dept { get; set; }
        public string code { get; set; }
        public int addressStatus { get; set; }
    }

    public class Soldto
    {
        public int sameAs { get; set; }
        public int retailerId { get; set; }
        public bool isQuickLookup { get; set; }
        public int contactId { get; set; }
        public string companyName { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string phoneNumber { get; set; }
        public string fax { get; set; }
        public string emailAddress { get; set; }
        public string dept { get; set; }
        public string code { get; set; }
        public int addressStatus { get; set; }
    }

    public class Billto
    {
        public int sameAs { get; set; }
        public int retailerId { get; set; }
        public bool isQuickLookup { get; set; }
        public int contactId { get; set; }
        public string companyName { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string phoneNumber { get; set; }
        public string fax { get; set; }
        public string emailAddress { get; set; }
        public string dept { get; set; }
        public string code { get; set; }
        public int addressStatus { get; set; }
    }

    public class OrderItems
    {
        [JsonProperty("http://api.3plCentral.com/rels/orders/item")]
        public HttpApi3PlcentralComRelsOrdersItem[] httpapi3plCentralcomrelsordersitem { get; set; }
    }

    public class HttpApi3PlcentralComRelsOrdersItem
    {
        public Readonly1 readOnly { get; set; }
        public Itemidentifier1 itemIdentifier { get; set; }
        public string qualifier { get; set; }
        public string externalId { get; set; }
        public float qty { get; set; }
        public float secondaryQty { get; set; }
        public float orderQty { get; set; }
        public Orderunitidentifier orderUnitIdentifier { get; set; }
        public string lotNumber { get; set; }
        public string serialNumber { get; set; }
        public DateTime expirationDate { get; set; }
        public float weightImperial { get; set; }
        public float weightMetric { get; set; }
        public string notes { get; set; }
        public float fulfillInvSalePrice { get; set; }
        public float fulfillInvDiscountPct { get; set; }
        public float fulfillInvDiscountAmt { get; set; }
        public string fulfillInvNote { get; set; }
        public Savedelement[] savedElements { get; set; }
        public Proposedallocation[] proposedAllocations { get; set; }
        public Orderiteminpackage[] orderItemInPackages { get; set; }
    }

    public class Readonly1
    {
        public int orderItemId { get; set; }
        public bool fullyAllocated { get; set; }
        public Unitidentifier unitIdentifier { get; set; }
        public Secondaryunitidentifier secondaryUnitIdentifier { get; set; }
        public float estimatedQty { get; set; }
        public float estimatedSecondaryQty { get; set; }
        public bool isOrderQtySecondary { get; set; }
        public Allocation[] allocations { get; set; }
        public Pickexception[] pickExceptions { get; set; }
    }


    public class Secondaryunitidentifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Allocation
    {
        public int orderId { get; set; }
        public int orderItemId { get; set; }
        public int receiveItemId { get; set; }
        public float qty { get; set; }
        public float properlyPickedPrimary { get; set; }
        public float properlyPickedSecondary { get; set; }
        public bool loadedOut { get; set; }
    }

    public class Pickexception
    {
        public int orderId { get; set; }
        public int orderItemId { get; set; }
        public int orderItemPickExceptionId { get; set; }
        public float pickedPrimaryQty { get; set; }
        public float pickedSecondaryQty { get; set; }
        public string reason { get; set; }
        public int receiveItemId { get; set; }
        public int locationId { get; set; }
        public string lotNumber { get; set; }
        public string serialNumber { get; set; }
        public DateTime expirationDate { get; set; }
    }

    public class Itemidentifier1
    {
        public string sku { get; set; }
        public int id { get; set; }
    }

    public class Orderunitidentifier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

  

    public class Proposedallocation
    {
        public int receiveItemId { get; set; }
        public float qty { get; set; }
    }

    public class Orderiteminpackage
    {
        public int packageNumber { get; set; }
        public float quantity { get; set; }
    }

    public class Savedelement1
    {
        public string name { get; set; }
        public string value { get; set; }
    }

}
