using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo.EventArgsModel
{
    public class BookSubmittedEventArgs: EventArgs
    {
        public DateTime SubmittedDate { get; set; }
    }
}
