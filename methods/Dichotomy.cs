using MMDO4;
using System;

namespace MMDO4.methods
{
    class Dichotomy : IMethod
    {
        public string calculate(double a, double b, double eps)
        {
            Function func = new Function();
            int Nk = 0; 
            double gamma = eps / 3;

            do {
                double x1 = (a + b - gamma) / 2;
                double x2 = (a + b + gamma) / 2;

                double f1 = func.getResult(x1);
                double f2 = func.getResult(x2);

                if (f1 <= f2) 
                {
                    b = x2;
                } 
                else 
                {
                    a = x1;
                }
                Nk++;
            } while (!(b - a < eps));

            double x = (a + b) / 2;
            double f = func.getResult(x);

            return "x* = " + x + ", f* = " + f + ", Nk = " + Nk + ", Nf* = " + func.Nf;
        }
    }
}