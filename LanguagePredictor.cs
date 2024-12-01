using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace LanguageClassificationApp
{
    public class LanguagePredictor
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<string> DetectLanguageAsync(string inputText)
        {
            var url = "https://a4c2-34-80-37-196.ngrok-free.app/predict";  // change Flask server URL every new run of server

            var requestBody = new
            {
                text = inputText
            };

            var jsonContent = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();

            dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);
            return jsonResponse.predicted_language;
        }
    }
}
