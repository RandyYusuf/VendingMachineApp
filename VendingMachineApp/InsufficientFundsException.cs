using System.Security.Cryptography;

namespace VendingMachineApp;
public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {

    }
}


