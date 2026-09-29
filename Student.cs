using System;
using лаба1ооп;

namespace лаба1ооп
{
    internal delegate void BirthDateChange(Student student, bool success);
    internal class Student : Person, IDocumentable, IEvacuatable, IPerformable
    {
        public string Ending
        {
            get
            {
                int lastDigit = Experience % 10;
                int lastTwoDigits = Experience % 100;
                if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
                    return "ов";
                if (lastDigit == 1)
                    return "";
                else if (lastDigit == 2 || lastDigit == 3 || lastDigit == 4)
                    return "а";
                else
                    return "ов";
            }
        }

        public override int Experience
        {
            get
            {
                return (DateTime.Today - startDate).Days / 180;
            }
        }

        public Student(string name, DateTime startDate) : base(name, startDate)
        {
        }

        public Student(string name, DateTime startDate, DateTime birthDate) : base(name, startDate, birthDate)
        {
        }

        public override void Attend()
        {
            Console.WriteLine($"{name} посещает занятия");
        }

        public override void Communicate()
        {
            Console.WriteLine($"{name} общается с другими студентами");
        }

        public override void Relax()
        {
            Console.WriteLine($"{name} отдыхает и играет в доту");
        }
        public void CreateDocument()
        {
            Console.WriteLine($"Студент {name} создаёт курсовую работу");
        }
        public void Evacuate()
        {
            Console.WriteLine($"Студент {name} эвакуируется согласно плану");
        }
        public void Perform()
        {
            Console.WriteLine($"Студент {name} выступает с творческим номером на юбилее");
        }
        public event BirthDateChange BirthdateChange;

        public void BirthdateChanged(DateTime newBirthdate)
        {
            bool success = false;

            if (newBirthdate != DateTime.MinValue && newBirthdate <= DateTime.Today)
            {
                BirthDate = newBirthdate;
                success = true;
            }
            if (BirthdateChange != null)
            {
                BirthdateChange(this, success);
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Студент: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Стаж: {Experience} семестр{Ending}");

        }
    }
}