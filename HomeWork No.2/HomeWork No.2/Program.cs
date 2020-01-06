using System;

namespace homework_No._2
{
    class Calculus
    {
        /// <summary>
        /// 5 = n степень корня, 9 = A число внутри корня
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("корень из 9 в 5 степени = " + SqrtN(5, 9));
            Console.ReadKey();
        }
  
        /// <summary>
        ///     SqrtN = Квадратный корень 
        ///     eps = 0.0001 заданная точность
        ///     Math.Abs = Возвращает абсолютное значение указанного числа.
        ///     Math.Pow = Возвращает указанное число, возведенное в указанную степень.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="A"></param>
        /// <param name="eps"></param>
        /// <returns>
        ///     SqrtN = 1,55184557460721
        /// </returns>
        static public double SqrtN(double n, double A, double eps = 0.0001)
        { 
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));
            }
            return x1;

        }
    }
}
