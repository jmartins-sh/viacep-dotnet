using System;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace ViaCepDotNet.Tests;

public class ViaCepClientTests
{
    public ViaCepClient _sut;
    public ViaCepClientTests()
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://viacep.com.br/");
        _sut = new ViaCepClient(httpClient);
    }

    [Fact]
    public async Task QueryBy_WhenCallingAValidCep_ShouldReturnValidViaCepResult()
    {
        // Arrange
        
        // Act
        var result = await _sut.QueryByAsync("80320-090");

        // Assert
        result.Cep.Should().NotBeEmpty();
    }
}