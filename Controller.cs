public class Controller
{
    TaxCalculator calculator;
    string country; // initialised based on user's location
    var orders = new List<Invoice>(); // populate through database query

    switch (country)
    {
        case "NZ":
            calculator = new NzTaxCalculator();
            break;
        case "AU":
            calculator = new AuTaxCalculator();
            break;
    }

    var result = calculator.CalculateGST(orders);
    return result;
}
