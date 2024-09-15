namespace Logic_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.ShowMenu();
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "q")
                {
                    Console.WriteLine("Saliendo...");
                    break;
                }else if(int.TryParse(input, out int number) && number >= 1 && number <= 15)
                {
                    switch (int.Parse(input))
                    {
                        case 1:
                            Challenge1.Run();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 9:
                            break;
                        case 10:
                            break;
                        case 11:
                            break;
                        case 12:
                            break;
                        case 13:
                            break;
                        case 14:
                            break;
                        case 15:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida Intenta nuevamente");
                }
            }
        }
    }
}