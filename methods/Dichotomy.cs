using MMDO4;

namespace MMDO4.methods
{
    class Dichotomy : IMethod
    {
        //move to interface?
        int a;
        int b;
        public Dichotomy(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public double calculate()
        {
            double middle = (a + b) / 2;
            Function func = new Function(middle);

            return func.getResult();
        }
    }
}