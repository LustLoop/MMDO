using System;
using MMDO4.methods;

namespace MMDO4
{
    public class MethodsRunner
    {
        public void run(double a, double b)
        {
            useMethod(new Dichotomy(), a, b, 0.01);
            useMethod(new Dichotomy(), a, b, 0.0001);
            useMethod(new Dichotomy(), a, b, 0.00000001);
            
            useMethod(new GoldenRatio(), a, b, 0.01);
            useMethod(new GoldenRatio(), a, b, 0.0001);
            useMethod(new GoldenRatio(), a, b, 0.00000001);

            useMethod(new Fibonacci(), a, b, 0.01);
            useMethod(new Fibonacci(), a, b, 0.0001);
            useMethod(new Fibonacci(), a, b, 0.00000001);
        }

        void useMethod(IMethod method, double a, double b, double eps)
        {
            Console.WriteLine(method.calculate(a, b, eps));
        }
    }
}