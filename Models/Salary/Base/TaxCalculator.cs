namespace calcmaster_webapp.Models.Salary.Base
{
    public abstract class TaxCalculator
    {
        protected readonly TaxSetup _taxSetup;

        protected TaxCalculator(TaxSetup taxSetup)
        {
            _taxSetup = taxSetup;
        }

        protected double GetDiscount(
                                double grossSalary,
                                IDictionary<double, double> taxRates,
                                IDictionary<double, double> taxDeductionValues
                                )
        {
            double totalDiscount = 0;

            // taxRates
            // .Where(taxRate => grossSalary >= taxRate.Key)
            // .Select(taxRate => totalDiscount += taxRate.Value);

            foreach (var taxRate in taxRates)
            {
                if (grossSalary >= taxRate.Key)
                {
                    totalDiscount += Math.Round(grossSalary * taxRate.Value);
                    break;
                }
            }

            // taxDeductionValues
            // .Where(taxDeductionValue => grossSalary >= taxDeductionValue.Key)
            // .Select(taxDeductionValue => totalDiscount -= taxDeductionValue.Value);

            foreach (var taxDeductionValue in taxDeductionValues)
            {
                if (grossSalary >= taxDeductionValue.Key)
                {
                    totalDiscount -= taxDeductionValue.Value;
                    break;
                }
            }

            return totalDiscount;
        }
    }
}