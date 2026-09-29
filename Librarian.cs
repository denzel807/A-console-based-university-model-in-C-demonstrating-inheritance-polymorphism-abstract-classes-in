using System;

namespace лаба1ооп
{
    internal class Librarian : Person, IPerformable
    {
        public override int Experience
        {
            get
            {
                return 12 * (DateTime.Today.Year - startDate.Year);
            }
        }
        public Librarian(string name, DateTime startDate) : base(name, startDate)
        {

        }
        public Librarian(string name, DateTime startDate, DateTime birthDate) : base(name, startDate, birthDate)
        {

        }
        public override void Attend()
        {
            Console.WriteLine($"{name} работает в библиотеке");
        }

        public override void Communicate()
        {
            Console.WriteLine($"{name} общается с подругой");
        }

        public override void Relax()
        {
            Console.WriteLine($"{name} отдыхает, возможно читает книги");
        }
        public void Perform()
        {
            Console.WriteLine($"Библиотекарь {name} организует выставку книг к юбилею");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Библиотекарь: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Стаж: {Experience} месяцев");
        }
    }
}