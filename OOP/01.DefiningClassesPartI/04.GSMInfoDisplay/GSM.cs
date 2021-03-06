using System;

namespace MobilePhone
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private string price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string model, string manufacturer, string price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.battery = null;
            this.display = null;
        }

        public GSM()
        {
            this.model = null;
            this.manufacturer = null;
            this.price = null;
            this.owner = null;
            this.battery = null;
            this.display = null;
        }

        public void ToString()
        {
            Console.WriteLine("Model:        {0}", this.model);
            Console.WriteLine("Manufacturer: {0}", this.manufacturer);
            Console.WriteLine("Price:        {0}", this.price);
            Console.WriteLine("Owner:        {0}", this.owner);
            Console.WriteLine("Battery:      {0}", this.battery);
            Console.WriteLine("Display:      {0}", this.display);
        }
    }
}
