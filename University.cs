using System;
using System.Collections.Generic;

namespace лаба1ооп
{
    public delegate void EndPair();
    internal class University
    {
        private string name;
        private List<Person> people;
        private List<Room> rooms;
        private List<IDocumentable> documentablePeople;
        private List<IEvacuatable> evacuatableObjects;
        private List<IPerformable> performablePeople;
        private bool isDayActive;

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

        public bool IsDayActive
        {
            get
            {
                return isDayActive;
            }
        }

        public University(string name)
        {
            this.name = name;
            this.people = new List<Person>();
            this.rooms = new List<Room>();
            this.documentablePeople = new List<IDocumentable>();
            this.evacuatableObjects = new List<IEvacuatable>();
            this.performablePeople = new List<IPerformable>();
            this.isDayActive = false;
            AddComputerClass(100);
            AddLectureHall(300);
        }
        public event EndPair EndPair;
        private void CheckSubscription()
        {
            if (EndPair != null)
            {
                EndPair();
            }
        }

        public void ReactionEndPair()
        {
            Console.WriteLine("Пара закончилась");
            CheckSubscription();
        }

        public void AddPerson(Person person)
        {
            people.Add(person);

            if (person is IDocumentable)
            {
                documentablePeople.Add(person as IDocumentable);
            }
            if (person is IEvacuatable)
            {
                evacuatableObjects.Add(person as IEvacuatable);
            }
            if (person is IPerformable)
            {
                performablePeople.Add(person as IPerformable);
            }

            Console.WriteLine($"{person.Name} добавлен в университет");
        }

        private void AddComputerClass(int capacity)
        {
            ComputerClass computerClass = new ComputerClass(capacity);
            rooms.Add(computerClass);
            if (computerClass is IEvacuatable)
            {
                evacuatableObjects.Add(computerClass as IEvacuatable);
            }
            Console.WriteLine($"Компьютерный класс (вместимость: {capacity}, создан в университете");
        }

        private void AddLectureHall(int capacity)
        {
            LectureHall lectureHall = new LectureHall(capacity);
            rooms.Add(lectureHall);
            if (lectureHall is IEvacuatable)
            {
                evacuatableObjects.Add(lectureHall as IEvacuatable);
            }
            Console.WriteLine($"Лекционная аудитория (вместимость: {capacity}, создана в университете");
        }

        public void StartingDay()
        {
            if (isDayActive)
            {
                Console.WriteLine("Учебный день уже начат!");
                return;
            }

            Console.WriteLine($"\nУчебный день начался {name}\n");
            isDayActive = true;

            Console.WriteLine("Присутсвующие в университете");
            foreach (var person in people)
            {
                person.Attend();
            }

            Console.WriteLine("\nАудитории");
            foreach (var room in rooms)
            {
                room.Open();
            }

            Console.WriteLine();
        }

        public void EndingDay()
        {
            if (!isDayActive)
            {
                Console.WriteLine("Учебный день еще не начался!");
                return;
            }

            Console.WriteLine($"\nУчебный день закончился {name}");
            isDayActive = false;

            Console.WriteLine("Персонал и студенты");
            foreach (var person in people)
            {
                person.Relax();
                person.Communicate();
            }

            Console.WriteLine("\n Аудитории");
            foreach (var room in rooms)
            {
                room.Close();
            }

            Console.WriteLine();
        }

        public void PrintAllInfo()
        {
            Console.WriteLine($"\nИнформация об Университете {name}\n");

            string dayStatus;
            if (isDayActive)
            {
                dayStatus = "Учебный день идёт";
            }
            else
            {
                dayStatus = "Учебный день не начался";
            }
            Console.WriteLine($"Статус: {dayStatus}");

            Console.WriteLine("\nПерсонал и учащиеся");
            foreach (var person in people)
            {
                person.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Аудитории");
            foreach (var room in rooms)
            {
                room.PrintInfo();
            }
        }

        public void DoWork()
        {
            Console.WriteLine($"\nРабота с документами в {name} \n");

            foreach (IDocumentable item in documentablePeople)
            {
                item.CreateDocument();
            }
            Console.WriteLine();
        }

        public void DoEvacuate()
        {
            Console.WriteLine($"\nУчебная тревога в {name}! Эвакуация! \n");

            foreach (IEvacuatable item in evacuatableObjects)
            {
                item.Evacuate();
            }

            Console.WriteLine();
        }

        public void Celebrate()
        {
            Console.WriteLine($"\nЮбилей университета {name}!\n");

            foreach (IPerformable item in performablePeople)
            {
                item.Perform();
            }

            Console.WriteLine();
        }
    }
}