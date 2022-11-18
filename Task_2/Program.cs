//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 && number > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
if (number > 99 && number < 1000 || number < -99 && number > -1000)
{
    if (number > 0)
    {
        number = number % 10;
        Console.WriteLine($"Третья цифра: {number}");
    }
    if (number < 0)
    {
        number = -number % 10;
        Console.WriteLine($"Третья цифра: {number}");
    }
}
while (number > 999 || number < -999)
{
    number = number / 10;
    if (number < 1000 && number > 0)
    {
        number = number % 10;
        Console.WriteLine($"Третья цифра: {number}");
    }
    if (number > -1000 && number < 0)
    {
        number = -number % 10;
        Console.WriteLine($"Третья цифра: {number}");
    }
}

﻿/* Второй вариант:

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int searchNumber = 3;
int temp = number;
int count = 0;
if (number < 0)
{
    number *= -1;
    temp = number;
}
while (temp > 0)
{
    {
        temp /= 10;
        count++;
    }

}
while (count > searchNumber)
{
    {
        number /= 10;
        searchNumber++;
    }
}
if (count < 3)
{
    Console.WriteLine("третьего числа нет");
}
else
{
    Console.WriteLine(number % 10);
} */

﻿/* Третий вариант:

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine("Третья цифра: " + numberText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}*/
