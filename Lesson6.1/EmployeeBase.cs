namespace Lesson6._1
{
    abstract class EmployeeBase
    {
        string _name;
        string _position;

        public abstract string Name { get; set; }

        public abstract string Position { get; set; } 

        public abstract void GetDetails();
    }
}
