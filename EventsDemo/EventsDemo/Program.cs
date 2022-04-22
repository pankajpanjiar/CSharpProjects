using System;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book
            {
                Id = 1,
                Name = "God of Small Things",
                Author = "Arundhati Roy"
            };
            //Register event handler to the event
            myBook.BookSubmitted += Tasks.BookSubmittedTask.Run;
            myBook.RefundDeposit += Tasks.RefundDepositTask.Run;

            myBook.ReturnBook();

            Console.WriteLine("Hello World!");
        }
    }
}
