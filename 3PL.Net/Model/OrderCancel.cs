namespace _3PL.Net.Model
{

    public class OrderCancel
    {
        public Orderidentifier[] orderIdentifiers { get; set; }
        public string reason { get; set; }
        public float charge { get; set; }
        public Invoicecreationinfo invoiceCreationInfo { get; set; }
    }

    public class Invoicecreationinfo
    {
        public bool setInvoiceDate { get; set; }
        public int utcOffset { get; set; }
    }

    public class Orderidentifier
    {
        public int id { get; set; }
    }

}
