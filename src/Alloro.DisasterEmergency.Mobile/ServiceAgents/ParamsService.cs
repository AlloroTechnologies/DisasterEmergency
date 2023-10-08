using System.Text.Json;
using Alloro.DisasterEmergency.Mobile.Models;

namespace Alloro.DisasterEmergency.Mobile.ServiceAgents;

public class ParamsService
{
    HttpClient _client;

    JsonSerializerOptions _serializerOptions;

    public ParamsService()
    {
        _client = new HttpClient();

        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            
            WriteIndented = true
        };
    }
    
    public async Task<Params> GetParamsAsync()
    {
        Uri uri = new Uri("https://allorodisasteremergencyapi.azurewebsites.net/api/params/");
        
        HttpResponseMessage response = await _client.GetAsync(uri);

        if (response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Params>(content, _serializerOptions);
        }
        else
        {
            return new Params();
        }
    }
}