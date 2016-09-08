using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera temp1 = new Tempera(ConsoleColor.Red, "marca1", 10);
            Tempera temp2 = new Tempera(ConsoleColor.White, "marca1", 5);
            Tempera temp3 = new Tempera(ConsoleColor.Green, "marca1", 20);
            Tempera temp4 = new Tempera(ConsoleColor.Green, "marca1", 5);
            Tempera temp5 = new Tempera(ConsoleColor.Yellow, "marca1", 10);
            Tempera temp6 = new Tempera(ConsoleColor.Red, "marca1", 10);
            
            Paleta paleta1 = 4;

            paleta1 += temp1;
            paleta1 += temp2;
            paleta1 += temp3;

            Paleta paleta2 = 3;

            paleta2 += temp4;
            paleta2 += temp5;
            paleta2 += temp6;

            Paleta paletaSuma = paleta1 + paleta2;

            Console.WriteLine((string)paletaSuma);

            Console.ReadKey();
        }
    }
}
