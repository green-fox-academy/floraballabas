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

        [Fact]
        public async Task ReturnOkStatusForArray()
        {
            var response = await Client.GetAsync("/array");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForDoUntil()
        {
            var response = await Client.GetAsync("/dountil/{what}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForAppenda()
        {
            var response = await Client.GetAsync("/appenda/{appendable}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnNotFoundForAppend()
        {
            var response = await Client.GetAsync("/appenda");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}