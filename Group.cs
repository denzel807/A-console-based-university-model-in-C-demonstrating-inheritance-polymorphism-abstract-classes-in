namespace лаба1ооп
{
    public delegate void AddPersonOnGroup(string group_name, int max_capacity);
    internal class Group
    {
        private int _max_capacity;
        private string _name;
        private List<Student> _students = new List<Student>();
        public int Max_Capacity
        {
            get { return _max_capacity; }
            set { _max_capacity = value; }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public event AddPersonOnGroup AddPersonOnGroup;
        public Group(string name, int max_capacity)
        {
            Max_Capacity = max_capacity;
            Name = name;
        }
        private void CheckSubscription()
        {
            if (AddPersonOnGroup != null)
            {
                AddPersonOnGroup(Name, Max_Capacity);
            }

        }
        public void AddStudent(Student student)
        {
            if (_students.Count >=  _max_capacity)
            {
                if (AddPersonOnGroup != null)
                {
                    CheckSubscription();
                }
                return;
            }
            _students.Add(student);
            Console.WriteLine($"Студент {student.Name} добавлен в группу {Name}");
        }
    }
}