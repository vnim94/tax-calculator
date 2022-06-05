public abstract class TaxRate
{
    private decimal _value;

    protected TaxRate(decimal value)
    {
        this._valule = value;
    }

    public decimal value
    {
        get { return _value; }
    }
}
