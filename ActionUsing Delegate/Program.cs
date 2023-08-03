namespace ActionUsing_Delegate
{
    public delegate void eventDelegate(string msg);
    internal class Program
    {       
        public event eventDelegate printData;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.printData = PrintMessage;
            program.process();
        }

        public void process()
        {
            onPrintComplete();
        }

        protected virtual void onPrintComplete()
        {
            printData.Invoke("Print Completed");
        }

        public static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}