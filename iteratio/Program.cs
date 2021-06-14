using System;

namespace iteratio
{
    class Program
    {
        static void Main(string[] args)
        {
            //определение квадрата числа 
            int n;
            int t;
            int i;
            int r;
            int g;


            Console.WriteLine("Итерация!");
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            t = n;

            for (int a = 0; a < 1; a++)
            {
                Console.WriteLine($"For.Квадрат числа {n} равен {n * n}");
            }

            //цикл do
            Console.WriteLine("Цикл do");
            Console.Write("i = ");
            i = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i > 0);

            //цикл while
            Console.WriteLine("Цикл while");
            Console.Write("r = ");
            r = Convert.ToInt32(Console.ReadLine());

            while (r > 0)
            {
                Console.WriteLine(r);
                r--;
            }

            // цикл foreach
            Console.WriteLine("Цикл foreach");
            Console.Write("g = ");
            g = Convert.ToInt32(Console.ReadLine());

            int[] numbers = { 4, 7, 13, 20, 33, 23, 54 };
            int s = 0;

            foreach (int el in numbers)
            {
                s += el;
            }
            Console.WriteLine(s);
            Console.ReadKey();


        }
    }
}
