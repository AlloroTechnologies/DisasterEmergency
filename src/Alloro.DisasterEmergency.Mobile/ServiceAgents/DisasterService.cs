using System.Text;
using System.Text.Json;
using Alloro.DisasterEmergency.Mobile.Entities;
using Alloro.DisasterEmergency.Mobile.Models;

namespace Alloro.DisasterEmergency.Mobile.ServiceAgents;

public class DisasterService
{
    HttpClient _client;

    JsonSerializerOptions _serializerOptions;

    public DisasterService()
    {
        _client = new HttpClient();

        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            
            WriteIndented = true
        };
    }

    public async Task NotifyDisasterAsync(Disaster disaster)
    {
        Uri uri = new Uri("https://allorodisasteremergencyapi.azurewebsites.net/api/disasters/");

        string json = JsonSerializer.Serialize(disaster, _serializerOptions);
        
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

        await _client.PostAsync(uri, content);
    }

    public async Task<List<Disaster>> GetDisastersAsync()
    {
        Uri uri = new Uri("https://allorodisasteremergencyapi.azurewebsites.net/api/disasters/");
        
        HttpResponseMessage response = await _client.GetAsync(uri);

        if (response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Disaster>>(content, _serializerOptions);
        }
        else
        {
            return new List<Disaster>();
        }
    }
}