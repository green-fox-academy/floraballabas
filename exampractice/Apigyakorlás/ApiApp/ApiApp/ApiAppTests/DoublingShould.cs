using ApiApp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ApiAppTests
{
    public class DoublingShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public DoublingShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnWithOkStatus()
        {
            var response = await Client.GetAsync("/doubling");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnWithInput8()
        {
            var response = await Client.GetStringAsync("/doubling?input=8");
            Assert.Equal("{\"received\":8,\"result\":16}", response);
        }

        [Fact]
        public async Task ReturnWithErrorMessage()
        {
            var response = await Client.GetStringAsync("/doubling");
            Assert.Equal("{\"error\":\"Please provide an input!\"}", response);
        }
    }
}
