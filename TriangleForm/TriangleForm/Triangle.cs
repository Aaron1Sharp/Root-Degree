using System;

namespace TriangleForm
{
    public class Triangle
    {
       public  static double S_Triangle(double A, double B, double C)
        {
            double p, S;

            p = (P_Triangle(A,B,C)) / 2;
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return S;
        }
      public   static double P_Triangle(double A, double B, double C)
        {
            return A + B + C; 
        }
    }
}
