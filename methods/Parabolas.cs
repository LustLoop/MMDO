using System;
using MMDO4.methods;

namespace MMDO4.methods
{
    public class Parabolas : IMethod
    {
        public Data calculate(double a, double b, double eps)
        {
            Function func = new Function();
            int Nk = 0;
            bool flag = false;

            IMethod loc = new Localization();
            Data data = loc.calculate(0, 0.1, 0.01);

            double x0 = a;
            double x1 = data.getNk();
            double x2 = b;

            double f0 = func.getResult(x0);
            double f1 = func.getResult(x1);
            double f2 = func.getResult(x2);
            double x3 = 0;
            double f3 = 0;
            double x = 0;
            double f = 0;

            while(!flag)
            {
                x = (x0 + x1) / 2.0 + (f1 - f0) * (x2 - x0) * (x2 - x1) / (2 * ((f1 - f0) * (x2 - x0) - (f2 - f0) * (x1 - x0)));
                f = func.getResult(x);
                
                if (Math.Abs(x1 - x) >= eps && Math.Abs(x2 - x) >= eps)
                {
                    flag = false; 

                    if(x < x1)
                    {
                        x3 = x2;
                        f3 = f2;
                        x2 = x1;
                        f2 = f1;
                        x1 = x;
                        f1 = f;
                    }   
                    else
                    {
                        if(x > x1)
                        {
                            x3 = x2;
                            f3 = f2;
                            x2 = x;
                            f2 = f;
                        }
                    } 
                    if(f1 > f2) 
                    {
                        x0 = x1;
                        f0 = f1;
                        x1 = x2;
                        f1 = f2;
                        x2 = x3;
                        f2 = f3;
                    }
                }
                else
                {
                    flag = true;
                }
                Nk++;
            }

            return new Data(x, f, Nk, func.Nf);
        }     
    }
}