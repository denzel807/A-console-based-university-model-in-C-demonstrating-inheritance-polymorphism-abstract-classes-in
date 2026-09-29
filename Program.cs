using System;
using Laba_4;
using лаба1ооп;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Добрый день!");
        University university = new University("СГУПС");

        Console.WriteLine("Добавим сотрудников и студентов в ВУЗ(агрегация)\n");
        Console.WriteLine("Студенты");
        Student student1 = new Student("Данил", new DateTime(2024, 9, 1));
        student1.BirthDate = new DateTime(2006, 9, 30);
        university.AddPerson(student1);
        Student student2 = new Student("Владислав", new DateTime(2024, 9, 1));
        student2.BirthDate = new DateTime(2016, 8, 30);
        university.AddPerson(student2);
        Student student3 = new Student("Пашок", new DateTime(2010, 8, 22));
        student3.BirthDate = new DateTime(2006, 8, 10);
        university.AddPerson(student3);
        Console.WriteLine();
        Console.WriteLine("Преподаватели");
        Teacher teacher1 = new Teacher("Алексей Александрович", new DateTime(1997, 11, 1));
        teacher1.BirthDate = new DateTime(1998, 3, 23);
        university.AddPerson(teacher1);
        Teacher teacher2 = new Teacher("Сергей Евгеньевич", new DateTime(2020, 01, 01), new DateTime(2010, 6, 02));
        university.AddPerson(teacher2);
        Console.WriteLine();
        Console.WriteLine("Библиотекари");
        Librarian librarian1 = new Librarian("Татьяна", new DateTime(1984, 5, 23));
        librarian1.BirthDate = new DateTime(1977, 9, 20);
        university.AddPerson(librarian1);
        Librarian librarian2 = new Librarian("Наталья", new DateTime(2013, 1, 14), new DateTime(1987, 3, 20));
        university.AddPerson(librarian2);
        Console.WriteLine();
        Console.WriteLine("Охранники");
        Security guard1 = new Security("Михалыч", new DateTime(2013, 1, 15));
        guard1.BirthDate = new DateTime(1987, 12, 31);
        university.AddPerson(guard1);
        Security guard2 = new Security("Алексеич", new DateTime(2010, 3, 10), new DateTime(1985, 7, 20));
        university.AddPerson(guard2);

        Parents parents = new Parents();
        university.EndPair += parents.React;
        university.ReactionEndPair();

        Logger logger = new Logger();
        Group group = new Group("БПИ-211", 2);
        group.AddPersonOnGroup += logger.LogAddPersonOnGroup;

        student1.BirthdateChange += logger.LogBirthdateChange;
        student2.BirthdateChange += logger.LogBirthdateChange;

        Console.WriteLine();
        Console.WriteLine("Проверка вместимости группы");

        group.AddStudent(student1);
        group.AddStudent(student2);
        group.AddStudent(student3);

        Console.WriteLine();
        Console.WriteLine("Проверка изменения данных о дате рождения");

        student1.BirthdateChanged(new DateTime(2006, 02, 07));
        student2.BirthdateChanged(DateTime.Today.AddDays(1));

        Console.WriteLine();

        Console.WriteLine("\nИнформация о ВУЗЕ до начала учебного дня:\n");
        university.PrintAllInfo();
        Console.WriteLine("\nНажмите любую клавишу, чтобы начать учебный день");
        Console.ReadKey();
        university.StartingDay();
        Console.WriteLine("\nНажмите любую клавишу, чтобы завершить рабочий день");
        Console.ReadKey();
        university.EndingDay();
        Console.WriteLine("\nИнформация о ВУЗЕ после завершения учебного дня:\n");
        university.PrintAllInfo();


        Console.WriteLine("Нажмите любую клавишу, чтобы поработать с документами...");
        Console.ReadKey();
        university.DoWork();

        Console.WriteLine("Нажмите любую клавишу для учебной эвакуации...");
        Console.ReadKey();
        university.DoEvacuate();

        Console.WriteLine("Нажмите любую клавишу для празднования юбилея...");
        Console.ReadKey();
        university.Celebrate();

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();

    }
}