using System;
class Program
{
static void Main()
{
    //Создаем двумернный массив
    int[,] array = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
    //Вводим позиции элемента
    Console.WriteLine ("Введите позицию элемента в двухмерном массиве");
    Console.Write ("Строка: ");
    int row = (Convert.ToInt32(Console.ReadLine())) - 1;
    Console.Write ("Столбец: ");
    int col = (Convert.ToInt32(Console.ReadLine())) - 1;
    // Проверяем, существует ли элемент с такими позициями
    int rows = array.GetLength (0);
    int cols = array.GetLength (1);
    if ( row >= 0 && row < rows && col >= 0 && col < cols)
    {
        // Если элемент существует, то выводим его значение
        int element = array [row, col];
        Console.WriteLine ("Значение элемента " + element);
    }
    else 
    {
        // Если элемент не существует
        Console.WriteLine ("Элемент не существует");
    }
    Console.ReadKey();
}
}