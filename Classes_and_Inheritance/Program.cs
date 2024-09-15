namespace Classes_and_Inheritance
{
    class Program
    {
        static void Main()
        {
            // var rect = new Rectangle();
            // rect.Base = 25;
            // rect.Height = 50;
            // Console.WriteLine($"El área es: {rect.Area()}\nEl perímetro es: {rect.Perimeter()}");

            var sq = new Square();
            sq.Side = 30;
            Console.WriteLine($"El Lado del cuadrado es: {sq.Side}\nEl área es: {sq.Area()}\nEl perímetro es: {sq.Perimeter()}");
        }
    }
    class Rectangle
    {
        public double Base { get; set; }
        public double Height { get; set; }
        // Función anónima o Lambda, si se necesitan hacer varias transformaciones y operaciones es mejor crear un método o función tradicional.
        public double Area() => Base * Height;
        public double Perimeter() => 2 * Base + 2 * Height;
    }
    // La herencia en C# se asigna con los dos puntos -> subclass : superclass
    class Square : Rectangle
    {
        public double Side
        {
            set { Base = value; Height = value; }
            get { return Base; }
        }
    }
}