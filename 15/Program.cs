//входные данные - цифра от 1 до 7 (обозначают дни недели), 
//выводные - является ли этот день выходным (7-> да, 1-> нет)

// для псевдослучайных чисел ->
//int number = new Random().Next(1,8);
//Console.WriteLine(number);

Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if (number == 6 || number == 7)
{
    Console.Write($"{number} -> да, выходной");
}
else
{
    Console.Write($"{number} -> нет, не выходной");
}