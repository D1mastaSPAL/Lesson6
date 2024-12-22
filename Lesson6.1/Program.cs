namespace Lesson6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager ManagerOne = new Manager();
            Manager ManagerTwo = new Manager();
            Worker WorkerOne = new Worker();
            Worker WorkerTwo = new Worker();
            var ManagerOneProject = new Manager.Project();
            var ManagerTwoProject = new Manager.Project();

            EmployeeRegistry.AddEmployee(employee: ManagerOne);
            EmployeeRegistry.AddEmployee(employee: ManagerTwo);
            EmployeeRegistry.AddEmployee(employee: WorkerOne);
            EmployeeRegistry.AddEmployee(employee: WorkerTwo);

            Console.WriteLine("\t" + "\t" + "Программа для записи данных о сотрудниках");

            //ЗАПОЛНЯЕМ МЕНЕДЖЕРА - 1
            Console.WriteLine("Заполните данные 1-го менеджера" + "\n" + "Введи имя менеджера: ");
            ManagerOne.Name = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(ManagerOne.Name))
            {
                Console.WriteLine("Ошибка! Вы не ввели имя.");
                return;
            }
            Console.WriteLine("Укажите должность (Manager / Менеджер): ");
            ManagerOne.Position = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(ManagerOne.Position))
            {
                Console.WriteLine("Ошибка! Вы не ввели должность");
                return;
            }
            if (ManagerOne.Position != "Менеджер" && ManagerOne.Position != "Manager")
            {
                Console.WriteLine("Ошибка! Вы неверно ввели должность");
                return;
            }

            try
            {
                Console.WriteLine("Укажи возраст: ");
                ManagerOne.Age = byte.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Вы не ввели возраст");
                return;
            }

            Console.WriteLine($"Название проекта над которым работает {ManagerOne.Name}: ");
            ManagerOneProject.ProjectName = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(ManagerOneProject.ProjectName))
            {
                Console.WriteLine("Ошибка! Вы ничего не ввели");
                return;
            }

            Console.WriteLine("Срок сдачи проекта: " + ManagerOneProject.ProjectName);
            ManagerOneProject.Deadline = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(ManagerOneProject.Deadline))
            {
                Console.WriteLine("Ошибка! Вы ничего не ввели");
                return;
            }


            //ЗАПОЛНЯЕМ МЕНЕДЖЕРА - 2
            Console.WriteLine("Заполните данные 2-го менеджера" + "\n" + "Введи имя менеджера: ");
            ManagerTwo.Name = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(ManagerTwo.Name))
            {
                Console.WriteLine("Ошибка! Вы не ввели имя");
                return;
            }

            Console.WriteLine("Укажите должность (Manager / Менеджер): ");
            ManagerTwo.Position = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(ManagerTwo.Position))
            {
                Console.WriteLine("Ошибка! Вы не ввели должность");
                return;
            }
            if (ManagerTwo.Position != "Менеджер" && ManagerTwo.Position != "Manager")
            {
                Console.WriteLine("Ошибка! Вы неверно ввели должность");
                return;
            }

            try
            {
                Console.WriteLine("Укажи возраст: ");
                ManagerTwo.Age = byte.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Вы не ввели возраст");
                return;
            }

            Console.WriteLine($"Название проекта над которым работает {ManagerTwo.Name}: ");
            ManagerTwoProject.ProjectName = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(ManagerTwoProject.ProjectName))
            {
                Console.WriteLine("Ошибка! Вы ничего не ввели");
                return;
            }

            Console.WriteLine("Срок сдачи проекта: " + ManagerTwoProject.ProjectName);
            ManagerTwoProject.Deadline = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(ManagerTwoProject.Deadline))
            {
                Console.WriteLine("Ошибка! Вы ничего не ввели");
                return;
            }

            //ЗАПОЛНЯЕМ РАБОЧЕГО - 1
            Console.WriteLine("Заполните данные 1-го работника" + "\n" + "Введи имя работника: ");
            WorkerOne.Name = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(WorkerOne.Name))
            {
                Console.WriteLine("Ошибка! Вы не ввели имя");
                return;
            }

            Console.WriteLine("Укажите должность (Рабочий / Worker): ");
            WorkerOne.Position = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(WorkerOne.Position))
            {
                Console.WriteLine("Ошибка! Вы не ввели должность");
                return;
            }
            if (WorkerOne.Position != "Рабочий" && WorkerOne.Position != "Worker")
            {
                Console.WriteLine("Ошибка! Вы неверно ввели должность");
                return;
            }

            Console.WriteLine("Укажи фамилию работника: ");
            WorkerOne.Surname = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(WorkerOne.Surname))
            {
                Console.WriteLine("Ошибка! Вы ничего не ввели");
                return;
            }

            try
            {
                Console.WriteLine("Укажи возраст: ");
                WorkerOne.Age = byte.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Вы не ввели возраст");
                return;
            }

            //ЗАПОЛНЯЕМ РАБОЧЕГО - 2
            Console.WriteLine("Заполните данные 2-го работника" + "\n" + "Введи имя работника: ");
            WorkerTwo.Name = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(WorkerTwo.Name))
            {
                Console.WriteLine("Ошибка! Вы не ввели имя");
                return;
            }

            Console.WriteLine("Укажите должность (Рабочий / Worker): ");
            WorkerTwo.Position = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(WorkerTwo.Position))
            {
                Console.WriteLine("Ошибка! Вы не ввели должность");
                return;
            }
            if (WorkerTwo.Position != "Рабочий" && WorkerTwo.Position != "Worker")
            {
                Console.WriteLine("Ошибка! Вы неверно ввели должность");
                return;
            }

            Console.WriteLine("Укажи фамилию работника: ");
            WorkerTwo.Surname = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(WorkerTwo.Surname))
            {
                Console.WriteLine("Ошибка! Вы ничего не ввели");
                return;
            }

            try
            {
                Console.WriteLine("Укажи возраст: ");
                WorkerTwo.Age = byte.Parse(Console.ReadLine());
            
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Вы не ввели возраст");
                return;
            }

            try
            {
                Console.WriteLine("\n");
                Console.WriteLine("Введите (Да) для просмотра введенной информации по сотрудникам");
                Console.WriteLine("Введите (Нет) для выхода");
                string infoConfirmationOne = Convert.ToString(Console.ReadLine());

                if (infoConfirmationOne == "Да")
                {
                    while (true)
                    {
                        Console.WriteLine($"{"\n"}Нажмите - 1 (для вывода информации о сотрудниках)" +
                                $"{"\n"}Нажмите - 2 (для поиска сотрудника)" +
                                $"{"\n"}Нажмите - 3 (для вывода информации по менеджерам)" +
                                $"{"\n"}Нажмите - 4 (для вывода информации по рабочим)" +
                                $"{"\n"}Нажмите - 5 (для выхода из программы)");
                        int numberCount = int.Parse(Console.ReadLine());
                        switch (numberCount)
                        {
                            case 1:
                                EmployeeRegistry.ListAllEmployees();
                                break;
                            case 2:
                                EmployeeRegistry.FindEmployee("Валера");
                                break;
                            case 3:
                                ManagerOne.GetDetails();
                                ManagerOneProject.DisplayProjectInfo();
                                ManagerTwo.GetDetails();
                                ManagerTwoProject.DisplayProjectInfo();
                                break;
                            case 4:
                                WorkerOne.GetDetails();
                                WorkerTwo.GetDetails();
                                break;
                            case 5:
                                return;
                        }
                    }
                }
                else
                {
                    if (infoConfirmationOne == "Нет")
                    {
                        return;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Неверный ввод");
                return;
            }
        }      
    }
}
