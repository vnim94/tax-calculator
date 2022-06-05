public interface VATInterface
{
    Dictionary<TaxRate, decimal> CalculateVAT(List<Invoice> orders);
}
