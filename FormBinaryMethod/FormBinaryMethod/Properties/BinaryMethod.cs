using System;
using System.Collections.Generic;

namespace Convert_decimal_to_binary
{
    /// <summary>
    /// 
    /// </summary>
    public class BinaryMethod
    { 
        /// <summary>
        /// производим цикл в котором число при делении проверяем его  его на остаток на 2
        /// </summary>
        /// <param name="numberdecimal"></param>
        /// <returns>вывод цикла но в обратной последовательности</returns>
        public static int SystemMethod(int numberdecimal)
        { 
            int count = 0;
            List<int> s = new List<int>();
                    while (numberdecimal > 0)
                    {
                        count++;
                        int temp1 = numberdecimal % 2;
                
                        if ((numberdecimal % 2) != 0) // = false
                        {
                            Console.Write("1");
                        }
                        else
                        {
                            Console.Write("0");
                        }
                        numberdecimal /= 2;
                        s.Add(temp1);
                    }
            Console.WriteLine(" > количество циклов = " + count);
            Console.WriteLine("производим обратную запись. . .");
            return ObratNumberDecimal(s);
        }
        /// <summary>
        /// переворачиваем цикл через лист
        /// </summary>
        /// <param name="finalresult"></param>
        /// <returns></returns>
        static int ObratNumberDecimal(List<int> finalresult)
        {
            int[]s = new int[finalresult.Count];
            for (int i = finalresult.Count - 1; i >= 0; i--)
            {
                s[finalresult.Count - 1 - i] = finalresult[i];
            }
           
            return Convert.ToInt32(string.Join("", s));
        }
    }
    
}
