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
    class GreetShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public GreetShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnWithOkStatus()
        {
            var response = await Client.GetAsync("/greeter");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnWithInput8()
        {
            var response = await Client.GetStringAsync("/greeter?name=petike&title=student");
            Assert.Equal("{\"welcome_message\":\"Oh, hi there petike, my dear student!\"}", response);
        }

        [Fact]
        public async Task ReturnWithErrorMessage()
        {
            var response = await Client.GetStringAsync("/greeter?name=petike");
            Assert.Equal("{\"error\":\"Please provide a title!\"}", response);
        }
    }
}
