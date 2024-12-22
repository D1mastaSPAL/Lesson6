namespace Lesson6._1
{
    class Manager : EmployeeBase
    {
        public override string Name { get; set; }
        public override string Position { get; set; }

        byte _age;

        public byte Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Manager(string name, string position, byte age)
        {
            Name = name;
            Position = position;
            _age = age;
        }

        public Manager() : this("", "", 0)
        {
        }

        public Project projectNested = new Project();

        public override void GetDetails()
        {
            Console.WriteLine($"Имя сотрудника: {Name}, Должность сотрудника: {Position}, Возраст: {Age}, {"\n"}");
        }

        public class Project
        {
            string _projectName;
            string _deadline;

            public string ProjectName
            {
                get { return _projectName; }
                set { _projectName = value; }
            }

            public string Deadline
            {
                get { return _deadline; }
                set {_deadline = value; }
            }
            public void DisplayProjectInfo()
            {
                Console.WriteLine($"Название проекта: {ProjectName}, Срок сдачи проекта: {Deadline} {"\n"}");
            }
        }

    }
}
