using System;

namespace StudentWorder
{
    class Worker : Human
    {
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }

        public Worker(string fName, string lName, double weekSalary, double workHoursPerDay) : base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return ((this.WeekSalary / 7) / this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            string space = new String(' ', 26);
            return String.Format("{0,12} {1,-12} Money per hour: {2:0.00}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
