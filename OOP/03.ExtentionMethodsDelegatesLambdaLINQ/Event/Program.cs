// 8* Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events and following the best practices.

using System;

namespace Event
{
    public class Program
    {
        static void Main()
        {
            Publisher publisher = new Publisher();
            Handler handler = new Handler(publisher);

            publisher.Action();
        }
    }
}