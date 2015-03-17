namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private const int DefaultWorkHoursPerDay = 8;
        private const int DefaultMoneyPerHour = 5;

        private int weekSalary;
        private int workHoursPerDay;
        private int moneyPerHour;

        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WorkHoursPerDay = DefaultWorkHoursPerDay;
            this.MoneyPerHour = DefaultMoneyPerHour;
        }

        public Worker(string firstName, string lastName, int workHoursPerDay, int monryPerHour)
            : this(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WorkHoursPerDay = workHoursPerDay;
            this.MoneyPerHour = moneyPerHour;
        }

        public int MoneyPerHour
        {
            get
            {
                return this.moneyPerHour;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid money per hour value");
                }

                this.moneyPerHour = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentException("Invalid work hours per day value");
                }

                this.workHoursPerDay = value;
            }
        }

        public int MyProperty
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid week salary value");
                }

                this.weekSalary = value;
            }
        }
    }
}
