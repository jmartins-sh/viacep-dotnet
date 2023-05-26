using System.Linq;
using ViaCepDotNet.Exceptions;

namespace ViaCepDotNet;

internal static class ZipCodeValidation
{
    public static void Ensure(string zipCode)
    {
        if (string.IsNullOrWhiteSpace(zipCode.FormatToValidZipCode()))
            throw new InvalidZipCodeException(
                zipCode,
                $"The zipcode must has valid digits. ZipCode Input: {zipCode}"
            );

        if (zipCode.Length < 8)
            throw new InvalidZipCodeException(
                zipCode,
                $"The zipcode must be 8 numbers at least. ZipCode Input: {zipCode}"
            );
    }
}
