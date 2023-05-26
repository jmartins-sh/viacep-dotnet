using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ViaCepDotNet;

public class ViaCepClient : IViaCepClient
{
    private readonly HttpClient _httpClient;

    public ViaCepClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<ViaCepResult> QueryByAsync(string zipCode)
    {
        ZipCodeValidation.Ensure(zipCode);

        return _httpClient.GetFromJsonAsync<ViaCepResult>(
            $"ws/{zipCode.FormatToValidZipCode()}/json/"
        );
    }

    public Task<IEnumerable<ViaCepResult>> QueryByAsync(
        string stateInitials,
        string city,
        string street
    )
    {
        return _httpClient.GetFromJsonAsync<IEnumerable<ViaCepResult>>(
            $"ws/{stateInitials}/{city}/{street}/json/"
        );
    }
}
