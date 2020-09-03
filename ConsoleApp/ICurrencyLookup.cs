namespace ValueObjectsWithRecordType
{
    public interface ICurrencyLookup
    {
        Currency FindCurrency(string currencyCode);
    }
}
