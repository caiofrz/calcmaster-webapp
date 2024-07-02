using calcmaster_webapp.interfaces.simple.strategies;

namespace calcmaster_webapp.Models.simple.context
{
    public class SimpleCalculatorContext
    {
        private ISimpleCalculatorStrategy? _strategy;

        public SimpleCalculatorContext SetStrategy(ISimpleCalculatorStrategy strategy)
        {
            _strategy = strategy;
            return this;
        }

        public double Calculate(double number1, double number2)
        {
            return _strategy?.Calculate(number1, number2)
                            ?? throw new ArgumentNullException("Nenhuma estratégia foi definida!");
        }

    }
}