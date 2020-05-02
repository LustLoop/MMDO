using System;

namespace MMDO4.methods
{
    public class Localization : IMethod
    {
        public Data calculate(double x0, double h, double eps)
        {
            Function func = new Function();

            double f1 = func.getResult(x0);
            double f2;
            double x1;
            double x2;

            double a = 0;
            double b = 0;
            double x = 0;
            double f = 0;

            do
            {
                h = h / 2.0;
                x2 = x0 + h;
                f2 = func.getResult(x2);
                if(f1 <= f2)
                {
                    h = h * (-1);
                    x2 = x0 + h;
                    f2 = func.getResult(x2);
                }
            } while(!(f1 > f2 || Math.Abs(h) < eps));

            if(Math.Abs(h) > eps)
            {
                do
                {
                    x1 = x2;
                    f1 = f2;
                    x2 = x1 + h;
                    f2 = func.getResult(x2);
                } while(!(f1 < f2));

                if(h > 0)
                {
                    a = x1 - h;
                    b = x2;
                }
                else
                {
                    a = x2;
                    b = x1 - h;
                }

                return calculate(a, h, eps);
            }
            else
            {
                x = x0;
                f = func.getResult(x);

                return new Data(a, b, x, 0);
            }
        }
    }
}