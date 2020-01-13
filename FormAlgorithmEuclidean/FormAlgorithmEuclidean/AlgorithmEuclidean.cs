using System;
using System.Diagnostics;

namespace FormAlgorithmEuclidean
{
    public class AlgorithmEuclidean
    {
        public static int EuclideanMethod(int firstnumber, int secondnumber)
        {
            if (firstnumber == 0)
                return secondnumber;

            if (secondnumber == 0)
                return firstnumber;

            int NOD;

            for (NOD = 0; ((firstnumber | secondnumber) & 1) == 0; ++NOD)
            {
                firstnumber >>= 1;
                secondnumber >>= 1;
            }

            while ((firstnumber & 1) == 0)
            {
                firstnumber >>= 1;
            }
            
            do
            {
                while ((secondnumber & 1) == 0)
                    secondnumber >>= 1;
                if (firstnumber > secondnumber)
                {
                    int temp = firstnumber;
                    firstnumber = secondnumber;
                    secondnumber = temp;
                }
                secondnumber -= firstnumber;
                    
            }

            while (secondnumber != 0);
            {
                return firstnumber << NOD;
            }
        }
    }   
}

