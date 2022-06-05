public class NzTaxCalculator : TaxCalculator
{
    public override Dictionary<TaxRate, decimal> CalculateGST(List<Invoice> orders)
    {
        var result = new Dictionary<TaxRate, decimal>();
        // some logic to calculate NZ GST
        return result;
    }
}
