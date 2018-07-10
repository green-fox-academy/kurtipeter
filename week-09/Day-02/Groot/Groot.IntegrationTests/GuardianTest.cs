using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Groot.IntegrationTests
{
    public class GuardianTest
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTest()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task StatusOkWithQueryParameter()
        {
            var response = await Client.GetAsync("groot?message=ThisIsTheInput");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("Peti")]
        [InlineData("Tomi")]
        [InlineData("sdfdsfsdfsfsdfsdf")]
        public async Task ResponseOKWithQueryParameter(string input)
        {
            var response = await Client.GetAsync("groot?message=" + input);
            var responseString = await response.Content.ReadAsStringAsync();

            var definition = new { received = "", translated = "" };
            var expected = JsonConvert.DeserializeAnonymousType(responseString, definition);
            Assert.Equal(input, expected.received );
        }

        [Fact]
        public async Task StatusNotOkWithoutQueryParameter()
        {
            var response = await Client.GetAsync("groot");
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task ResponseOKWithoutQueryParameter()
        {
            var response = await Client.GetAsync("groot");
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("I am Groot!", responseString );
        }
    }
}
