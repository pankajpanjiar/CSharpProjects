using System;

namespace DelegateDemo
{
    class Program
    {
        //Declare delegate
        public delegate string ReportGenarator(int score);
        static void Main(string[] args)
        {
            //Reference delegate to instance method
            Report report = new Report();
            ReportGenarator invoker = report.GenerateReport;
            Console.WriteLine(invoker.Invoke(56));

            //Reference delegate to static method
            invoker = Report.GenerateReport_Static;
            Console.WriteLine(invoker.Invoke(56));

            //Using Func<> delegate type
            Func<int, string> funcInvoker = Report.GenerateReport_Static;
            Console.WriteLine(funcInvoker.Invoke(54));

            Console.ReadLine();
        }
    }
}
