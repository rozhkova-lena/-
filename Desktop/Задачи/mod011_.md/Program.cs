// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите число: ");
int numberF= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberS= Convert.ToInt32(Console.ReadLine());

if (numberF==numberS*numberS || numberS==numberF*numberF)
{
    Console.WriteLine("yes");
}
else 
{
    Console.WriteLine("no");
}
