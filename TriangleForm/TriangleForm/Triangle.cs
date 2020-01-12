using System;

namespace TriangleForm
{
    public class Triangle
    {
        public static double FindS(double A, double B, double C)
        {
            double p, S;

            p = FindP(A, B, C) / 2;
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return S;
        }
        public static double FindP(double A, double B, double C) => A + B + C;
    }
}
