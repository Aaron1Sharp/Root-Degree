using System;
using System.Linq;

namespace Convert_decimal_to_binary
{
    class Program
    {
        /// <summary>
        /// Вводим число и на выводе получаем его в двоичной системеа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numberdecimal;
            Console.WriteLine("ввод числа");
            numberdecimal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(BinaryMethod.SystemMethod(numberdecimal)) + " = в двоичной системе");
            Console.ReadKey();
        }
    }


    
    
       
}
