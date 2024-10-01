namespace _00_Rev_02_prumer_lichych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[50];
            while(true)
            {
                Console.WriteLine("zadejte celé číslo");
                string input = Console.ReadLine();
                int number;
                if (input == "stop")
                {
                    break;
                }
                while (!int.TryParse(input, out number))
                {
                     Console.WriteLine("zadali jste špatnou hodnotu");
                     input = Console.ReadLine();
                }
                int i = 0;
                numbers[i] = number;
                i++;
            }
            int početčisel = 0;
            double prumer = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >0 && numbers[i] %2 !=0)
                {
                    početčisel++;
                    prumer += numbers[i];
                }

            }
            prumer = prumer / početčisel;
            Console.WriteLine(prumer);
        }
    }
}