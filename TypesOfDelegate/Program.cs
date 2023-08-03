namespace TypesOfDelegate
{
    internal class Program
    {
        public static Func<int, int, int> Mul;
        public static Action<int> Print;
        public static Predicate<int> IsNum;
        static void Main(string[] args)
        {
            Mul = multiplication;
            IsNum = IsValidNumber;

            int num1 = 9;
            int num2 = 10;

            if (IsNum(num1) && IsNum(num2))
            {
                int res = Mul(num1, num2);

                Print = PrintResult;
                Print(res);
            }
           
        }

        public static int multiplication(int i, int j)
        {
            return i * j;
        }

        public static void PrintResult(int res)
        {
            Console.WriteLine(res.ToString());
        }

        public static bool IsValidNumber(int num)
        {
            return num >= 0; 
        }
    }
}