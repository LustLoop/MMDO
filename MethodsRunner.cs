using System;
using MMDO4.methods;

namespace MMDO4
{
    public class MethodsRunner
    {
        public void run(double a, double b)
        {
            useMethod(new Dichotomy(), a, b, 0.01);
        }

        void useMethod(IMethod method, double a, double b, double eps)
        {
            Console.WriteLine(method.calculate(a, b, eps));
        }
    }
}