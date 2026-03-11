using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Sehlea.Front.Models;

namespace Sehlea.Front.Services
{
    public interface IPacienteService
    {
        Task<List<PacienteDTO>> GetPacientes();
        Task<string> AddPaciente(PacienteDTO paciente);
    }

    public class PacienteService : IPacienteService
    {
        private readonly HttpClient _httpClient;

        public PacienteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PacienteDTO>> GetPacientes()
        {
            var response = await _httpClient.GetAsync("http://localhost:5020/api/pacientes/view");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Error {response.StatusCode}: {error}");
            }

            try
            {
                return await response.Content.ReadFromJsonAsync<List<PacienteDTO>>() ?? new List<PacienteDTO>();
            }
            catch (System.Text.Json.JsonException)
            {
                var content = await response.Content.ReadAsStringAsync();
                throw new System.Text.Json.JsonException($"Expected JSON but got HTML/Text: {content}");
            }
        }

        public async Task<string> AddPaciente(PacienteDTO paciente)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5020/api/pacientes/create", paciente);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "Error al agregar paciente";
        }
    }
}
