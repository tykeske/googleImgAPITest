using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NSoup;
using System.IO;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.CognitiveServices.Search.ImageSearch;
using Microsoft.Azure.CognitiveServices.Search.ImageSearch.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace codeTest
{


    class GoogleImagesSearcher
    {

        // In production, make sure you're pulling the subscription key from secured storage.
        static string _subscriptionKey = "f1e7440fe61148bcbef8814ff82d114d";

        static string _baseUri = "https://api.bing.microsoft.com/v7.0/images/search";
        // The user's search string.
        static string searchString = "car";
        // To page through the images, you'll need the next offset that Bing returns.
        // To get additional insights about the image, you'll need the image's
        // insights token (see Visual Search API).
        // Bing uses the X-MSEdge-ClientID header to provide users with consistent
        // behavior across Bing API calls. See the reference documentation
        // for usage.
        static string _clientIdHeader = null;
        const string QUERY_PARAMETER = "?q=";  // Required
        const string MKT_PARAMETER = "&mkt=";  // Strongly suggested
        string imageURL = null;

       public async Task RunAsync()
        {
            RunAsync().Wait();

            try
            {

                // Remember to encode the q query parameter.
                var queryString = QUERY_PARAMETER + Uri.EscapeDataString(searchString);
                queryString += MKT_PARAMETER + "en-us";
                HttpResponseMessage response = await MakeRequestAsync(queryString);
                _clientIdHeader = response.Headers.GetValues("X-MSEdge-ClientID").FirstOrDefault();
                // This example uses dictionaries instead of objects to access the response data.
                var contentString = await response.Content.ReadAsStringAsync();
                Dictionary<string, object> searchResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentString);
                if (response.IsSuccessStatusCode)
                {
                    PrintImages(searchResponse);
                }
                
            }
            catch (Exception)
            {
            }

            async Task<HttpResponseMessage> MakeRequestAsync(string queryString)
            {
                string count = "1";
                string offset = "0";

                var client = new HttpClient();
                // Request headers. The subscription key is the only required header but you should
                // include User-Agent (especially for mobile), X-MSEdge-ClientID, X-Search-Location
                // and X-MSEdge-ClientIP (especially for local aware queries).
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);
                return await client.GetAsync(string.Format("{0}q={1}&count={1}", _baseUri + queryString, count, offset));
            }


            void PrintImages(Dictionary<string, object> response)
            {
                // This example prints the first page of images but if you want to page
                // through the images, you need to capture the next offset that Bing returns.
                var images = response["value"] as Newtonsoft.Json.Linq.JToken;
                foreach (Newtonsoft.Json.Linq.JToken image in images)
                {
                    string imageURL = (image["contentUrl"]).ToString();
                    // If you want to get additional insights about the image, capture the
                    // image token that you use when calling Visual Search API.       
                }

            }

        }

        // Makes the request to the Image Search endpoint.


        // Prints the list of images in the JSON response.


    }
}