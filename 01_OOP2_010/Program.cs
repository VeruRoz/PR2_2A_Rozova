namespace _01_OOP2_010
{
    internal class Program
    {
        static void Main(string[] args) 
        {
           
        }
        class Obdelník
        {
            public int StranaA { get; private set; }   
            public int StranaB { get; private set; } 


            public void Obdelnik(int stranaA, int stranaB)
            {
                StranaA = stranaA;
                StranaB = stranaB;
            }
            public int Obsah()
            {
                int obsah = StranaA *StranaB;
                return obsah;
            }

            public int Obvod()
            {
                int obvod = (StranaA + StranaA)*2;
                return obvod;
            }
            public override string ToString()
            {
                return $"Obdelnik: Strana A = {StranaA}, Strana B = {StranaB}, Obvod = {Obvod()}, Obsah = {Obsah()}";
            }
        }
        class Čtverec:Obdelník
        {
            public int StranaA { get; private set; }
            public int StranaB { get; private set; }
            public void Ctverec(int stranaA)
            {
                StranaA = stranaA;
                StranaB = stranaA;
            }

        }
    }
}