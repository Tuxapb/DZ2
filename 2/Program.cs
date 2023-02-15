// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

switch (number1)
{
    case  int n when (n < 100):
        Console.Write($"Третьей цифры нет");
        break;
    case  int n when (n > 100 && n <1000):
        Console.Write($"Третья цифра = {n%10}");
        break;
    case  int n when (n > 1000 && n <10000):
        Console.Write($"Третья цифра = {n=(n/10)%10}");
        break;
    case  int n when (n > 10000 && n <100000):
        Console.Write($"Третья цифра = {n=(n/100)%10}");
        break;    
}
