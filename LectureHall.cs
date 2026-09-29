using System;

namespace лаба1ооп
{
    internal class LectureHall : Room, IEvacuatable
    {

        public LectureHall(int capacity) : base(capacity)
        {
        }

        public override void Open()
        {
            isOpen = true;
            Console.WriteLine($"Лекционная аудитория открыта. Вместимость: {Capacity} человек");
        }

        public override void Close()
        {
            isOpen = false;
            Console.WriteLine("Лекционная аудитория закрыта");
        }

        public override void PrintInfo()
        {
            string status;
            if (isOpen)
            {
                status = "открыта";
            }
            else
            {
                status = "закрыта";
            }

            Console.WriteLine($"Лекционная аудитория: вместимость {Capacity} чел., статус: {status}");
        }
        public void Evacuate()
        {
            Console.WriteLine($"В лекционной аудитории загорается табличка «ВЫХОД»");
        }
    }
}