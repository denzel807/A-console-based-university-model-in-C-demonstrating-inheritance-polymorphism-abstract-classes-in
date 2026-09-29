using лаба1ооп;

namespace Laba_4;

internal class Logger
{
    public void LogAddPersonOnGroup(string group_name, int max_capacity)
    {
        Console.WriteLine($"В группу {group_name} хотят перевести ученика, но в этой группе уже обучаются {max_capacity} студента");
    }

    public void LogBirthdateChange(Student student, bool success)
    {
        if (success)
        {
            Console.WriteLine($"Дата рождения студента {student.Name} была записана");
        }
        else
        {
            Console.WriteLine($"Дата рождения у студента {student.Name} не была изменена");
        }
        
    }
}
