namespace _00_opakování_220_nacitaci_metoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte desetiné čislo");
            VypsaniDesCisla();
        }
        public static void VypsaniDesCisla()
        {
           string input = Console.ReadLine();
            double number;
            while (true)
            {
                bool success = double.TryParse(input, out number);
                if (success)
                {

                    if (number % 1 != 0)
                    {
                        Console.WriteLine(number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Číslo není desetinné zadejte prosím znovu");
                        input = Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("zadali jste nesprávnou dohnotu");
                        input = Console.ReadLine();

                }
            }
        }
    }
}