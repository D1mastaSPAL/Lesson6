namespace Lesson6._1;

class Manager : EmployeeBase
{
    public override string Name { get; set; }
    public override string Position { get; set; }

    string _surname;
    byte _age;

    public byte Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }

    public Manager(string name, string position, byte age, string surname)
    {
        Name = name;
        Position = position;
        _age = age;
        _surname = surname;
    }

    public Manager() : this("", "", 0, "")
    {
    }

    Project projectNested = new Project();

    public override void GetDetails()
    {
        Console.WriteLine($"Имя сотрудника: {Name}, Фамилия сотрудника: {Surname}, Возраст: {Age}, Должность сотрудника: {Position} {"\n"}");
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

        public Project(string projectName, string deadline)
        {
            _projectName = projectName;
            _deadline = deadline;
        }

        public Project() : this("", "")
        {
        }

        public void DisplayProjectInfo()
        {
            Console.WriteLine($"Название проекта: {ProjectName}, Срок сдачи проекта: {Deadline} {"\n"}");
        }
    }
}
