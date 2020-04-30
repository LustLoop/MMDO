using System;

namespace MMDO4.methods
{
    public class GoldenRatio : IMethod
    {
        public string calculate(double a, double b, double eps)
        {
            Function func = new Function();
            int Nk = 0; 

            double u = a + (3 - Math.Sqrt(5)) / 2 * (b - a);
            double v = a + b - u;
            double fu = func.getResult(u);
            double fv = func.getResult(v);

            do {
                if(fu <= fv)
                {
                    b = v;
                    v = u;
                    fv = fu;
                    u = a + b - v;
                    fu = func.getResult(u);
                }
                else
                {
                    a = u;
                    u = v;
                    fu = fv;
                    v = a + b - u;
                    fv = func.getResult(v);
                }
                if(u > v)
                {
                    u = a + (3 - Math.Sqrt(5)) / 2 * (b - a);
                    v = a + b - u;
                    fu = func.getResult(u);
                    fv = func.getResult(v);
                }
                Nk++;
            } while (!(b - a < eps));

            double x = (a + b) / 2;
            double f = func.getResult(x);

            return "x* = " + x + ", f* = " + f + ", Nk = " + Nk + ", Nf* = " + func.Nf + " while eps = " + eps;
        }
    }
}