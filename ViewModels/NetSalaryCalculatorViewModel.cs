namespace calcmaster_webapp.ViewModels
{
    public class NetSalaryCalculatorViewModel
    {
        public readonly string Title = "Calculadora de Salário";
        public double GrossSalary { get; set; }
        public double NetSalary { get; set; }
        public double InssDiscountValue { get; set; }
        public double IrDiscountValue { get; set; }
        public double TotalDiscountValue { get; set; }
    }
}