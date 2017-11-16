using GrootApp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace GrootTests
{
    public class EndpointShould
    {
        private HttpClient Client;
        private TestServer Server;

        public EndpointShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("groot");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnMessage()
        {
            //act
            var response = await Client.GetStringAsync("groot?message=Szia");

            //assert
            Assert.Equal("{\"welcome_message\":\"Szia\"}", response);
        }

        [Fact]
        public async Task IndexShouldReturnNotOkStatus()
        {
            //act
            var response = await Client.GetAsync("groot");

            //assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnErrorMessage()
        {
            //act
            var response = await Client.GetStringAsync("groot");

            //assert
            Assert.Equal("{\"error\":\"I am Groot\"}", response);
        }
    }
}
