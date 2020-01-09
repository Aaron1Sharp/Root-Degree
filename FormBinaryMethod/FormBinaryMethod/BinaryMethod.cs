using System;
using System.Collections.Generic;

namespace FormBinaryMethod
{/// <summary>
 /// 
 /// </summary>
    public class BinaryMethod
    {
        /// <summary>
        /// производим цикл в котором число при делении проверяем его  его на остаток на 2
        /// </summary>
        /// <param name="number_decimal"></param>
        /// <returns>вывод цикла но в обратной последовательности</returns>
        public static int SystemMethod(int number_decimal)
        {
            int count = 0;
            List<int> array_binary = new List<int>();
            while (number_decimal > 0)
            {
                count++;
                int temp1 = number_decimal % 2;
                number_decimal /= 2;
                array_binary.Add(temp1);
            }          
            return BackNumberDecimal(array_binary);
        }
        /// <summary>
        /// переворачиваем цикл через лист
        /// </summary>
        /// <param name="final_result"></param>
        /// <returns></returns>
        static int BackNumberDecimal(List<int> final_result)
        {
            int[] array_binary = new int[final_result.Count];
            for (int i = final_result.Count - 1; i >= 0; i--)
            {
                array_binary[final_result.Count - 1 - i] = final_result[i];
            }
            return Convert.ToInt32(string.Join("", array_binary));
        }
    }
}

