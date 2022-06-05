public abstract class TaxCalculator
{
	public abstract Dictionary<NzTaxRate, decimal> CalculateGST(List<Invoice> orders);
}