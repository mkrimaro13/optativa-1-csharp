namespace Conditionals_and_Operators
{
    class Program
    {
        static void Main()
        {
            // Conditional IF
            // int? NumberInput;
            // Console.WriteLine("Ingresa un número:");
            // NumberInput = int.Parse(Console.ReadLine());
            // if(NumberInput > 0) Console.WriteLine("El número es positivo");
            // else if (NumberInput < 0) Console.WriteLine("El número es negativo");
            // else Console.WriteLine("El número es cero");

            // Operators
            const string undefined = "Indeterminado";
            Console.WriteLine("Ingresa el primer número: ");
            double? a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número: ");
            double? b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Suma: {a+b}\nResta:\n {a}-{b}: {a-b}\n {b}-{a}: {b-a}\nMultiplicación: {a*b}\nDivisión:\n {a}/{b}: {(b!=0 ? a/b : undefined)}\n {b}/{a}: {(a!=0 ? b/a : undefined)}");
        }
    }
}