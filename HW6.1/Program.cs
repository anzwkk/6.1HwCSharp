int numOfEmployees;
string nameOfEmployee;
double monthSalary;

Console.Write("Введіть кількість працівників: ");
numOfEmployees = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введіть ім'я кожного працівника");

for (int i = 0; i < numOfEmployees; i++)
{
    Console.Write($"Ім'я працівника № {i + 1}: ");
    nameOfEmployee = Console.ReadLine();

    Console.Write("Введіть зарплату за 1 місяць: ");
    monthSalary = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Зарплата працівника № {i + 1}, {nameOfEmployee} за 1 місяць ствновить: {monthSalary}");
}
