//int numOfEmployees;
//string nameOfEmployee;
//double monthSalary;
//double totalSalary = 0;
//double averageSalary;

//Console.Write("Введіть кількість працівників: ");
//numOfEmployees = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введіть ім'я кожного працівника");

//for (int i = 0; i < numOfEmployees; i++)
//{
//    Console.Write($"Ім'я працівника № {i + 1}: ");
//    nameOfEmployee = Console.ReadLine();

//    Console.Write("Введіть зарплату за 1 місяць: ");
//    monthSalary = Convert.ToDouble(Console.ReadLine());
//    totalSalary += monthSalary;
//    Console.WriteLine($"Зарплата працівника № {i + 1}, {nameOfEmployee} за 1 місяць ствновить: {monthSalary}");
//}
//averageSalary = totalSalary / numOfEmployees;
//Console.WriteLine($"Середній заробіток працівників: {averageSalary}");

//Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок.
//Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок.

//Console.WriteLine("Введіть кількість рядків: ");
//int stringsNum = int.Parse(Console.ReadLine());

//for (int i = 1; i <= stringsNum; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");

//    }
//    Console.WriteLine()
//}

//Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. Просте число - це число, яке ділиться лише на 1 і на себе.

Console.WriteLine("Введіть максимальне число:");
int maxNum = int.Parse(Console.ReadLine());

Console.WriteLine($"Прості числа від 1 до {maxNum}:");

for (int num = 2; num <= maxNum; num++)
{
    bool isPrime = true;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.Write(num + " ");
    }
}