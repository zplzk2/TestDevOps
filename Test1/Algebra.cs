namespace Test1
{
    public class Algebra
    {
        public long Add(int num1, int num2)
        {
            return (long)num1 + (long)num2;
            //return num1 + num2;
        }

        public long Sub(int num1, int num2)
        {
            //return (long)num1 - (long)num2;
            return num1 - num2;
        }

        public long Multi(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Divide(int num1, int num2)
        {
            // TODO: Handle DivideByZeroException
            return num1 / num2;
        }
    }
}
