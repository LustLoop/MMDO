using System;

namespace MMDO4.methods
{
    public class Fibonacci : IMethod
    {
        public Data calculate(double a, double b, double eps)
        {
            Function func = new Function();
            int Nk = 0;
            int n = findN(a, b, eps);

            double u = a + getFibonacci(n) / getFibonacci(n + 2) * (b - a);
            double v = a + b - u;
            double fu = func.getResult(u);
            double fv = func.getResult(v);

            for(int i = 1; i <= n; i++)
            {
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
                    u = a + getFibonacci(n - i + 1) / getFibonacci(n - i + 3) * (b - a);
                    v = a + b - u;
                    fu = func.getResult(u);
                    fv = func.getResult(v);
                }
                Nk++;
            }

            double x = (a + b) / 2.0;
            double f = func.getResult(x);

            return new Data(x, f, Nk, func.Nf);
        }

        private int findN(double a, double b, double eps)
        {
            int n = 1;

            while((b - a) / getFibonacci(n + 2) > eps)
            {
                n++;                
            }

            return n;
        } 

        private double getFibonacci(int n)
        {
            if(n > 1)
            {
                return getFibonacci(n - 2) + getFibonacci(n - 1);        
            }      
            return 1;      
        }
    }
}