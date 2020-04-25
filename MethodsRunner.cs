using System;
using MMDO4.methods;

namespace MMDO4
{
    public class MethodsRunner
    {
        public void run(int a, int b)
        {
            useMethod(new Dichotomy(a, b));
        }

        void useMethod(IMethod method)
        {
            Console.WriteLine(method.calculate());
        }
    }
}