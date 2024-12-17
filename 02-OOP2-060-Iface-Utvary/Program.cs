namespace _02_OOP2_060_Iface_Utvary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUtvary[] utvary = new IUtvary[4];
            utvary[0] = new Ctverec(3);
            utvary[1] = new Kruh(3);
            utvary[2] = new Trojuhelnik(3,4,5);
            utvary[3] = new Ctverec(1);


            double obvodTotal = 0;
            double obsahTotal = 0;

            foreach (IUtvary utvar in utvary)
            {
                Console.WriteLine(utvar);
                obvodTotal += utvar.GetObvod();
                obsahTotal += utvar.GetObsah();

            }
            Console.WriteLine(obvodTotal);
            Console.WriteLine(obsahTotal);



            Dictionary<string, int> pocty = new Dictionary<string, int>();
            foreach(IUtvary utvar in utvary)
            {
                if (pocty.ContainsKey(utvar.Nazev))
                    pocty[utvar.Nazev]++;
                else
                    pocty[utvar.Nazev] = 1;
            }

            foreach (var kvp in pocty)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Plechovka plechovka = new Plechovka(4, 0.3);
            foreach (IUtvary utvar in utvary)
            {
                bool uspech = plechovka.Obarvi(utvar);
                Console.WriteLine(uspech);
                Console.WriteLine(plechovka);
            }
        }
    }
}