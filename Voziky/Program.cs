namespace Voziky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetVoziku = 40;
            int casZacatku = 480;
            int casKonce = 1080;
            int maxZakaznikuZaMinutu = 5;
            int minDobaNakupu = 2;
            int maxDobaNakupu = 30;
            Random rnd = new Random(123456);


            Stack<Cart> carts = new Stack<Cart>();
            List<Cart> odlozene = new List<Cart>();

            for (int i = 1; i <= pocetVoziku; i++)
            {
                Cart cart = new Cart(i);
                carts.Push(cart);
            }

            for (int akutalniCas = casZacatku; akutalniCas <= casKonce; akutalniCas++)
            {
                int PocetZak = rnd.Next(0, maxZakaznikuZaMinutu + 1);

                for (int i = 0; i < PocetZak; i++)
                {
                    if (carts.Count == 0)
                    {
                        Console.WriteLine("košíky došli :(");
                        vypsani(odlozene, carts);
                        return;
                    }
                    int delkaNakupu = rnd.Next(minDobaNakupu, maxDobaNakupu + 1);
                    Cart berousiho = carts.Pop();
                    berousiho.Take(akutalniCas, delkaNakupu);
                    odlozene.Add(berousiho); 
                }

                for(int i = 0; i < odlozene.Count; i++)
                {
                    if (odlozene[i].returnTime == akutalniCas)
                    {
                        odlozene[i].Return();
                        carts.Push(odlozene[i]);
                        odlozene.RemoveAt(i);
                    }
                }
            }
        }

        static void vypsani(List<Cart> odlozene, Stack<Cart> carts)
        {
            for (int i = 0; i < odlozene.Count - 1; i++)
            {
                for (int j = i + 1; j < odlozene.Count; j++)
                {
                    if (odlozene[i].timeSum < odlozene[j].timeSum)
                    {
                        Cart temp = odlozene[i];
                        odlozene[i] = odlozene[j];
                        odlozene[j] = temp;
                    }
                }
            }
            foreach (Cart cart1 in odlozene)
            {
                Console.WriteLine(cart1.timeSum);
            }
            foreach (Cart cart in carts)
            {
                Console.WriteLine(cart.timeSum);
            }
        }
    }

    class Cart
    {
        private int id { get; }
        private bool isBeingUsed { get; set; }
        public int returnTime { get; private set; }
        public int timeSum { get;private set; }

        public Cart(int Id)
        {
            id = Id;
            isBeingUsed = false;
            returnTime = 0;
            timeSum = 0;
        }
        
        public void Take(int time, int takeTime)
        {
            returnTime = time + takeTime;
            isBeingUsed = true;
            timeSum += takeTime;
        }
        public void Return()
        {
            isBeingUsed = false;
            returnTime = 0;
        }
    }
}