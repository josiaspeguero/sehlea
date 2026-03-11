using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Sehlea.Front.Models;

namespace Sehlea.Front.Services
{
    public interface IEstudioService
    {
        Task<EstudioMedico?> GetEstudioByCedula(string cedula);
        Task<EstudioMedicoDTO?> GetEstudioById(int id);
        Task<List<EstudioMedicoDTO>> GetAllEstudios();
        Task<string> AddEstudio(EstudioMedicoDTO estudio);
    }

    public class EstudioService : IEstudioService
    {
        private readonly HttpClient _httpClient;

        public EstudioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EstudioMedicoDTO>> GetAllEstudios()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<EstudioMedicoDTO>>("http://localhost:5020/api/estudios/view") ?? new List<EstudioMedicoDTO>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<EstudioMedicoDTO>();
            }
        }

        public async Task<EstudioMedico?> GetEstudioByCedula(string cedula)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<EstudioMedico>($"http://localhost:5020/api/estudios/{cedula}");
            }
            catch
            {
                return null;
            }
        }

        public async Task<EstudioMedicoDTO?> GetEstudioById(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<EstudioMedicoDTO>($"http://localhost:5020/api/estudios/id/{id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<string> AddEstudio(EstudioMedicoDTO estudio)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5020/api/estudios/add", estudio);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
