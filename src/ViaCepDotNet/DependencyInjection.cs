namespace ViaCepDotNet;

using System;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;

public static class DependencyInjection
{
    public static IServiceCollection AddViaCepDotNet(this IServiceCollection services,
        Action<ViaCepSettings> configureViaCepSettings)
    {
        var settings = new ViaCepSettings();
        configureViaCepSettings(settings);

        services.AddHttpClient<IViaCepClient, ViaCepClient>(client =>
            {
                client.BaseAddress = new Uri(settings.BaseUrl);
            })
            .SetHandlerLifetime(TimeSpan.FromMinutes(15))
            .AddPolicyHandler(HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(settings.RetryCalls, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))));

        return services;
    }
}