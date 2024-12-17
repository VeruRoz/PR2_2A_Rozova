namespace zamestanci7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma company = new Firma();

           StalyZamestanec Pepa = new StalyZamestanec("Josef", "Novotný", 28000);
            company.Zamestnej(Pepa);

            StalyZamestanec Karel = new StalyZamestanec("Karel", "Smutný", 27000);
            company.Zamestnej(Karel);

            brigadnik Jarda = new brigadnik("Jaroslav", "Černý");
            company.Zamestnej(Jarda);
            company.Zamestnej(Jarda); //neobjeví se na výplatnici podruhé
            Jarda.Odpracováno = 98;
            Jarda.HodinováMzda = 170;

            dobrovilnik Ivan = new dobrovilnik("Ivan", "Zelenka");
            company.Zamestnej(Ivan);

            company.Vyplata(); //vypíše plat pro Pepu, Jardu a nulu pro Ivana - celkem 71660,- Kč
        }
    }
}