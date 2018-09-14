namespace _3PL.Net.Results
{

    public class StockSummaryResultType
    {
        public Summary[] summaries { get; set; }
    }

    public class Summary
    {
        public Itemidentifier itemIdentifier { get; set; }
        public string qualifier { get; set; }
        public float totalReceived { get; set; }
        public float allocated { get; set; }
        public float available { get; set; }
        public float onHold { get; set; }
        public float onHand { get; set; }
        public int facilityId { get; set; }
    }   
}
