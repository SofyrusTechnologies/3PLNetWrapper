using _3PL.Net.Extensions;
using _3PL.Net.Model;
using _3PL.Net.Results;
using _3PL.Net.Serializer;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace _3PL.Net.Services.Orders
{
    public class OrdersService : IOrderService
    {
        private readonly string orderCreateEndPoint = @"/orders";
        private readonly string orderDetailsEndPoint = @"/orders/{0}?detail=All";
        private readonly string orderCancelEndPoint = @"/orders/canceler";

        public void CancelOrder(OrderCancel order, string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken), Constants.MissingAccessTokenMessage);
            if (order == null)
                throw new ArgumentException(nameof(order), "No order provided");


            var restclient = new RestClient(Constants.BaseUrl);
            RestRequest request = new RestRequest(orderCancelEndPoint) { Method = Method.POST };
            request.AddCommonHeaders(accessToken);
            request.AddParameter(string.Empty, JsonConvert.SerializeObject(order, new DefaultJsonSerializer()), ParameterType.RequestBody);

            var tResponse = restclient.Execute(request);
        }

        public OrderCreateReturnType CreateOrder(Order order, string accessToken)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order), "Order cannot be null for this call");
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken), Constants.MissingAccessTokenMessage);

            var restclient = new RestClient(Constants.BaseUrl);
            RestRequest request = new RestRequest(string.Format(orderCreateEndPoint)) { Method = Method.POST };

            request.AddCommonHeaders(accessToken);
            request.AddParameter(string.Empty, JsonConvert.SerializeObject(order, new DefaultJsonSerializer()), ParameterType.RequestBody);

            var tResponse = restclient.Execute(request);
            var responseJson = tResponse.Content;
            var responseKeys = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson);
            var checkReposnseForError = responseKeys.ContainsKey(Constants.ErrorCode) ? responseKeys[Constants.ErrorCode].ToString() : string.Empty;
            if (!string.IsNullOrEmpty(checkReposnseForError) && (checkReposnseForError == Constants.ErroCodeInvalid || checkReposnseForError == Constants.ValueNotSupported))
                throw new InvalidOperationException(responseJson.ToString());

            return JsonConvert.DeserializeObject<OrderCreateReturnType>(tResponse.Content);
        }

        public OrderDetailResultType GetOrderDetails(int orderId, string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken), Constants.MissingAccessTokenMessage);
            if (orderId == 0)
                throw new ArgumentException(Constants.MissingOrderIdMessage);


            var restclient = new RestClient(Constants.BaseUrl);
            RestRequest request = new RestRequest(string.Format(orderDetailsEndPoint, orderId)) { Method = Method.GET };
            request.AddCommonHeaders(accessToken);

            var tResponse = restclient.Execute(request);

            return JsonConvert.DeserializeObject<OrderDetailResultType>(tResponse.Content);
        }
    }

    public interface IOrderService
    {
        OrderCreateReturnType CreateOrder(Order order, string accessToken);
        OrderDetailResultType GetOrderDetails(int orderId, string accessToken);
        void CancelOrder(OrderCancel order, string accessToken);
        
    }
}
