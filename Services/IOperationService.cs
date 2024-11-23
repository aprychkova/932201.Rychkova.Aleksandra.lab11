namespace Backend1.Services
{
    public interface IOperationService
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b, out string errorMessage);
    }
}

