namespace ViaCepDotNet;

public class ViaCepSettings
{
    internal ViaCepSettings() { }

    public string BaseUrl { get; init; } = "https://viacep.com.br/";

    public int RetryCalls { get; init; } = 3;
}
