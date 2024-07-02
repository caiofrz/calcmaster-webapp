using calcmaster_webapp.interfaces.simple.strategies;

namespace calcmaster_webapp.Models.simple.strategies
{
    public class Multiplication : ISimpleCalculatorStrategy
    {
        public double Calculate(double number1, double number2) => number1 * number2;
    }
}