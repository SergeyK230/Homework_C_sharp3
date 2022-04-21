int a = 23432;
if (a / 10000 == a % 10 && a / 1000 % 10 == a % 100 / 10)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
