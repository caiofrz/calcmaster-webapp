namespace calcmaster_webapp.Models.Salary
{
    public class TaxSetup
    {
        public Dictionary<double, double> InssSalaryBaseAndTaxRate { get; init; }
        public Dictionary<double, double> InssSalaryBaseAndDeductionValue { get; init; }
        public Dictionary<double, double> IrSalaryBaseAndTaxRate { get; init; }
        public Dictionary<double, double> IrSalaryBaseAndDeductionValue { get; init; }

        public TaxSetup()
        {
            InssSalaryBaseAndTaxRate = new Dictionary<double, double> {
            { 7_786.02, 0.14 },
            { 4_000.04, 0.14 },
            { 2_666.69, 0.12 },
            { 1_412.01, 0.09 },
            { 0.01, 0.075 },
        };

            InssSalaryBaseAndDeductionValue = new Dictionary<double, double> {
            { 7_786.02, 181.28 },
            { 4_000.04, 181.28 },
            { 2_666.69, 101.18 },
            { 1_412.01, 21.18 },
            { 0.01, 0.0 },
        };

            IrSalaryBaseAndTaxRate = new Dictionary<double, double> {
            { 4_664.69, 0.275 },
            { 3_751.06, 0.225 },
            { 2_826.66, 0.15 },
            { 2_112.01, 0.075 },
            { 1_427, 0.0 },
        };

            IrSalaryBaseAndDeductionValue = new Dictionary<double, double> {
            { 4_664.69, 884.96 },
            { 3_751.06, 651.73 },
            { 2_826.66, 370.4 },
            { 2_112.01, 158.4 },
            { 1_427, 0.0 },
        };
        }
    }
}
