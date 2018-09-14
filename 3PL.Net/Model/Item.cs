using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace _3PL.Net.Model
{

    public class Item
    {
        [JsonProperty("readOnly")]
        public Audit ReadOnly { get; set; }
        public int ItemId { get; set; }
        public string Sku { get; set; }
        public string Upc { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string InventoryCategory { get; set; }
        public Classificationidentifier ClassificationIdentifier { get; set; }
        public string Nmfc { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }
        public float Temperature { get; set; }
        public string AccountRef { get; set; }
        public string CountryOfManufacture { get; set; }
        public string HarmonizedCode { get; set; }
        public List<QualifierRenamer> QualifierRenamers { get; set; }
        public Kit Kit { get; set; }
        public Options Options { get; set; }
        [JsonProperty("_embedded")]
        public Embedded Embedded { get; set; }
    }

    public class Audit
    {
        public CustomerIdentifier CustomerIdentifier { get; set; }
        public int ItemId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool Deactivated { get; set; }
        public DateTime LastPriceChange { get; set; }
    }

    public class CustomerIdentifier
    {
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class Classificationidentifier
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class Kit
    {
        public string MaterialNotes { get; set; }
        public List<Component> Components { get; set; }
    }

    public class Component
    {
        public ItemIdentifier ItemIdentifier { get; set; }
        public string Qualifier { get; set; }
        public float Qty { get; set; }
        public string NonSkuMaterial { get; set; }
    }

    public class ItemIdentifier
    {
        public string Sku { get; set; }
        public int Id { get; set; }
    }

    public class Options
    {
        public Inventoryunit InventoryUnit { get; set; }
        public SecondaryUnit SecondaryUnit { get; set; }
        public PackageUnit PackageUnit { get; set; }
        public Trackbys TrackBys { get; set; }
        public Pallets Pallets { get; set; }
        public Hazmat HazMat { get; set; }
        public DirectedPutAway DirectedPutAway { get; set; }
        public int DaysBetweenCounts { get; set; }
        public bool AutoHoldOnReceive { get; set; }
    }

    public class Inventoryunit
    {
        public UnitIdentifier UnitIdentifier { get; set; }
        public float MinimumStock { get; set; }
        public float MaximumStock { get; set; }
        public float ReorderQuantity { get; set; }
        public int InventoryMethod { get; set; }
    }

    public class UnitIdentifier
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class SecondaryUnit
    {
        public bool InventoryAlso { get; set; }
        public UnitIdentifierPrimary UnitIdentifier { get; set; }
        public float InventoryUnitsPerUnit { get; set; }
    }

    public class UnitIdentifierPrimary
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class PackageUnit
    {
        public Imperial Imperial { get; set; }
        public Metric Metric { get; set; }
        public string Upc { get; set; }
        public UnitIdentifier UnitIdentifier { get; set; }
        public float InventoryUnitsPerUnit { get; set; }
    }

    public class Imperial : ImperialBase
    {
        public float NetWeight { get; set; }

    }

    public class Metric : MetricBase
    {
        public float NetWeight { get; set; }

    }
   
    public class Trackbys
    {
        public int TrackLotNumber { get; set; }
        public int TrackSerialNumber { get; set; }
        public int TrackExpirationDate { get; set; }
        public int TrackCost { get; set; }
        public int OutboundMobileSerialization { get; set; }
        public int AutoHoldExpirationDaysThreshold { get; set; }
    }

    public class Pallets
    {
        public TypeIdentifier TypeIdentifier { get; set; }
        public float Tie { get; set; }
        public float High { get; set; }
        public float qty { get; set; }
        public ImperialBase Imperial { get; set; }
        public MetricBase Metric { get; set; }
        public string Upc { get; set; }
    }

    public class TypeIdentifier
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class ImperialBase
    {
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
    }

    public class MetricBase
    {
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
    }

    public class Hazmat
    {
        public bool IsHazMat { get; set; }
        public string Id { get; set; }
        public string ShippingName { get; set; }
        public string HazardClass { get; set; }
        public string PackingGroup { get; set; }
        public string FlashPoint { get; set; }
        public string LabelCode { get; set; }
        public string Flag { get; set; }
    }

    public class DirectedPutAway
    {
        public string LocationZones { get; set; }
        public string PalletLocationZones { get; set; }
        public string OverAllocLocationZones { get; set; }
        public PreferredLocationIdentifier PreferredLocationIdentifier { get; set; }
        public bool ForceIntoPreferredLocation { get; set; }
        public bool AllowMixedItemStorage { get; set; }
        public bool AllowMixedLotStorage { get; set; }
        public int MixedExpirationDaysThreshold { get; set; }
    }

    public class PreferredLocationIdentifier
    {
        public NameKey NameKey { get; set; }
        public int Id { get; set; }
    }

    public class NameKey
    {
        public FacilityIdentifier FacilityIdentifier { get; set; }
        public string Name { get; set; }
    }

    public class FacilityIdentifier
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }



    public class Embedded
    {
        [JsonProperty("item")]
        public List<NestedItem>Item { get; set; }
       
    }

    public class NestedItem
    {
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }
        [JsonProperty("_links")]
        public LinksLocationsStockSummary Links { get; set; }
    }

    public class LinksLocationsStockSummary
    {
        public SelfReferenceLink Self { get; set; }
        [JsonProperty("http://api.3plcentral.com/rels/inventory/stocksummaries")]
        public HttpApi3PlcentralComRelsInventoryStocksummaries HttpApi3plcentralComRelsInventoryStockSummaries { get; set; }
    }

    public class SelfReferenceLink
    {
        public object Href { get; set; }
    }

    public class HttpApi3PlcentralComRelsInventoryStocksummaries
    {
        public string Href { get; set; }
    }

    public class QualifierRenamer
    {
        public string Qualifier { get; set; }
        public string Renames { get; set; }
    }   


}
