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