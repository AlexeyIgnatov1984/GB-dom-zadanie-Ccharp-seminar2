// Задача 10. Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:   ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
string strr = number.ToString();
Console.WriteLine($"{number} -> {strr[1]}");