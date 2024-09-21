namespace _01_OOP_040_Test_vyrobku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tester tester = new Tester();
            bool pravda = tester.Vyhovuje();
            if(pravda)
                Console.WriteLine(pravda);
            else
                Console.WriteLine(pravda);
        }
    }
}