namespace calcmaster_webapp.Interfaces.Salary
{
    public interface INetSalaryCalculator
    {
        public (double netSalary, double irDiscount, double inssDiscount) Calculate(double grossSalary);
    }
}