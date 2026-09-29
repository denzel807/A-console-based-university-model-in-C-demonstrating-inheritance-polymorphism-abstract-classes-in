using System;

namespace лаба1ооп
{
    internal class ComputerClass : Room, IEvacuatable
    {

        public ComputerClass(int capacity) : base(capacity)
        {
        }

        public override void Open()
        {
            isOpen = true;
            Console.WriteLine($"Компьютерный класс открыт. Вместимость: {capacity} человек.");
        }

        public override void Close()
        {
            isOpen = false;
            Console.WriteLine("Компьютерный класс закрыт");
        }

        public override void PrintInfo()
        {
            string status;
            if (isOpen)
            {
                status = "открыт";
            }
            else
            {
                status = "закрыт";
            }

            Console.WriteLine($"Компьютерный класс: вместимость {capacity} чел., статус: {status}");
        }
        public void Evacuate()
        {
            Console.WriteLine($"В компьютерном классе загорается табличка «ВЫХОД»");
        }
    }
}