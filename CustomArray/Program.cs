using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de números");
            int range = int.Parse(Console.ReadLine());

            int[] nm= new int[range];
            int menor= int.MaxValue;
            int maior=int.MinValue;
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine("Digite o Número " + (i+1) + ": ");
                nm[i] = int.Parse(Console.ReadLine());

                if (nm[i] <= menor) { menor = nm[i]; }
                if (nm[i] >= maior){ maior = nm[i]; }
            }

            Console.Write("Números:");
            for (int i = 0; i < range; i++)
            {
                Console.Write(" "+nm[i]+" ");
                
            }
            Console.WriteLine("\nMaior:"+maior);
            Console.WriteLine("Menor:" + menor);
            Console.ReadKey();








        }
    }
}
