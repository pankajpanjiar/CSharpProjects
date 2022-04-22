using EventsDemo.EventArgsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo.Tasks
{
    public class BookSubmittedTask
    {
        public static void Run(object sender, BookSubmittedEventArgs e)
        {
            var book = (Book)sender;
            Console.WriteLine($"Book '{book.Name} by {book.Author}' submitted on: {e.SubmittedDate}");

            book.InitiateRefund();
        }
    }
}
