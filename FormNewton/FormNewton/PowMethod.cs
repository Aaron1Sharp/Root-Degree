using System;

namespace FormNewton
{
    public class PowMethod
    {
        static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }
        public static double MethodNewtonPow(double degree, double radical, double eps = 0.0001)
        {

            var x0 = radical / degree;
            var x1 = (1 / degree) * ((degree - 1) * x0 + radical / Pow(x0, (int)degree - 1));
            if (radical < 0 || degree < 0)
            {
                throw new Exception();
            }
            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / degree) * ((degree - 1) * x0 + radical / Pow(x0, (int)degree - 1));
            }
            return x1;
        }
    }
}

