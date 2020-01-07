using System;

namespace Convert_decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SystemMethod(4));
            Console.ReadKey();
        }

        static public int SystemMethod(int numberdecimal)
        {
            int count = 1;
            Console.WriteLine(numberdecimal);
            for (; numberdecimal > 0; numberdecimal /= 2, ++count)
            {
                Console.WriteLine();
                if ((numberdecimal % 2) != 0)
                {
                    Console.Write(" 1** =");
                }
                else
                {
                    Console.Write(" 0** =");
                }
                Console.Write(" цикл-- " + count + " --= ");
            }
            return numberdecimal;
        }
    }
}
