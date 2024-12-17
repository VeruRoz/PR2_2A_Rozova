namespace _00_Rev_01_poslední_dlouhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] slova = { "Karel", "Eva", "Jaromír", "Iva", "Martin" };
            Console.WriteLine(PosledniDlouhe(slova, 5));
            Console.WriteLine(PosledniDlouhe(slova, 7));
            Console.WriteLine(PosledniDlouhe(slova, 12));

        }
        public static string PosledniDlouhe(string[] pole, int limit)
        {
            string vysledek = "";
            for(int i = 0; i<pole.Length; i++)
            {
                if (pole[i].Length >= limit)
                    vysledek=pole[i]; 
            }

            return vysledek;
        }
    }
}