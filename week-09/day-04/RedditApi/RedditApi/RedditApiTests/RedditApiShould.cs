using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using RedditApi;
using RedditApi.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RedditApiTests
{
    public class RedditApiShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RedditApiShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatusForListsPosts()
        {
            var response = await Client.GetAsync("/posts");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForAddPosts()
        {
            var usedPost = new Post
            {
                Title = "Test",
                Url = "test.hu",
                Score = 8
            };

            var convertedUsedPost= JsonConvert.SerializeObject(usedPost);
            var data = new StringContent(convertedUsedPost, encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("/posts", data);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnJsonForAddPosts()
        {
            var usedPost = new Post
            {
                Title = "Test",
                Url = "test.hu",
                Score = 8
            };

            var convertedUsedPost = JsonConvert.SerializeObject(usedPost);
            var data = new StringContent(convertedUsedPost, encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("/posts", data);

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"id\":1013,\"title\":\"Test\",\"url\":\"test.hu\",\"score\":8}", responseJson);
        }
    }
}
