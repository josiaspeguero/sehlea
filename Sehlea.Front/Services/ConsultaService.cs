using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Sehlea.Front.Models;

namespace Sehlea.Front.Services
{
    public interface IConsultaService
    {
        Task<List<Consulta>> GetProximasConsultas();
        Task<string> AddConsulta(ConsultaDTO consulta);
    }

    public class ConsultaService : IConsultaService
    {
        private readonly HttpClient _httpClient;

        public ConsultaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Consulta>> GetProximasConsultas()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Consulta>>("http://localhost:5020/api/consultas/upcoming") ?? new List<Consulta>();
            }
            catch
            {
                return new List<Consulta>();
            }
        }

        public async Task<string> AddConsulta(ConsultaDTO consulta)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5020/api/consultas/create", consulta);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
