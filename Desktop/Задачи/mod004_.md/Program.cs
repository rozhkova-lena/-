// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    int i = -N;
    while (i <= N)
    {
        System.Console.Write(i + " ");
        i++; // i = i + 1; i += 1
    }
}
else
{
    System.Console.WriteLine("Введено не корректное значение!");
}
