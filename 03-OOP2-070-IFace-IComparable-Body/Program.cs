﻿//using static _03_OOP2_070_IFace_IComparable_Body.Interfaces;

namespace _03_OOP2_070_IFace_IComparable_Body
{
   
        namespace Interfaces
    {

        class Program
        {
            public static void Main(string[] args)
            {

                Bod[] body =
                {
            new Bod(0, 1),
            new Bod(2, 0),
            new Bod(0, 0),
            new Bod(1, 1),
        };

                Array.Sort(body);

                foreach (Bod bod in body)
                {
                    Console.WriteLine(bod);
                }
            }
        }
    }
}