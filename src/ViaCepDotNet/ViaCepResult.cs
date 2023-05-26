using System;
using System.Text.Json.Serialization;

namespace ViaCepDotNet;

public class ViaCepResult
{
    public ViaCepResult() { }

    [JsonConstructor]
    public ViaCepResult(
        string cep,
        string logradouro,
        string complemento,
        string bairro,
        string localidade,
        string uf,
        string ibge,
        string gia,
        string ddd,
        string siafi
    )
    {
        Cep = cep;
        Street = logradouro;
        Complement = complemento;
        Neighborhood = bairro;
        City = localidade;
        StateInitials = uf;
        IbgeCode = int.Parse(ibge);
        GiaCode = int.Parse(gia);
        DialingCode = int.Parse(ddd);
        SiafiCode = int.Parse(siafi);
    }

    [JsonPropertyName("cep")]
    public string Cep { get; }

    [JsonPropertyName("logradouro")]
    public string Street { get; }

    [JsonPropertyName("complemento")]
    public string Complement { get; }

    [JsonPropertyName("bairro")]
    public string Neighborhood { get; }

    [JsonPropertyName("localidade")]
    public string City { get; }

    [JsonPropertyName("uf")]
    public string StateInitials { get; }

    [JsonPropertyName("ibge")]
    public int IbgeCode { get; }

    [JsonPropertyName("gia")]
    public int GiaCode { get; }

    [JsonPropertyName("ddd")]
    public int DialingCode { get; }

    [JsonPropertyName("siafi")]
    public int SiafiCode { get; }
}
