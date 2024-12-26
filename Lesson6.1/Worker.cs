namespace Lesson6._1;

class Worker : EmployeeBase
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

    public Worker() : this("", "", 0, "")
    {
    }

    public Worker(string name, string position, byte age, string surname)
    {
        Name = name;
        Position = position;
        _age = age;
        _surname = surname;
    }

    public override void GetDetails()
    {
        Console.WriteLine($"Имя сотрудника: {Name}, Фамилия сотрудника: {Surname}, Возраст: {Age}, Должность сотрудника: {Position} {"\n"}");
    }
}
