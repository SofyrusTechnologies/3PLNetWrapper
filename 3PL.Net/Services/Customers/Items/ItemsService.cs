using _3PL.Net.Extensions;
using _3PL.Net.Model;
using _3PL.Net.Results;
using _3PL.Net.Serializer;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace _3PL.Net.Services.Customers.Items
{
    public class ItemsService : IItemsService
    {
        private readonly string itemEndPoint = @"/customers/{0}/items";//with placeholder for customerId

        public void Delete(int Id, int customerId, string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken), Constants.MissingAccessTokenMessage);
            if (customerId == 0)
                throw new ArgumentException(Constants.MissingCustomerIdMessage);
            if (Id==0)
                throw new ArgumentNullException(Constants.MissingItemIdMessage);
            string rql = string.Format("itemId=={0}", Id);
            var restclient = new RestClient(Constants.BaseUrl);
            RestRequest request = new RestRequest(string.Format(itemEndPoint, customerId)+"?rql="+rql) { Method = Method.DELETE };
            request.AddCommonHeaders(accessToken);
            var tResponse = restclient.Execute(request);
        }

        public ItemCollectionResultType GetList(GetItemListCriteria criteria, int customerId, string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken), Constants.MissingAccessTokenMessage);
            if (customerId == 0)
                throw new ArgumentException(Constants.MissingCustomerIdMessage);
            var restclient = new RestClient(Constants.BaseUrl);
            RestRequest request = new RestRequest(string.Format(itemEndPoint, customerId)) { Method = Method.GET };
            request.AddCommonHeaders(accessToken);

            var tResponse = restclient.Execute(request);

            return JsonConvert.DeserializeObject<ItemCollectionResultType>(tResponse.Content);

        }

        public Item SaveItem(Item item, int customerId, string accessToken)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Item cannot be null for this call");
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken), Constants.MissingAccessTokenMessage);
            if (customerId == 0)
                throw new ArgumentException(Constants.MissingCustomerIdMessage);

            var restclient = new RestClient(Constants.BaseUrl);
            RestRequest request = new RestRequest(string.Format(itemEndPoint, customerId)) { Method = Method.POST };

            request.AddCommonHeaders(accessToken);
            request.AddParameter(string.Empty, JsonConvert.SerializeObject(item, new DefaultJsonSerializer()), ParameterType.RequestBody);

            var tResponse = restclient.Execute(request);
            var responseJson = tResponse.Content;
            var responseKeys = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson);
            var checkReposnseForError = responseKeys.ContainsKey(Constants.ErrorCode) ? responseKeys[Constants.ErrorCode].ToString() : string.Empty;
            if (!string.IsNullOrEmpty(checkReposnseForError) && (checkReposnseForError == Constants.ErroCodeInvalid|| checkReposnseForError==Constants.ValueNotSupported))
                throw new InvalidOperationException(responseJson.ToString());

            return JsonConvert.DeserializeObject<Item>(tResponse.Content);
        }
    }

    public interface IItemsService
    {
        Item SaveItem(Item item, int customerId, string accessToken);
        ItemCollectionResultType GetList(GetItemListCriteria criteria, int customerId, string accessToken);
        void Delete(int Id, int customerId, string accessToken);
    }
}
