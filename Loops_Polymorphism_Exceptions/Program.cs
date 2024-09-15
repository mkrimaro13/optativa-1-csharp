namespace Loops_Polymorphism_Exceptions
{
    class Program
    {
        static void Main()
        {
            var circle = new Circle();
            circle.radius = 5;
            var area = circle.Area();
            var perimeter = circle.Perimeter();
            Console.WriteLine($"Área de la circunferencia: {area}\nPerímetro de la circunferencia: {perimeter}\nEl nuevo radio será {circle.Add10()}");

            // Serie de Fibonacci
            // long prev = 0, next = 1, sum;
            // for (int i = 0; i < 50; i++)
            // {
            //     Console.WriteLine(prev);
            //     sum = prev + next;
            //     prev = next;
            //     next = sum;
            // }

            // Exceptions Try --- Catch
            try
            {
                Console.WriteLine("Número a dividir: ");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("Divisor: ");
                double divisor = double.Parse(Console.ReadLine());
                if (divisor == 0)
                {
                    throw new DivideByZeroException();
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            catch (Exception)
            {
                Console.WriteLine("No ingresaste un número");
            }
        }
    }

    // abstract class Figure
    // {
    //     public abstract double Area();
    //     public abstract double Perimeter();
    // }
    interface IFigure
    {
        public abstract double Area();
        public abstract double Perimeter();
    }
    interface IExtraOperations
    {
        public double Add10();
    }

    class Circle : IFigure, IExtraOperations
    {
        public double radius { get; set; }
        public double Area() => Math.PI * radius * radius;
        public double Perimeter() => 2 * Math.PI * radius;
        public double Add10()
        {
            return radius + 10;
        }
    }
}