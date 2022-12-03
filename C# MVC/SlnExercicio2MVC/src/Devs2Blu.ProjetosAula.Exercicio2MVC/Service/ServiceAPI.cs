using Devs2Blu.ProjetosAula.Exercicio2MVC.Models.DTOAPI;
using System.Net.Http;

namespace Devs2Blu.ProjetosAula.Exercicio2MVC.Service
{
    public class ServiceAPI
    {
        private readonly HttpClient _httpClient;

        public ServiceAPI()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<MapsDTO>> GetListMaps()
        {
            var objJSONResponse = await Get<GetListDataMapsDTO>(URL_API);
            var listMaps = objJSONResponse.Data;
            return listMaps;
        }

        public async Task<List<MapsDTO>> GetMapsByName(string displayName)
        {
            var urlSearch = $"{URL_API}?displayName={displayName}";
            var objJSONResponse = await Get<GetListDataMapsDTO>(urlSearch);
            var listMaps = objJSONResponse.Data;
            return listMaps;
        }

        #region BaseMethods

        public async Task<T> Get<T>(string url)
        {
            var objHttp = await GetAsync(url);

            if (!objHttp.IsSuccessStatusCode)
            {
                return (T)(object)url;
            }

            return await objHttp.Content.ReadFromJsonAsync<T>();
        }

        public async Task<List<T>> GetList<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
            {
                return new List<T>();
            }

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

        #endregion

        #region CONSTS

        private const string URL_API = "https://valorant-api.com/v1/maps";

        #endregion
    }
}
