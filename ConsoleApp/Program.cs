using System;

namespace ValueObjectsWithRecordType
{
    class Program
    {
        static void Main(string[] args)
        {
            var CurrencyLookup = new FakeCurrencyLookup();
            var p =  Money.FromDecimal(5, "EUR", CurrencyLookup);

            Console.WriteLine("Hello World!");
        }
    }
}
