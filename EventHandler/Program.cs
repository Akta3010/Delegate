namespace EventHandlerLearn
{

    internal class Program
    {
        static void Main(string[] args)
        {
            PrintProcess printProcess = new PrintProcess();
            printProcess.printEvent += printProcessComplete;
            printProcess.PrintData();
        }

        public static void printProcessComplete(object sender, processEventArgs e)
        {
            Console.WriteLine(e.IsSuccessful.ToString());
            Console.WriteLine("Process Completed!");
        }


    }

    public class PrintProcess
    {
        public event EventHandler<processEventArgs> printEvent;
        processEventArgs eventArgs = new processEventArgs();
        public void PrintData()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}");
            }
            eventArgs.IsSuccessful = true;
            OnProcessComplete(eventArgs);
        }

        protected virtual void OnProcessComplete(processEventArgs e)
        {
            printEvent?.Invoke(this,e);
        }
    }

    public class processEventArgs : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}