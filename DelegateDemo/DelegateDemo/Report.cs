using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Report
    {
        public string GenerateReport(int score)
        {
            return $"You have scored: {score}";
        }

        public static string GenerateReport_Static(int score)
        {
            return $"You have scored: {score}";
        }

        public void PrintReport(int score) => Console.WriteLine($"You have scored: {score}");
    }
}
