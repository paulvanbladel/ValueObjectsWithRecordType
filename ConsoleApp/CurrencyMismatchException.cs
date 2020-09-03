using System;

namespace ValueObjectsWithRecordType
{
    public class CurrencyMismatchException : Exception
    {
        public CurrencyMismatchException(string message) : base(message)
        {
        }
    }
}
