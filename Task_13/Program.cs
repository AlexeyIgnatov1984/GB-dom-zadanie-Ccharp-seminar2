// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 32679 -> 6
// 78 -> 3-ей цифры нет

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberStr = Convert.ToString(Number);

if (NumberStr.Length > 2)
{
  Console.WriteLine("третья цифра -> " + NumberStr[2]);
}
else 
{
    Console.WriteLine("третьей цифры нет");
}