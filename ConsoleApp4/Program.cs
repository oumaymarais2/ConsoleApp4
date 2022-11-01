using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tab = new int[100];
            int i, n, p = 0, insert;


            Console.Write("Entrer la taille du tableau: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrer {0} elements Dans le Tableau:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} {1} : ", i, n);
                Tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Entrer la valeur a etre inserer: ");
            insert = Convert.ToInt32(Console.ReadLine());
            Console.Write("le tableau existant est  :\n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", Tab[i]);
         
            for (i = 0; i < n; i++)
                if (insert < Tab[i])
                {
                    
                    p = i;
                    break;
                }

            for (i = n; i >= p; i--)
                Tab[i] = Tab[i - 1];

            Tab[p] = insert;

            Console.Write("\n\nApres l'insertion :\n ");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", Tab[i]);
            Console.ReadLine();
        }
    }
}
