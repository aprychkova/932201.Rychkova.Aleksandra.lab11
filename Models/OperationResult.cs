
namespace Backend1.Models
{
    public class OperationResult
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string? Operation { get; set; }
        public double Result { get; set; }
        public string? ErrorMessage { get; set; }
        public double AddResult { get; set; }
        public double SubtractResult { get; set; }
        public double MultiplyResult { get; set; }
        public double DivideResult { get; set; }
    }
}