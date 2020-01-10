using System;

namespace AlgorithmEuclidean
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstfirstnumber;
            int secondnumber;
            Console.WriteLine("введите число 1 ");
            firstfirstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число 2 ");
            secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write(AlgorithmEuclidean.EuclideanMethod(firstfirstnumber,secondnumber));
            Console.ReadKey();
        }
    }
}
