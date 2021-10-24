using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pol = 0;
            int otr = 0;
            int n;
            Console.WriteLine("Введите числа (0 для выхода):");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    pol = pol + 1;
                }

                if (n < 0)
                {
                    otr = otr + 1;
                }

            } while (n != 0);
            Console.WriteLine("кол-во положительных: {0} кол-во отрицательных: {1}", pol, otr);
            Console.ReadKey();
        }
    }
}
