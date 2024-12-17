namespace _01_OOP_020_Tachometr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tachometr tachometr = new Tachometr();
            Console.WriteLine("kolik kilometru");
            string input = Console.ReadLine();
            int kilometru;
            bool IsNumber = int.TryParse(input,out kilometru);
            while (true)
            {
                if (IsNumber)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("špatný vstup");
                    input = Console.ReadLine();
                }
            }

            tachometr.Ujel(kilometru);
        }
    }
}