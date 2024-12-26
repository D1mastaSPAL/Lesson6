namespace Lesson6._1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Введите количество сотрудников, которых вы желаете добавить");
        var newPersonsCompany = Console.ReadLine();
        if (int.TryParse(newPersonsCompany, out int CountNewPersons) && CountNewPersons < 0)
        {
            Console.WriteLine("Вы ввели некорректное значение");
            return;
        }
        if (CountNewPersons > 50)
        {
            Console.WriteLine("Вы ввели слишком много сотрудников");
            return;
        }
        else
        {
            for (int i = 0; i < CountNewPersons; i++)
            {
                CreateInfoPersons();
                Console.Clear();
            }
            Console.WriteLine($"{"\n"}Введите (Y) для просмотра введенной информации по сотрудникам" +
                                $"{"\n"}Введите (N) для выхода.");
            var infoConfirmation = Console.ReadLine();
            if (string.IsNullOrEmpty(infoConfirmation))
            {
                Console.WriteLine("Неверный ввод");
                return;
            }
            if (infoConfirmation.Equals("y", StringComparison.CurrentCultureIgnoreCase))
            {
                while (true)
                {
                    Console.WriteLine($"{"\n"}Нажмите - 1 (для вывода информации о сотрудниках)" +
                            $"{"\n"}Нажмите - 2 (для поиска сотрудника)" +
                            $"{"\n"}Нажмите - 3 (для выхода из программы)");

                    var numberCount = Console.ReadLine();
                    if (!int.TryParse(numberCount, out int count) && count < 0)
                    {
                        Console.WriteLine("Неверный ввод");
                        return;
                    }
                    else
                    {
                        switch (count)
                        {
                            case 1:
                                Console.WriteLine($"{"\n"}Список сотрудников: ");
                                EmployeeRegistry.ListAllEmployees();
                                break;
                            case 2:
                                Console.WriteLine($"{"\n"}Введите имя сотрудника, которого желаете найти: ");
                                var SearchName = Console.ReadLine();
                                if (!string.IsNullOrEmpty(SearchName))
                                {
                                    EmployeeRegistry.FindEmployee(SearchName);
                                }
                                break;
                            case 3:
                                Console.WriteLine("Программа завершена");
                            return;
                        }
                    }
                }
            }
            else
            {
                if (infoConfirmation.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Программа завершена");
                    return;
                }
            }
        } 
    }

    public static bool CreateInfoPersons()
    {
        Console.WriteLine("Введите имя сотрудника");
        var inputName = Console.ReadLine();
        if (string.IsNullOrEmpty(inputName))
        {
            Console.WriteLine("Неверный ввод");
            return false;
        }
        Console.WriteLine("Введите фамилию сотрудника");
        var inputSurName = Console.ReadLine();
        if (string.IsNullOrEmpty(inputSurName))
        {
            Console.WriteLine("Неверный ввод");
            return false;
        }
        Console.WriteLine("Введите возраст сотрудника");
        var inputAge = Console.ReadLine();
        if (!byte.TryParse(inputAge, out var age) && age < 0)
        {
            Console.WriteLine("Неверный ввод");
            return false;
        }
        Console.WriteLine("Выберите должность сотрудника, которого вы хотите добавить (M / W) ");
        var inputPosition = Console.ReadLine();
        if (string.IsNullOrEmpty(inputPosition))
        {
            Console.WriteLine("Неверный ввод");
            return false;
        }
        if (inputPosition.Equals("w", StringComparison.CurrentCultureIgnoreCase))
        {
            var worker = new Worker(inputName, inputPosition, age, inputSurName);
            EmployeeRegistry.AddEmployee(worker);
        }
        else if (inputPosition.Equals("m", StringComparison.CurrentCultureIgnoreCase))
        {
            var manager = new Manager(inputName, inputPosition, age, inputSurName);
            EmployeeRegistry.AddEmployee(manager);

            Console.WriteLine("Введите название проекта, над которым работает менеджер");
            var inputProjectName = Console.ReadLine();
            if (string.IsNullOrEmpty(inputProjectName))
            {
                Console.WriteLine("Неверный ввод");
                return false;
            }
            Console.WriteLine($"Введите дату, сдачи проекта {inputProjectName}");
            var inputDeadLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputDeadLine))
            {
                Console.WriteLine("Неверный ввод");
                return false;
            }
            var managerProject = new Manager.Project(inputProjectName, inputDeadLine);
        }
        return true;
    }
}
