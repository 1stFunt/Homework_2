//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, которая соответствует дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8 && number > 0)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной день!");
    }
    else
    {
        Console.WriteLine("Это не выходной день =(");
    }
}
else
{
    Console.WriteLine("Введите верную цифру!");
}