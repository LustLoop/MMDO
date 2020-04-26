using System;

namespace MMDO4
{
    public class Function
    {

        public int Nf;
        public double getResult(double x)
        {
            Nf++;
            return 4 * Math.Pow((3 - x), 2/3) + 2 * Math.Pow(x, 3);
        }
    }
}