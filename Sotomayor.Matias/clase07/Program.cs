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

            Tempera[] misPinturas = new Tempera[6];

            for (int i = 0; i < misPinturas.Length; i++)
            {
                if(i < 3)
                    misPinturas[i] = new Tempera(ConsoleColor.Black, "marca1", 1);
                else
                    misPinturas[i] = new Tempera(ConsoleColor.DarkCyan, "marca2", 3);
            }

            foreach (Tempera temp in misPinturas)
            {
                Console.WriteLine(temp);
            }

            if (misPinturas[0] == misPinturas[1])
                Console.WriteLine("Son iguales!");
            else
                Console.WriteLine("Son distintas!");

            if (misPinturas[1] != misPinturas[4])
                Console.WriteLine("Son distintas!");
            else
                Console.WriteLine("Son iguales!");

            Console.WriteLine(misPinturas[4] + misPinturas[5]);

            Console.WriteLine(misPinturas[1] + 3);
                        
            Paleta unaPaleta = 3;

            unaPaleta += misPinturas[0];
            unaPaleta += misPinturas[1];
            unaPaleta += misPinturas[2];

            Console.WriteLine(unaPaleta);

            Console.ReadKey();
        }
    }
}
