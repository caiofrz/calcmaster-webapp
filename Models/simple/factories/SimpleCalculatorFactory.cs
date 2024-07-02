using calcmaster_webapp.Enums;
using calcmaster_webapp.interfaces.simple.strategies;
using calcmaster_webapp.Models.simple.strategies;

namespace calcmaster_webapp.Models.simple.factories
{
    public class SimpleCalculatorFactory
    {
        public ISimpleCalculatorStrategy Create(SimpleCalculatorOperationsEnum operation)
        {
            return operation switch
            {
                SimpleCalculatorOperationsEnum.SUM => new Sum(),
                SimpleCalculatorOperationsEnum.SUBTRACTION => new Subtraction(),
                SimpleCalculatorOperationsEnum.MULTIPLICATION => new Multiplication(),
                SimpleCalculatorOperationsEnum.DIVISION => new Division(),
                _ => throw new NotImplementedException()
            };
        }
    }

}
