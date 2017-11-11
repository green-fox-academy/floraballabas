using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Net.Http;
using Xunit;
using System.Threading.Tasks;
using System.Net;
using ApiPracticeApp.Models;
using Newtonsoft.Json;
using System.Text;

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

        [Fact]
        public async Task ReturnNotFoundForArray()
        {
            var response = await Client.GetStringAsync("/array");
            string error = "{\"error\":\"Please provide what to do with the numbers!\"}";

            Assert.Equal(error, response);
        }

        [Fact]
        public async Task ReturnResultWithSum1357()
        {
            var usedArray = new ArrayObject
            {
                Action = "Sum",
                Number = new int[] { 1, 3, 5, 7 }
            };

            string convertedUsedArray = JsonConvert.SerializeObject(usedArray);
            var content = new StringContent(convertedUsedArray,
                encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("array", content);

            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":16}", responseJson);
        }

        //DoUntil Tests
        [Fact]
        public async Task ReturnErrorMessageWithNullInputSum()
        {
            var data = new StringContent(content: "", encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("dountil/sum", data);
            var responseString = await response.Content.ReadAsStringAsync();

            string error = "{\"error\":\"Please provide a number!\"}";

            Assert.Equal(error, responseString);
        }

        [Fact]
        public async Task ReturnErrorMessageWithOutWhat()
        {
            var usedUntil = new JsonObject
            {
                Until = 5
            };

            var convertedUsedUntil = JsonConvert.SerializeObject(usedUntil);
            var data = new StringContent(convertedUsedUntil.ToString(), encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("dountil", data);
            
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResultWithUntil5()
        {
            var usedUntil = new JsonObject
            {
                Until = 5
            };

            var convertedUsedUntil = JsonConvert.SerializeObject(usedUntil);
            var data = new StringContent(convertedUsedUntil.ToString(), encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("dountil/sum", data);

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":15}", responseJson);
        }
        //double test
        [Fact]
        public async Task ReturnResultWithInput5()
        {
            string test = await Client.GetStringAsync("/doubling?input=5");

            Assert.Equal("{\"received\":5,\"result\":10}", test);
        }
    }
}
