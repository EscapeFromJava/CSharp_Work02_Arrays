using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Work02_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0;
            for (int i = 100; i < 500; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма всех целых чисел = {0}", sum);

            Console.Write("Введите А: ");
            a = Convert.ToInt32(Console.ReadLine());
            while (a >= 500) {
                Console.Write("Введите А: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            sum = 0;
            for (int i = a; i < 500; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма всех целых чисел от A={0} до 500 = {1}", a, sum);

            Console.Write("Введите B: ");
            b = Convert.ToInt32(Console.ReadLine());
            while (b <= -10)
            {
                Console.Write("Введите B: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            sum = 0;
            for (int i = -10; i < b; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма всех целых чисел от -10 до B={0} = {1}", b, sum);

            sum = 0;
            if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Сумма всех целых чисел от A={0} до B={1} = {2}", a, b, sum);
            }
            else
            {
                for (int i = b; i < a; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Сумма всех целых чисел от A={0} до B={1} = {2}", a, b, sum);
            }

            Console.ReadKey();
        }
    }
}
