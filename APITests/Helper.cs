using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests
{
    public class Helper
    {
        private RestClient client;
        private RestRequest request;
        private const string baseUrl = "https://reqres.in/";

        public RestClient SetUrl()
        {
            var url = baseUrl;
            client = new RestClient(url);
            return client;
        }

        public RestRequest CreateGetRequset(string endpoint)
        {
            request = new RestRequest(endpoint, Method.Get);
            request.AddHeader("Accept", "application/json");
            return request;
        }

        public RestRequest CreatePostRequest(string endpoint, string payload)
        {
            request = new RestRequest(endpoint, Method.Post);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            return request;
        }

        public RestRequest CreatePutRequest(string endpoint, string payload)
        {
            request = new RestRequest(endpoint, Method.Put);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            return request;
        }

        public RestResponse GetResponse(RestClient restClient, RestRequest restRequset)
        {
            return restClient.Execute(restRequset);
        }

        public T GetContent<T>(RestResponse response)
        {
            var content = response.Content;
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
