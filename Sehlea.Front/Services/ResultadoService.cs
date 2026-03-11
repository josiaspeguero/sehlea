using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Sehlea.Front.Models;

namespace Sehlea.Front.Services
{
    public interface IResultadoService
    {
        Task<string> AddResultado(ResultadoEstudioDTO resultado);
        Task<List<ResultadoEstudio>> GetResultadosByEstudio(int estudioId);
    }

    public class ResultadoService : IResultadoService
    {
        private readonly HttpClient _httpClient;

        public ResultadoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> AddResultado(ResultadoEstudioDTO resultado)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5020/api/resultados", resultado);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<List<ResultadoEstudio>> GetResultadosByEstudio(int estudioId)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<ResultadoEstudio>>($"http://localhost:5020/api/resultados/estudio/{estudioId}") ?? new List<ResultadoEstudio>();
            }
            catch
            {
                return new List<ResultadoEstudio>();
            }
        }
    }
}
