namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escribe tú nombre:");
            string? NameInput = Console.ReadLine();

            string? BirthDayInput;
            DateOnly BirthDayConverted;
            bool isValidDate;
            do
            {
                Console.WriteLine("Escribe tú fecha de nacimiento, de la siguiente forma dd/mm/yy o dd-mm-yy: ");
                BirthDayInput = Console.ReadLine();
                isValidDate = DateOnly.TryParse(BirthDayInput, out BirthDayConverted);
            } while (!isValidDate);

            var persona = new Person
            {
                Name = NameInput,
                BirthDay = BirthDayConverted,
                Age = DateTime.Now.Year - BirthDayConverted.Year
            };
            Console.WriteLine($"Se ha guardado tú información:\n Nombre: {persona.Name}\n Fecha de nacimiento: {BirthDayConverted.ToLongDateString()}\n Edad: {persona.Age}");
        }
    }

    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public DateOnly BirthDay { get; set; }
    }
}