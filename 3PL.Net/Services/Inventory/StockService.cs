using _3PL.Net.Extensions;
using _3PL.Net.Results;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace _3PL.Net.Services.Inventory
{
    public class StockService : IStockService
    {
        private readonly string stockDetailsEndPoint = @"/inventory/stockdetails?customerid={0}&facilityid={1}";//with placeholders
        private readonly string stockSummaryEndPoint = @"/inventory/stocksummaries?{0}";

        public StockSummaryResultType GetItemStockSummary(int itemId, string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken), Constants.MissingAccessTokenMessage);
            if (itemId == 0)
                throw new ArgumentException(Constants.MissingItemIdMessage);

            var restclient = new RestClient(Constants.BaseUrl);
            string rql = string.Format("rql=itemid=={0}", itemId);
            RestRequest request = new RestRequest(string.Format(stockSummaryEndPoint, rql)) { Method = Method.GET };
            request.AddCommonHeaders(accessToken);

            var tResponse = restclient.Execute(request);

            return JsonConvert.DeserializeObject<StockSummaryResultType>(tResponse.Content);
        }

        public StockDetailsResultType GetStock(int customerId, int facilityId, string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken), Constants.MissingAccessTokenMessage);
            if (customerId == 0)
                throw new ArgumentException(Constants.MissingCustomerIdMessage);
            if (facilityId == 0)
                throw new ArgumentException(Constants.MissingFacilityIdMessage);

            var restclient = new RestClient(Constants.BaseUrl);
            RestRequest request = new RestRequest(string.Format(stockDetailsEndPoint, customerId, facilityId)) { Method = Method.GET };
            request.AddCommonHeaders(accessToken);

            var tResponse = restclient.Execute(request);

            return JsonConvert.DeserializeObject<StockDetailsResultType>(tResponse.Content);
        }
        /// <summary>
        /// Get Stock details
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="facilityId"></param>
        /// <param name="date"></param><remarks>Include time if same day details are required</remarks>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public StockDetailsResultType GetStockByDate(int customerId, int facilityId, DateTime date, string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken), Constants.MissingAccessTokenMessage);
            if (customerId == 0)
                throw new ArgumentException(Constants.MissingCustomerIdMessage);
            if (facilityId == 0)
                throw new ArgumentException(Constants.MissingFacilityIdMessage);

            var restclient = new RestClient(Constants.BaseUrl);
            RestRequest request = new RestRequest(string.Format(stockDetailsEndPoint, customerId, facilityId) + "&rql=ReceivedDate=le=" + date) { Method = Method.GET };
            request.AddCommonHeaders(accessToken);

            var tResponse = restclient.Execute(request);

            return JsonConvert.DeserializeObject<StockDetailsResultType>(tResponse.Content);
        }
    }

    public interface IStockService
    {
        StockDetailsResultType GetStock(int customerId, int facilityId, string accessToken);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="facilityId"></param>
        /// <param name="date"></param><remarks>Include time if same day details are required</remarks>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        StockDetailsResultType GetStockByDate(int customerId, int facilityId, DateTime date, string accessToken);
        StockSummaryResultType GetItemStockSummary(int itemId, string accessToken);

    }
}
