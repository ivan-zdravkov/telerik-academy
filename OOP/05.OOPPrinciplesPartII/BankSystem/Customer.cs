using System;

namespace BankSystem
{
    public abstract class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Customer (string name, int iD)
        {
            this.Name = name;
            this.ID = iD;
        }
    }
}
