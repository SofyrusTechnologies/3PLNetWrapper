using RestSharp;

namespace _3PL.Net.Extensions
{
    internal static class RestSharpRequestExtensions
    {
        public static void AddCommonHeaders(this RestRequest request,string accessToken)
        {
            request.AddHeader("Accept", Constants.Accept_HAL_JSON);
            request.AddHeader("Content-Type", Constants.ContentType_HAL_JSON);
            request.AddHeader("Authorization", string.Format(Constants.AuthorizationBearer, accessToken));
            request.AddHeader("Accept-Encoding", Constants.Accept_Encoding);
            request.AddHeader("Accept-Language", Constants.Accept_Language);
            request.AddHeader("Cache-Control", Constants.NoCache);

        }
    }
}
