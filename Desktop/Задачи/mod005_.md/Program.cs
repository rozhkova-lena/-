﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// "/" - целочисленное деление
// "%" - взятие остатка от деление (деление по модулю)
// "&&" - логическое "И"

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 100 && number <= 999)
{
    System.Console.WriteLine(number%10);
}
else{
    System.Console.WriteLine("Вы ввели не трехзначное число!");
}
