using System;

namespace MobilePhone
{
    class Call
    {
        private DateTime dateTime;
        private string dialedPhone;
        private int seconds;

        public Call(DateTime dateTime, string dialedPhone, int seconds)
        {
            this.dateTime = dateTime;
            this.dialedPhone = dialedPhone;
            this.seconds = seconds;
        }

        public string GetDate()
        {
            return this.dateTime.Day.ToString();
        }

        public string GetTime()
        {
            return this.dateTime.TimeOfDay.ToString();
        }
    }
}
