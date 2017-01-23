using Newtonsoft.Json;
using Rancher.DotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Rancher.DotNet
{
    public class HttpProxy
    {
        static HttpClient HttpClient = new HttpClient();
 
        public HttpProxy(string baseUrl)
        {
            // Setup http client with Rancher URL
            HttpClient.BaseAddress = new Uri(baseUrl);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static T PostAync<T>(IRequestObject request, string uri)
        {
            // Convert request to json format
            var jsonContent = new StringContent(
                    content: JsonConvert.SerializeObject(request),
                    encoding: Encoding.UTF8,
                    mediaType: "application/json"
            );

            // POST request to uri
            var response = HttpClient.PostAsync(uri, jsonContent).Result;

            // Get response body
            var body = response.Content.ReadAsStringAsync().Result;

            // Return response body
            return JsonConvert.DeserializeObject<T>(body);
        }

        public HttpStatusCode DeleteAync(string uri)
        {
            // POST request to uri
            var response = HttpClient.DeleteAsync(uri).Result;

            // Get response body
            return response.StatusCode;
        }


        public T GetAsync<T>(string uri)
        {
            var response = HttpClient.GetAsync(uri).Result;
            var body = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(body);
        }
    }
}
