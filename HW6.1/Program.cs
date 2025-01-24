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

//Console.WriteLine("Введіть максимальне число:");
//int maxNum = int.Parse(Console.ReadLine());

//Console.WriteLine($"Прості числа від 1 до {maxNum}:");

//for (int num = 2; num <= maxNum; num++)
//{
//    bool isPrime = true;
//    for (int i = 2; i < num; i++)
//    {
//        if (num % i == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.Write(num + " ");
//    }
//}

//Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача. Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).
//Console.WriteLine("Введіть пароль (має бути щонайменше 8 символів, хоча б одна цифра та один спеціальний символ):");
//string password = Console.ReadLine();

//bool isValidLength = password.Length >= 8;
//bool containsNumber = false;
//bool containsSpecialCharacter = false;
//string specialCharacters = "!@#$%*&*)(,.?\"|<>";

//foreach (char character in password)
//{
//    if (specialCharacters.Contains(character))
//    {
//        containsSpecialCharacter = true;
//    }
//    else if (char.IsDigit(character))
//    {
//        containsNumber = true;
//    }
//}

//if (isValidLength && containsNumber && containsSpecialCharacter)
//{
//    Console.WriteLine("Пароль вірний");
//}
//else
//{
//    Console.WriteLine("Пароль не відповідає вимогам");
//}

//Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі. Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.
//Console.WriteLine("Введіть кількість чисел Фібоначчі:");
//int num = int.Parse(Console.ReadLine());
//if (num <= 0)
//{
//    Console.WriteLine("Кількість чисел повинна бути більше 0");
//    return;
//}

//int first = 0;
//int second = 1;
//Console.WriteLine("Послідовність Фібоначчі:");

//for (int i = 0; i < num; i++)
//{
//    Console.Write(first + " ");
//    int next = first + second;
//    first = second;
//    second = next;
//}

//Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. Після введення значень програма має обчислити та вивести оплату за день.
//int hoursWorked;
//double hourRate;
//double dailyPay;

//Console.WriteLine("Введіть кількість годин, працюваних за день:");
//hoursWorked = int.Parse(Console.ReadLine());

//Console.WriteLine("Введіть розмір годинної ставки:");
//hourRate = double.Parse(Console.ReadLine());

//dailyPay = hoursWorked * hourRate;
//Console.WriteLine($"Оплата за день: {dailyPay} грн");

//Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.
//Console.WriteLine("Введіть число для генерації таблиці множення: ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{number} x {i} = {number * i}");
//}

//Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим. Число вважається простим, якщо воно ділиться лише на 1 і на себе.
Console.WriteLine("Введіть число:");
int num = int.Parse(Console.ReadLine());

bool isPrime;

if (num <= 1)
{
    Console.WriteLine("Число не є простим.");
}
else
{
    isPrime = true;

    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
        Console.WriteLine("Число просте");
    else
        Console.WriteLine("Число не є простим");
}
