using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese filas: ");
            int f = int.Parse(Console.ReadLine());

            Console.Write("Ingrese columnas: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f,c];
            Random rand = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(30, 51);
                    Console.Write(matriz[i,j] + "\t");
                } 
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
