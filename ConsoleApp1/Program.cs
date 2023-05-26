using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
       
        {
            // Массив сотрудников.
             Employee[] employees = new Employee[] {
        new Employee() { Id = 1, FullName = "Комочков Денис Александрович", Salary = 10000.0, Department = 1 },
        new Employee() { Id = 2, FullName = "Косых Иван Андреевич", Salary = 15000.0, Department = 1 },
        new Employee() { Id = 3, FullName = "Коробов Влад Андреевич", Salary = 12000.0, Department = 2 },
        new Employee() { Id = 4, FullName = "Федотов Данил Витальевич", Salary = 20000.0, Department = 2 },
        new Employee() { Id = 5, FullName = "Погорелов Артём Викторович", Salary = 8000.0, Department = 3 },
        new Employee() { Id = 6, FullName = "Батрудинов Тимур Муратович", Salary = 17000.0, Department = 3 },
        new Employee() { Id = 7, FullName = "Калашников Пётр Витальевич", Salary = 11000.0, Department = 4 },
        new Employee() { Id = 8, FullName = "Жуков Антон Павлович", Salary = 13000.0, Department = 4 },
        new Employee() { Id = 9, FullName = "Шевченко Макар Николавевич", Salary = 9000.0, Department = 5 },
        new Employee() { Id = 10, FullName = "Панасенко Андрей Григорьевич", Salary = 10000.0, Department = 5 },
    };

            {

                // Получить от пользователя номер отдела.
                Console.WriteLine("Введите номер отдела (1-5): ");
                int department = Convert.ToInt32(Console.ReadLine());

                // Вызываем нужные методы для получения требуемых результатов.
                Employee minSalary = FindMinSalary(department, employees);
                Employee maxSalary = FindMaxSalary(department, employees);
                double avgSalary = FindAvgSalary(department, employees);
                AdjustSalaryByDept(department, 10.0, employees);
                PrintEmployeesByDept(department, employees);

                // Выводим полученные результаты на экран.
                Console.WriteLine($"Сотрудник с минимальной зарплатой: {minSalary.FullName}, зарплата: {minSalary.Salary}");
                Console.WriteLine($"Сотрудник с максимальной зарплатой: {maxSalary.FullName}, зарплата: {maxSalary.Salary}");
                Console.WriteLine($"Средняя зарплата: {avgSalary}");

            }

            // Методы для выполнения заданий.

            static Employee FindMinSalary(int deptNo, System.Collections.IEnumerable employees)
            {
                double minSalary = double.MaxValue;
                Employee minEmployee = null;
                foreach (Employee emp in employees)
                {
                    if (emp.Department == deptNo && emp.Salary < minSalary)
                    {
                        minSalary = emp.Salary;
                        minEmployee = emp;
                    }
                }
                return minEmployee;
            }

            static  Employee FindMaxSalary(int deptNo, System.Collections.IEnumerable employees)
            {
                double maxSalary = double.MinValue;
                Employee maxEmployee = null;
                foreach (Employee emp in employees)
                {
                    if (emp.Department == deptNo && emp.Salary > maxSalary)
                    {
                        maxSalary = emp.Salary;
                        maxEmployee = emp;
                    }
                }
                return maxEmployee;
            }

            static double FindAvgSalary(int deptNo, System.Collections.IEnumerable employees)
            {
                int count = 0;
                double total = 0;
                foreach (Employee empin in employees)
                {
                    if (empin.Department == deptNo)
                    {
                        count++;
                        total += empin.Salary;
                    }
                }
                return total / count;
            }

            static  void AdjustSalaryByDept(int deptNo, double percentage, System.Collections.IEnumerable employees)
            {
                foreach (Employee emp in employees)
                {
                    if (emp.Department == deptNo)
                    {
                        emp.Salary *= 1 + percentage / 100.0;
                    }
                }
            }

            static  void PrintEmployeesByDept(int deptNo, System.Collections.IEnumerable employees)
            {
                Console.WriteLine($"Сотрудники в отделе {deptNo}:");
                foreach (Employee emp in employees)
                {
                    if (emp.Department == deptNo)
                    {
                        Console.WriteLine($"{emp.Id}, {emp.FullName}, {emp.Salary}");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
    }

