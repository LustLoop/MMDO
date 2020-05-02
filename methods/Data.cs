namespace MMDO4.methods
{
    public class Data
    {
        double x;
        double f;
        double Nk;
        double Nf;
        public Data(double x, double f, double Nk, double Nf)
        {
            this.x = x;
            this.f = f;
            this.Nk = Nk;
            this.Nf = Nf;
        }

        public double getX()
        {
            return x;
        }
        public double getF()
        {
            return f;
        }
        public double getNk()
        {
            return Nk;
        }
        public double getNf()
        {
            return Nf;
        }
    }
}