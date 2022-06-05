public class Controller
{
    var calculator;
    var country; // initialised based on user's location
    var orders = new List<Invoice>(); // populate through database query
    var result;

    switch (country)
    {
        case 'NZ':
            calculator = new NzTaxCalculator();
            result = calculator.CalculateGST(orders);
            break;
        case 'AU':
            calculator = new AuTaxCalculator();
            result = calculator.CalculateGST(orders);
            break;
    }

    return result;
}
