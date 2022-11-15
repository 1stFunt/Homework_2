//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000 || number < -99 && number > -1000)
{
    if (number > 0)
    {
        int number2 = number / 10 % 10;
        Console.WriteLine($"Вторая цифра: {number2}");
    }
    if (number < 0)
    {
        int number2 = -number / 10 % 10;
        Console.WriteLine($"Вторая цифра: {number2}");
    }
}
else
{
    Console.WriteLine("Вы ввели не верное число!");
}