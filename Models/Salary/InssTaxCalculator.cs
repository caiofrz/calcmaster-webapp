using calcmaster_webapp.Interfaces.Salary;
using calcmaster_webapp.Models.Salary.Base;

namespace calcmaster_webapp.Models.Salary
{
    public class InssTaxCalculator : TaxCalculator, IInssTaxCalculator
    {
        public InssTaxCalculator(TaxSetup taxSetup) : base(taxSetup)
        {
        }

        public double CalculateDiscount(double grossSalary)
        {
            return GetDiscount(grossSalary,
                               _taxSetup.InssSalaryBaseAndTaxRate,
                               _taxSetup.InssSalaryBaseAndDeductionValue
                              );
        }
    }
}