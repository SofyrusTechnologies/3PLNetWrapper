using _3PL.Net.Services;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace _3PL.Net.Tests
{
    public class AuthTokenTest
    {
        [Fact]
        public void WhenProvidedCredentialsGetToken()
        {
            var config = new ConfigurationBuilder()
                   .AddJsonFile("appsettings.json")
                   .Build();


            var clientId = config["3PLCredentials:ClientId"];
            var clientSecret = config["3PLCredentials:ClientSecret"];
            var threePlKey = config["3PLCredentials:ThreePlKey"];
            var userId = config["3PLCredentials:UserId"];

            Authenticate auth = new Authenticate();
            string token = auth.GetAuthenticationToken(clientId, clientSecret, threePlKey, userId);
            Assert.True(!string.IsNullOrEmpty(token));
        }
    }
}
