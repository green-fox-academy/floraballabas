using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Net.Http;
using Xunit;
using System.Threading.Tasks;
using System.Net;

namespace ApiPracticeApp.IntegrationTests
{
    public class RestEndpointShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestEndpointShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatusForDouble()
        {
            var response = await Client.GetAsync("/doubling");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForGreeter()
        {
            var response = await Client.GetAsync("/greeter");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
