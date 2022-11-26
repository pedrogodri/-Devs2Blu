namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Services
{
    public class PokemonAPIService
    {
        private readonly HttpClient _httpClient;
        private const String URL_API_PKMN = "https://pokeapi.co/api/v2/pokemon/";

        public PokemonAPIService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<T> Get<T>(String url)
        {
            var listHttp = await GetAsync(url);
            if (!listHttp.IsSuccessStatusCode)
                return (T)(object)url;

            return await listHttp.Content.ReadFromJsonAsync<T>();

        }

        public async Task<List<T>> GetList<T>(String url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return new List<T>();

            return await listHttp.Content.ReadFromJsonAsync<List<T>>();

        }

        public async Task<HttpResponseMessage> GetAsync(String url)
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
