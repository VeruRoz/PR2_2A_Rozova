namespace _00_opakovani_150_Je_trojúhelník
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte stranu a");
            string input = Console.ReadLine();
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("není to čislo zadej znovu");
            }
            Console.WriteLine("zadejte stranu b");
            input = Console.ReadLine();
            double b;
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("není to čislo zadej znovu");
            }
            Console.WriteLine("zadejte stranu c");
            input = Console.ReadLine();
            double c;
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("není to čislo zadej znovu");
            }
            bool IsTriangle = false;
            if (a + b > c && a + c > b && c + b > a)
                IsTriangle = true;

            else
                IsTriangle = false;

            if (IsTriangle)
                Console.WriteLine("trojúhelník jde sestavit");
            else
                Console.WriteLine("trojúhelník nejde sestavit");
        }
    }
}