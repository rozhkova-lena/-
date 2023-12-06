﻿ //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

 void SumInLines(int[,] numbers)
        {
            int[] sumInLines = new int[numbers.GetLength(0)];
            Console.Write("\nСуммы элементов в каждой строке: ");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sumInLines[i] += numbers[i, j];
                }
                Console.Write($"{sumInLines[i]} ");
            }
            int minI = 0;
            for (int i = 0; i < sumInLines.Length; i++)
            {
                if (sumInLines[minI] > sumInLines[i]) minI = i;
            }
            Console.Write($"\nНаименьшая сумма элементов: {sumInLines[minI]}");
        }

 