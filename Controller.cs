public class Controller
{
    var calculator = new TaxCalculator();
    var result = calculator.CalculateGST(orders);
    return result;
}