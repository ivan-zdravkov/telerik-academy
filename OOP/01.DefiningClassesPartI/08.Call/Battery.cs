using System;

namespace MobilePhone
{
    class Battery
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string hoursIdle;

        public string HoursIdle
        {
            get { return hoursIdle; }
            set 
            {
                try
                {
                    decimal.Parse(value);
                }
                catch (FormatException ex)
                {
                    throw new Exception("Number expected under hoursIdle on battery!", ex);
                }
                catch (OverflowException ex)
                {
                    throw new Exception("The number for hoursIdle on battery is too big!", ex);
                }
                catch (ArgumentNullException ex)
                {
                    throw new Exception("The number for hoursIdle on battery should not be null!", ex);
                }
                hoursIdle = value; 
            }
        }

        private string hoursTalk;

        public string HoursTalk
        {
            get { return hoursTalk; }
            set 
            {
                try
                {
                    decimal.Parse(value);
                }
                catch (FormatException ex)
                {
                    throw new Exception("Number expected under hoursTalk on battery!", ex);
                }
                catch (OverflowException ex)
                {
                    throw new Exception("The number for hoursTalk on battery is too big!", ex);
                }
                catch (ArgumentNullException ex)
                {
                    throw new Exception("The number for hoursTalk on battery should not be null!", ex);
                }
                hoursTalk = value; 
            }
        }

        private BatteryType batteryType;

        internal BatteryType BatteryType
        {
            get { return batteryType; }
            set { batteryType = value; }
        }

        public Battery(string model, string hoursIdle, string hoursTalk, BatteryType batteryType)
        {
            
                this.model = model;
                try
                {
                    this.hoursIdle = hoursIdle;
                }
                catch (FormatException ex)
                {
                    throw new Exception("Number expected under hoursIdle on battery!", ex);
                }
                catch (OverflowException ex)
                {
                    throw new Exception("The number for hoursIdle on battery is too big!", ex);
                }
                catch (ArgumentNullException ex)
                {
                    throw new Exception("The number for hoursIdle on battery should not be null!", ex);
                }
                try
                {
                    this.hoursTalk = hoursTalk;
                }
                catch (FormatException ex)
                {
                    throw new Exception("Number expected under hoursTalk on battery!", ex);
                }
                catch (OverflowException ex)
                {
                    throw new Exception("The number for hoursTalk on battery is too big!", ex);
                }
                catch (ArgumentNullException ex)
                {
                    throw new Exception("The number for hoursTalk on battery should not be null!", ex);
                }
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

        public void ToString()
        {
            if (this.model != null)
                Console.WriteLine("  model           {0}", this.model);
            if (this.hoursIdle != null)
                Console.WriteLine("  hoursIdle       {0}", this.hoursIdle);
            if (this.hoursTalk != null)
                Console.WriteLine("  hoursTalk       {0}", this.hoursTalk);
            Console.WriteLine("  batteryType     {0}", this.batteryType);
        }
    }
}

    
