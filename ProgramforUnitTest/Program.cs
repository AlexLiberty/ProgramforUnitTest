Console.OutputEncoding = System.Text.Encoding.UTF8;

int year;
while (true)
{
    Console.WriteLine("Введіть рік:");
    if (int.TryParse(Console.ReadLine(), out year) && year >= 1 && year <= 9999)
    {
        break;
    }
    else
    {
        Console.WriteLine("Рік повинен бути в діапазоні від 1 до 9999.");
    }
}

int month;
while (true)
{
    Console.WriteLine("Введіть місяць:");
    if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
    {
        break;
    }
    else
    {
        Console.WriteLine("Місяць повинен бути в діапазоні від 1 до 12.");
    }
}

int day;
while (true)
{
    Console.WriteLine("Введіть день:");
    if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= DateTime.DaysInMonth(year, month))
    {
        break;
    }
    else
    {
        Console.WriteLine($"Некоректний день для {year}-{month}. Введіть число від 1 до {DateTime.DaysInMonth(year, month)}.");
    }
}

int hour;
while (true)
{
    Console.WriteLine("Введіть години:");
    if (int.TryParse(Console.ReadLine(), out hour) && hour >= 0 && hour <= 23)
    {
        break;
    }
    else
    {
        Console.WriteLine("Години повинні бути в діапазоні від 0 до 23.");
    }
}

int minute;
while (true)
{
    Console.WriteLine("Введіть хвилини:");
    if (int.TryParse(Console.ReadLine(), out minute) && minute >= 0 && minute <= 59)
    {
        break;
    }
    else
    {
        Console.WriteLine("Хвилини повинні бути в діапазоні від 0 до 59.");
    }
}

int second;
while (true)
{
    Console.WriteLine("Введіть секунди:");
    if (int.TryParse(Console.ReadLine(), out second) && second >= 0 && second <= 59)
    {
        break;
    }
    else
    {
        Console.WriteLine("Секунди повинні бути в діапазоні від 0 до 59.");
    }
}

try
{
    DateTime dateTime = new DateTime(year, month, day, hour, minute, second);
    Console.WriteLine($"Ви ввели коректну дату і час: {dateTime}");
}
catch (Exception ex)
{
    Console.WriteLine($"Помилка при створенні об'єкта DateTime: {ex.Message}");
}
