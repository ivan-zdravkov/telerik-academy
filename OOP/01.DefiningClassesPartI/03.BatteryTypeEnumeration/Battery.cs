using System;

namespace MobilePhone
{
    class Battery
    {
        private string model;
        private string hoursIdle;
        private string hoursTalk;
        private BatteryType batteryType;

        public Battery(string model, string hoursIdle, string hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = null;
            this.hoursTalk = null;
            this.batteryType = 0;
        }

        public Battery()
        {
            this.model = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
            this.batteryType = 0;
        }
    }
}

    
