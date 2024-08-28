using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine("");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
