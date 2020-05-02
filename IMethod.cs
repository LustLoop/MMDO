using MMDO4.methods;
namespace MMDO4
{
    public interface IMethod 
    {
        Data calculate(double a, double b, double eps);
    }
}