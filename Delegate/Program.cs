namespace Delegate
{
    internal class Program
    {
        public delegate void printDelegate(string print);
        static printDelegate printDel = printData;
        
        static void Main(string[] args)
        {
            printDel.Invoke("First Delegate");
            printDel("Delegate without Invoke");

            //printDel = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            printDel("Hello World");

            DelegateAsParam(printDel);
        }

        public static void printData(string data)
        {
            Console.WriteLine(data);
        }

        static void DelegateAsParam(printDelegate del)
        {
            del.Invoke("Delegate As Parameter");
        }
    }
}