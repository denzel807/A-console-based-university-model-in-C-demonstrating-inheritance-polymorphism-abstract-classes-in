using System;
using лаба1ооп;

namespace лаба1ооп
{
    internal class Teacher : Person, IDocumentable, IEvacuatable, IPerformable
    {
        public string YearEnding
        {
            get
            {
                int lastDigit = Experience % 10;
                int lastTwoDigits = Experience % 100;

                if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
                    return "лет";
                if (lastDigit == 1)
                    return "год";
                else if (lastDigit == 2 || lastDigit == 3 || lastDigit == 4)
                    return "года";
                else
                    return "лет";
            }
        }
        public override int Experience
        {
            get
            {
                return DateTime.Today.Year - startDate.Year;
            }
        }
        public Teacher(string name, DateTime startDate) : base(name, startDate)
        {

        }
        public Teacher(string name, DateTime startDate, DateTime birthDate) : base(name, startDate, birthDate)
        {

        }

        public override void Attend()
        {
            Console.WriteLine($"{name} проводит занятия");
        }

        public override void Communicate()
        {
            Console.WriteLine($"{name} общается c коллегами и студентами");
        }

        public override void Relax()
        {
            Console.WriteLine($"{name} отдыхает");
        }
        public void CreateDocument()
        {
            Console.WriteLine($"Преподаватель {name} создаёт учебный план");
        }
        public void Evacuate()
        {
            Console.WriteLine($"Преподаватель {name} организует эвакуацию студентов");
        }
        public void Perform()
        {
            Console.WriteLine($"Преподаватель {name} произносит торжественную речь на юбилее");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Преподаватель: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Стаж: {Experience} {YearEnding}");
        }
    }
}