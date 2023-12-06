// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
// Комментарий Ctrl + / (Cmd + /)

// Пригласили пользователя ко вводу числа
Console.WriteLine("Введите число: "); 

// // Приняли число из терминала и сохранили в переменную number
// // int number = int.Parse(Console.ReadLine());
int number = Convert.ToInt32(Console.ReadLine());

// // Получили квадрат числа и записали его в переменную sqr
int sqr = number * number;

// // Вывод данных в терминал
// System.Console.WriteLine(number + " -> " + sqr);
System.Console.WriteLine($"{number} -> {sqr}");
