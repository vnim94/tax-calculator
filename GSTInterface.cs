public interface GSTInterface
{
    Dictionary<TaxRate, decimal> CalculateGST(List<Invoice> orders);
}
