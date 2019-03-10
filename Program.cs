using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = new int[4] { 20, 30, 40, 50 };
            int[] arr3 = new int[8] { 100, 200, 300, 400, 500, 600, 700, 800 };

            int menor = 0;

            Console.Write("C1: [");
            foreach (var num in arr1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("]");

            Console.Write("C2: [");
            foreach (var num in arr2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("]");

            Console.Write("C3: [");
            foreach (var num in arr3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("]");

            if (menor == 0)
            {
                if (arr1.Length <= arr2.Length)
                {
                    menor = arr1.Length;
                }
                else
                {
                    menor = arr2.Length;
                }

                if (arr3.Length < menor)
                {
                    menor = arr3.Length;
                }
            }

            int[,] arr4 = new int[menor, 3];
            for (int i = 0; i < menor; i++)
            {
                var x = 0;
                arr4[i, x] = arr1[i];
                x++;
                arr4[i, x] = arr2[i];
                x++;
                arr4[i, x] = arr3[i];

            }

            Console.WriteLine();
            Console.WriteLine("Las combinaciones son: ");
            for (int i = 0; i < menor; i++)
            {
                for (int l= 0; l< 3; l++)
                {
                    Console.Write(arr4[i,l] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("C1 no combinada:[");
            for (int i = menor; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine("]");

            Console.WriteLine();
            Console.Write("C2 no combinada:[");
            for (int i = menor; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine("]");

            Console.WriteLine();
            Console.Write("C3 no combinada:[");
            for (int i = menor; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine("]");

            Console.ReadKey();
        }
    }
}