using EventsDemo.EventArgsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public event EventHandler<BookSubmittedEventArgs> BookSubmitted;

        protected virtual void OnBookSubmitted(BookSubmittedEventArgs e)
        {
            EventHandler<BookSubmittedEventArgs> bookSubmittedHandler = BookSubmitted;
            bookSubmittedHandler?.Invoke(this, e);
        }

        public event EventHandler RefundDeposit;

        protected virtual void OnRefundDeposit(EventArgs e)
        {
            EventHandler refundDepositHandler = RefundDeposit;
            refundDepositHandler?.Invoke(this, e);
        }

        public void ReturnBook()
        {
            Console.WriteLine($"Return processing started for book '{this.Name} by {this.Author}'.");

            BookSubmittedEventArgs e = new BookSubmittedEventArgs
            {
                SubmittedDate = DateTime.Now
            };

            this.OnBookSubmitted(e);
        }

        public void InitiateRefund()
        {
            Console.WriteLine($"Refund of deposit initiated for book '{this.Name} by {this.Author}'.");

            this.OnRefundDeposit(null);
        }
    }
}
