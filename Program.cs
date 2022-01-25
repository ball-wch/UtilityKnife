namespace UtilityKnife
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var converter = new FahrenheitToCelsius();
            var celsius = converter.FahrenheitToCelsiusConverter(212.0);
            Console.WriterLine($"Fahrenheit temp of 212 is {celsius}.");
        }
    }
}