using System;

namespace лаба1ооп
{
    internal class Security : Person, IPerformable
    {
        public override int Experience
        {
            get
            {
                return DateTime.Today.Year - startDate.Year;
            }
        }
        public Security(string name, DateTime startDate) : base(name, startDate)
        {

        }
        public Security(string name, DateTime startDate, DateTime birthDate) : base(name, startDate, birthDate)
        {

        }
        public override void Attend()
        {
            Console.WriteLine($"{name} заступает на пост");
        }

        public override void Communicate()
        {
            Console.WriteLine($"{name} общается");
        }

        public override void Relax()
        {
            Console.WriteLine($"{name} отдыхает, читает книги");
        }
        public void Perform()
        {
            Console.WriteLine($"Охранник {name} обеспечивает порядок на юбилее");
            }
        public override void PrintInfo()
        {
            Console.WriteLine($"Охранник: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Стаж: {Experience} дней");
        }
    }
}