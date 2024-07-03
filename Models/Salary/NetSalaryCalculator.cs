using calcmaster_webapp.Interfaces.Salary;

namespace calcmaster_webapp.Models.Salary
{
    public class NetSalaryCalculator : INetSalaryCalculator
    {
        private IIrTaxCalculator _irTaxCalculator;
        private IInssTaxCalculator _inssTaxCalculator;

        public NetSalaryCalculator(IIrTaxCalculator irTaxCalculator, IInssTaxCalculator inssTaxCalculator)
        {
            _irTaxCalculator = irTaxCalculator;
            _inssTaxCalculator = inssTaxCalculator;
        }

        public (double, double, double) Calculate(double grossSalary)
        {
            double inssTax = _inssTaxCalculator.CalculateDiscount(grossSalary);
            double netSalary = grossSalary - inssTax;

            double irTax = _irTaxCalculator.CalculateDiscount(netSalary);
            netSalary -= irTax;

            return (netSalary, inssTax, irTax);
        }
    }
}