using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Text.Json;

namespace SO.Web.Helper.Rest
{
    /// <summary>
    /// RestHelper to get or post data in api
    /// </summary>
    public class RestHelper : IRestHelper
    {
        private IConfiguration _configuration;

        public RestHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IRestResponse<T> Get<T>(string path)
        {
            var client = new RestClient(_configuration["Address:Url"]);
            var request = new RestRequest(path);
            var response = client.Get<T>(request);

            //if (!string.IsNullOrEmpty(response.Content))
                response.Data = JsonSerializer.Deserialize<T>(response.Content);

            return response;
        }

        public IRestResponse<T> Post<T>(string path, object request)
        {
            var client = new RestClient(_configuration["Address:Url"]);
            var rest = new RestRequest(path).AddJsonBody(request);
            return client.Post<T>(rest);
        }
    }
}
