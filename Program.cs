﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMA_4
{
    class PROGRAMA4
    {
        public int A = 0;
        public int B = 0;
        public int C = 0;

        public void Ingresar()
        {
            Console.WriteLine("Dame el valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de C: ");
            C = int.Parse(Console.ReadLine());
        }

        public void Proceso()
        {
            if (A > B && B>C)
            {
                Console.WriteLine("A es mayor");
            }
            else
            {
                if (B>C)
                {
                    Console.WriteLine("B es mayor");
                }
                else
                {
                    Console.WriteLine("C es mayor");
                }
            }

        }

        static void Main(string[] args)
        {
            PROGRAMA4 figura1 = new PROGRAMA4();
            figura1.Ingresar();
            figura1.Proceso();
            Console.ReadKey();
        }
    }
}
