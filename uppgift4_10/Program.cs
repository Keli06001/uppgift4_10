using System;

namespace uppgift4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp?");
            int o =int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O-mönster per rad?");
            int om=int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int rader=int.Parse(Console.ReadLine());

            string xg = "";
            string og = "";
            string rad = "";

            for (int i = 0; i < x; i++)
            {
                xg = xg + "X";
            }
            for (int i = 0;i < o; i++) 
            { 
                og= og + "O";
            }
            for(int i = 0;i < om; i++)
            {
                rad = rad + xg + "-" + og + "-";
            }
            rad = rad + xg;
            for (int i = 0;i<rader; i++)
            {
                Console.WriteLine(rad);
            }
            Console.ReadKey();
        }
    }
}
