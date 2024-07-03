
using calcmaster_webapp.Interfaces.Salary;
using calcmaster_webapp.Models.Salary.Base;

namespace calcmaster_webapp.Models.Salary
{
    public class IrTaxCalculator : TaxCalculator, IIrTaxCalculator
    {
        public IrTaxCalculator(TaxSetup taxSetup) : base(taxSetup)
        {
        }

        public double CalculateDiscount(double grossSalary)
        {
            return GetDiscount(grossSalary,
                               _taxSetup.IrSalaryBaseAndTaxRate,
                               _taxSetup.IrSalaryBaseAndDeductionValue
                               );
        }
    }
}