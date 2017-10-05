using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Interfaces;
using WpfApp1.Model.Base;

namespace WpfApp1.Repos.Base
{
    public abstract class RepoBase<T> : IRepo<T> where T : ModelBase, new()
    {
        private HttpClient _httpClient;
        private readonly string BASE_ADDRESS = @"http://localhost:3000/api/";
        private string api;

        protected RepoBase()
        {
            api = $"{BASE_ADDRESS}{typeof(T).Name.Trim().ToLower()}/";
            _httpClient = CreateHttpClient();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            HttpResponseMessage res = await _httpClient.GetAsync(api);
            if (res.IsSuccessStatusCode)
            {
                var resText = res.Content.ReadAsStringAsync().Result;
                JObject jObject = JObject.Parse(resText);
                var data = jObject["data"]?.ToString();
                return JsonConvert.DeserializeObject<IEnumerable<T>>(data);
            }
            else
            {
                return default(IEnumerable<T>);
            }
        }

        public Task<bool> PostAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutAsync(T entity)
        {
            throw new NotImplementedException();
        }

        internal HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BASE_ADDRESS);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

        internal StringContent CreateStringContent()
        {
            var jObject = JsonConvert.SerializeObject(default(T), Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return new StringContent(jObject, Encoding.UTF8, "application/json");
        }
    }
}