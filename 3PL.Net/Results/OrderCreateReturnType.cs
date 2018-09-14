using Newtonsoft.Json;
using System;

namespace _3PL.Net.Results
{

    public class OrderCreateReturnType
    {
        public Readonly readOnly { get; set; }
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
        public OrderedItems Items { get; set; }
    }

    public class Readonly
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
   
    public class OrderedItems
    {
        public HttpApi3PlcentralComRelsOrdersItem[] httpapi3plCentralcomrelsordersitem { get; set; }
    }

}
