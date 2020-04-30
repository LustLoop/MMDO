using System;
using MMDO4.methods;

namespace MMDO4
{
    public class MethodsRunner
    {
        public void run(double a, double b)
        {
            Console.WriteLine("Dichotomy method:");
            useMethod(new Dichotomy(), a, b, 0.01);
            useMethod(new Dichotomy(), a, b, 0.0001);
            useMethod(new Dichotomy(), a, b, 0.00000001);
            Console.WriteLine();

            // Console.WriteLine("GoldenRatio method:");         
            // useMethod(new GoldenRatio(), a, b, 0.01);
            // useMethod(new GoldenRatio(), a, b, 0.0001);
            // useMethod(new GoldenRatio(), a, b, 0.00000001);
            // Console.WriteLine();

            // Console.WriteLine("Fibonacci method:");
            // useMethod(new Fibonacci(), a, b, 0.01);
            // useMethod(new Fibonacci(), a, b, 0.0001);
            // useMethod(new Fibonacci(), a, b, 0.00000001);
            // Console.WriteLine();

            Console.WriteLine("Parabolas method:");
            useMethod(new Parabolas(), a, b, 0.01);
            useMethod(new Parabolas(), a, b, 0.0001);
            useMethod(new Parabolas(), a, b, 0.00000001);
            Console.WriteLine();
        }

        void useMethod(IMethod method, double a, double b, double eps)
        {
            Console.WriteLine(method.calculate(a, b, eps));
        }
    }
}