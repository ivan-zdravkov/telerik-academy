using System;

namespace Event
{
    public class Handler
    {
        public Handler(Publisher publisher)
        {
            publisher.RaiseEvent += HandleEvent;
        }

        public static void HandleEvent(object sender, EventArgs args) // The method which handles the raised event
        {
            Console.WriteLine("This is a reaction from the handler, to the publisher's action!");
        }
    }
}
