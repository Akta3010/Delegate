namespace GenericDelegate
{
    internal class Program
    {
        public delegate T add<T>(T param1, T param2); // generic delegate
        static void Main(string[] args)
        {
            add<int> sum = Sum;
            int res = sum(2, 3);
            Console.WriteLine(res.ToString());

            add<string> concate = Concat;
            string con = concate("Hello","World");
            Console.WriteLine(con.ToString());
        }

        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}