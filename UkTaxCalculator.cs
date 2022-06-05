public class UkTaxCalculator : TaxCalculator, VATInterface
{
    public Dictionary<TaxRate, decimal> CalculateVAT(List<Invoice> orders)
    {
        var result = new Dictionary<TaxRate, decimal>();
        // some logic to calculate UK VAT
        return result;
    }
}
