namespace calcmaster_webapp.ViewModels
{
    public class SimpleCalculatorViewModel
    {

        public readonly string Title = "Calculadora Aritmética";
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Operation { get; set; }
        public double? Result { get; set; }

        public override string ToString()
        {
            return $"{Number1} {Operation} {Number2} = {Result}";
        }
    }
}