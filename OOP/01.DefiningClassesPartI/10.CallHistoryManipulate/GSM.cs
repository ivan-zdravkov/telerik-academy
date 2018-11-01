using System;
using System.Collections.Generic;

namespace MobilePhone
{
    class GSM
    {
        private static GSM iPhone4S;

        internal static GSM IPhone4S
        {
            get { return GSM.iPhone4S; }
            set { GSM.iPhone4S = value; }
        }


        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        private string owner;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        private Battery battery;

        internal Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        private Display display;

        internal Display Display
        {
            get { return display; }
            set { display = value; }
        }

        private List<Call> callHistory;

        public List<Call> GetCallHistory
        {
            get { return callHistory; }
        }

        public Call AddToCallHistory
        {
            set { callHistory.Add(value); }
        }

        public GSM(string model, string manufacturer, string price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.battery = null;
            this.display = null;
            this.callHistory = new List<Call>();
        }

        public GSM()
        {
            this.model = null;
            this.manufacturer = null;
            this.price = null;
            this.owner = null;
            this.battery = null;
            this.display = null;
            this.callHistory = new List<Call>();
        }

        public List<Call> DeleteFromCallHistory(Call call)
        {
            this.callHistory.Remove(call);
            return this.callHistory;
        }

        public List<Call> ClearCallHistory()
        {
            this.callHistory.Clear();
            return this.callHistory;
        }

        public void ToString()
        {
            if (this.model != null)
                Console.WriteLine("Model:            {0}", this.model);
            if (this.manufacturer != null)
                Console.WriteLine("Manufacturer:     {0}", this.manufacturer);
            if (this.price != null)
                Console.WriteLine("Price:            {0}", this.price);
            if (this.owner != null)
                Console.WriteLine("Owner:            {0}", this.owner);
            Console.WriteLine("Battery:          ");
            this.battery.ToString();
            Console.WriteLine("Display:          ");
            this.display.ToString();
        }
    }
}
