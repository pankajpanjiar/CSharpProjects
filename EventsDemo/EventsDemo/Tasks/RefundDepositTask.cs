using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo.Tasks
{
    public class RefundDepositTask
    {
        public static void Run(object sender, EventArgs e)
        {
            var book = (Book)sender;
            Console.WriteLine($"Refund of deposit for book '{book.Name} by {book.Author}' completed successfull on: {DateTime.Now}");
        }
    }
}
