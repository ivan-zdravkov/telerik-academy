using System;

namespace MobilePhone
{
    class Display
    {
        private string size;
        private string numberOfColors;

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
    }
}
