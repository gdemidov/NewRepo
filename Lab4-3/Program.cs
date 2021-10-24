using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A(13) B(6) C(2):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int i = 0;//счетчик квадратов по стороне А
            int j = 0;//счетчик квадратов по стороне В
            int ci = c;
            int cj = c;
            while (ci <= a)
            {
                ci = ci+c;
                i++;
            }
            while (cj <= b)
            {
                cj = cj+c;
                j++;
            }
            Console.WriteLine("всего квадратов по стороне А(6) {0}",i);
            Console.WriteLine("всего квадратов по стороне В(3) {0}",j); 
            Console.WriteLine("всего квадратов (18) {0}",(i*j));
            Console.ReadKey();
        }
    }
}
