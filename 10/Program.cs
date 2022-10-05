// входные данные - любое трехзначное число, выводные - вторая цифра данного числа
int number = new Random().Next(100,1000);
// для ручного введения числа->
//Console.Write("Ведите трехзначное число: ");
//int number = int.Parse(Console.ReadLine()!);
int number2 = number % 100 / 10;
Console.WriteLine($"вторая цифра числа {number} -> {number2}");