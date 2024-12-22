namespace Lesson6._1
{
    static class EmployeeRegistry
    {

        private static EmployeeBase[] ArrayEmployees = new EmployeeBase[50];

        static int lastIndex = -1;

        public static void AddEmployee(EmployeeBase employee)
        {
            lastIndex += 1;
            ArrayEmployees[lastIndex] = employee;
        }

        public static void ListAllEmployees()
        {
            for (int i = 0; i <= lastIndex; i++)
            {
                ArrayEmployees[i].GetDetails();
            }
        }

        public static void FindEmployee(string name)
        {
            var result = Array.Find(ArrayEmployees, _ => _ != null && _.Name.Equals(name, StringComparison.Ordinal));
            Console.WriteLine("Вы нашли сотрудника: " + result.Name);
        }
    }
}
