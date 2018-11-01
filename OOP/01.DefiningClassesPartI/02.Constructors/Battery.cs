using System;

namespace MobilePhone
{
    class Battery
    {
        private string model;
        private string hoursIdle;
        private string hoursTalk;

        public Battery(string model, string hoursIdle, string hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }

        public Battery()
        {
            this.model = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
    }
}

    
