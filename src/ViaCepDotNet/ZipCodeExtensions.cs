using System.Linq;

namespace ViaCepDotNet;

internal static class ZipCodeExtensions
{
    internal static string FormatToValidZipCode(this string zipCode)
    {
        return string.Concat(zipCode.Where(char.IsNumber));
    }
}
