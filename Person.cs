using System;

namespace лаба1ооп
{
    internal abstract class Person
    {
        protected string name;
        protected DateTime startDate;
        protected DateTime birthDate;

        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            { 
                name = value;
            }
        }

        public int Age
        {
            get
            {
                if (birthDate != DateTime.MinValue)
                    return DateTime.Today.Year - birthDate.Year;
                return 0;
            }
        }

        public DateTime StartDate
        {
            get 
            { 
                return startDate; 
            }
        }

        public DateTime BirthDate
        {
            set
            {
                if (birthDate == DateTime.MinValue)
                {
                    birthDate = value;
                }
            }
        }

        public abstract int Experience 
        { 
            get; 
        }
        public abstract void Attend();
        public abstract void Communicate();
        public abstract void Relax();
        public abstract void PrintInfo();

        protected Person(string name, DateTime startDate)
        {
            this.name = name;
            this.startDate = startDate;
        }

        protected Person(string name, DateTime startDate, DateTime birthDate)
        {
            this.name = name;
            this.startDate = startDate;
            this.birthDate = birthDate;
        }
    }
}
