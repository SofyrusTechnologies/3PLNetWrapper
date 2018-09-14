using _3PL.Net.Services;
using Microsoft.Extensions.Configuration;
using System;

namespace _3PL.Net.Tests
{
    public class CustomerTestsFixture : IDisposable
    {
        public string AccessToken { get; set; }
        public int CustomerId { get; set; }
        public int FacilityId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string ThreePlKey { get; set; }
        public string UserId { get; set; }

        public CustomerTestsFixture()
        {
            var config = new ConfigurationBuilder()
                   .AddJsonFile("appsettings.json")
                   .Build();

            CustomerId = Convert.ToInt32(config["3PLCredentials:CustomerId"]);
            FacilityId = Convert.ToInt32(config["3PLCredentials:FacilityId"]);
            ClientId = config["3PLCredentials:ClientId"];
            ClientSecret = config["3PLCredentials:ClientSecret"];
            ThreePlKey = config["3PLCredentials:ThreePlKey"];
            UserId = config["3PLCredentials:UserId"];

            Authenticate auth = new Authenticate();
            AccessToken = auth.GetAuthenticationToken(ClientId, ClientSecret, ThreePlKey,UserId);


        }

        public void Dispose()
        {

        }
    }
}
