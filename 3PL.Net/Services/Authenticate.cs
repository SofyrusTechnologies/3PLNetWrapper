using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace _3PL.Net.Services
{
    public class Authenticate : IAuthenticate
    {
        private readonly string tokenEndPoint = @"/AuthServer/api/Token";

        public string GetAuthenticationToken(string clientId, string clientSecret, string threePlKey,string userLoginId)
        {
            if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret) || string.IsNullOrEmpty(threePlKey) || string.IsNullOrEmpty(userLoginId))
                throw new ArgumentNullException(nameof(clientSecret), "Invalid parameters! Please send non empty credential values");
            var encodedString = GenerateBase64StringForCredentials(clientId,clientSecret);
            
            var restclient = new RestClient(Constants.BaseUrl);
            RestRequest request = new RestRequest(tokenEndPoint) { Method = Method.POST };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", encodedString);
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("tpl", threePlKey);
            request.AddParameter("user_login_id", userLoginId);
            var tResponse = restclient.Execute(request);
            var responseJson = tResponse.Content;
            var token = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson)["access_token"].ToString();
            return token.Length > 0 ? token : null;

        }

        private string GenerateBase64StringForCredentials(string clientId, string clientSecret)
        {
            
            var encodedData = Convert.ToBase64String(
                                System.Text.Encoding.GetEncoding("UTF-8")
                                  .GetBytes(clientId + ":" + clientSecret)
                                );
            return "Basic " + encodedData;
        }
    }




    public interface IAuthenticate
    {
        string GetAuthenticationToken(string clientId, string clientSecret, string threePlKey,string userLoginId);
    }
}
