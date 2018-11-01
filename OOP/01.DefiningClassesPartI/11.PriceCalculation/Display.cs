using System;

namespace MobilePhone
{
    class Display
    {
        private string size;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        private string numberOfColors;

        public string NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }

        public Display(string size, string numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public Display()
        {
            this.size = null;
            this.numberOfColors = null;
        }

        public void ToString()
        {
            if (this.size != null)
                Console.WriteLine("  size:           {0}", this.size);
            if (this.numberOfColors != null)
                Console.WriteLine("  colors:         {0}", this.numberOfColors);
        }
    }
}
