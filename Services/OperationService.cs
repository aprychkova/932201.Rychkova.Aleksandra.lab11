using System;

namespace Backend1.Services
{
    public class OperationService : IOperationService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b, out string errorMessage)
        {
            if (b == 0)
            {
                errorMessage = "Cannot divide by zero.";
                return 0;
            }
            else
            {
                errorMessage = string.Empty;
                return (double)a / b;
            }
        }
    }
}
