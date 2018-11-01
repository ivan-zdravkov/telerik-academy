using System;

namespace Event
{
    public class Publisher : EventArgs
    {
        public event EventHandler RaiseEvent;

        public void Action() // The method that is raising the event
        {
            Console.WriteLine("This is the action the publisher is executing!");
            OnRaise();
        }

        protected virtual void OnRaise()
        {
            if (this.RaiseEvent != null)
            {
                this.RaiseEvent(this, null);
            }
        }
    }
}
