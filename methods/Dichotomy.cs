using MMDO4;
using System;

namespace MMDO4.methods
{
    class Dichotomy : IMethod
    {
        public Data calculate(double a, double b, double eps)
        {
            Function func = new Function();

            double x1;
            double x2;

            double f1;
            double f2;

            int Nk = 0; 
            double delta = eps / 3;

            do {
                x1 = (a + b - delta) / 2;
                x2 = (a + b + delta) / 2;

                f1 = func.getResult(x1);
                f2 = func.getResult(x2);

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

            return new Data(x, f, Nk, func.Nf);
        }
    }
}