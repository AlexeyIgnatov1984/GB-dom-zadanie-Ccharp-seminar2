// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 ->да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели(от 1 до 7):  ");
int daynumber = Convert.ToInt32(Console.ReadLine());

if (daynumber == 6 || daynumber == 7)
    Console.WriteLine("Да, это выходной день");
else 
    Console.WriteLine("Нет, это рабочий день"); 