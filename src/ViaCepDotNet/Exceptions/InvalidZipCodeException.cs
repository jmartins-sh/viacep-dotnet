using System;

namespace ViaCepDotNet.Exceptions;

public class InvalidZipCodeException : Exception
{
    public string ZipCode { get; }

    public InvalidZipCodeException(string zipCode, string message)
        : base(message)
    {
        ZipCode = zipCode;
    }
}
