namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // Las constantes no permiten ser reasignadas.
            const string Name = "Marco";
            // Interpolación de cadenas, sirve para dar formato a las cadenas de texto (Strings), similar al 'f' de python, y con la misma estructura js
            Console.WriteLine($"Hello {Name}!");
            Console.ReadLine();
        }
    }
}