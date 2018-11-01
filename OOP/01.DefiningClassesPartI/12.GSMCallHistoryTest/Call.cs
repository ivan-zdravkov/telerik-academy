using System;

namespace MobilePhone
{
    class Call
    {
        private DateTime dateTime;
        private string dialedPhone;

        public string DialedPhone
        {
            get { return dialedPhone; }
        }

        private int seconds;

        public int Seconds
        {
            get { return seconds; }
        }

        public Call(DateTime dateTime, string dialedPhone, int seconds)
        {
            this.dateTime = dateTime;
            this.dialedPhone = dialedPhone;
            this.seconds = seconds;
        }

        public string GetDate()
        {
            return (this.dateTime.Day + "." + this.dateTime.Month + "." + this.dateTime.Year);
        }

        public string GetTime()
        {
            return (this.dateTime.Hour + ":" + this.dateTime.Minute + ":" + this.dateTime.Second);
        }
    }
}
