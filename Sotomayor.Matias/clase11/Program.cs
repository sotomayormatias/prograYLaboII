﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase11_ClassLibrary;

namespace clase11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ColectorDeNumeros cn = new ColectorDeNumeros(ETipoNumero.Par);

                Numero n1 = new Numero(Int32.Parse("22"));
                Numero n2 = new Numero(Int32.Parse("-56"));
                Numero n3 = new Numero(Int32.Parse("59"));
                Numero n4 = new Numero(Int32.Parse("-18"));
                Numero n5 = new Numero(Int32.Parse("0"));

                cn += n1;
                cn += n2;
                cn += n3;
                cn += n4;
                cn += n5;

                Console.WriteLine(cn);

                cn -= n3;
                cn -= n4;

                Console.WriteLine(cn);

                Console.ReadLine();

                Console.WriteLine(cn.SumaDeNumeros);
                Console.WriteLine(cn.RestaDeNumeros);
                Console.WriteLine(cn.MultiplicacionDeNumeros);
                Console.WriteLine(cn.DivisionDeNumeros);

                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }

            catch (OverflowException)
            {
                Console.WriteLine("Se te quedo el dedo pegado papu");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadKey();
            }

        }

    }
}
