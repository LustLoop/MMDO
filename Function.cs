namespace MMDO4
{
    public class Function
    {
        private double result;
        public Function(double x)
        {
            result = x * x + 2 * x + 4;
        }

        public double getResult()
        {
            return result;
        }
    }
}