// входные данные - любое число, выводные данные - 3-я цифра данного числа - ..., либо ее нет
Console.Write("Ведите любое число: ");
int number = int.Parse(Console.ReadLine()!);
if (number / 100 == 0)
{
    Console.Write($" {number} -> третьей цифры нет");
}
else 
{
while (number / 1000 != 0)
{
    number = number / 10; 
}
if (number / 1000 == 0)
{
    Console.Write($" -> третья цифра {number % 10}");
}
}