using Devs2Blu.ProjetosAula.APIChuckNorrisMVC.Models;

namespace Devs2Blu.ProjetosAula.APIChuckNorrisMVC.Services
{
    public class ChuckNorrisAPIService
    {
        private readonly HttpClient _httpClient;
        private const string URL_API_NORRIS_FOOD = "https://api.chucknorris.io/jokes/search?query=food";
        
        public ChuckNorrisAPIService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<ChuckNorris> GetPhraseChuck()
        {
            return await Get<ChuckNorris>(URL_API_NORRIS_FOOD);
        }

        public async Task<T> Get<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
            {
                return (T)(object)url;
            }

            return await listHttp.Content.ReadFromJsonAsync<T>();
        }

        public async Task<List<T>> GetList<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return new List<T>();

            return await listHttp.Content.ReadFromJsonAsync<List<T>>();
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            var getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            return await _httpClient.SendAsync(getRequest);
        }

    }
}
