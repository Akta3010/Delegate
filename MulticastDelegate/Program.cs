using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MulticastDelegate
{
    internal class Program
    {
        private delegate void printDelegate(string data);
        static printDelegate printDel = null;

        private delegate int getNum();
        static getNum num = null;
        static void Main(string[] args)
        {
            printDel = new printDelegate(PrintData);
            printDel += PrintDataInUpper;

            printDel("hello");

            num = returnOne;
            num += returnTwo;

            int result = num.Invoke();
            Console.WriteLine(result);
        }

        public static void PrintData(string data)
        {
            Console.WriteLine(data);
        }

        public static void PrintDataInUpper(string data)
        {
            Console.WriteLine(data.ToUpper());
        }

        public static int returnOne()
        {
            Console.WriteLine("returnOne called");
            return 1;
        }
        public static int returnTwo()
        {
            Console.WriteLine("returnTwo called");
            return 2;
        }
    }
}