using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N>0:");
            int n = Convert.ToInt32(Console.ReadLine());
            int nk;
            int n2;
            
            for (int i = 1; i <= n; )
            {
                n2 = 0;
                nk = (i * 2) - 1;
                for (int j = 1; j <= nk;)
                {
                    n2 = n2 + j;
                    j = j + 2;
                }
                Console.WriteLine("число {0} квадрат {1}", i, n2);
                i = i + 1;
            }
            Console.ReadKey();

        }
    }
}
