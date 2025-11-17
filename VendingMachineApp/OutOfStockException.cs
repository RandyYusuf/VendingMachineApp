using System.Security.Cryptography;

namespace VendingMachineApp;
public class OutOfStockException : Exception
{
    public OutOfStockException(string message) : base(message)
    {

    }
}

