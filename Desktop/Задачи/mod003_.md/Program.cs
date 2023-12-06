//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница
System.Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 1)
{
    System.Console.WriteLine("понедельник");
}
else if(day ==2)
{
    System.Console.WriteLine("Вт");
}
else if(day ==3)
{
    System.Console.WriteLine("Ср");
}
else if(day ==4)
{
    System.Console.WriteLine("Чт");
}
else if(day ==5)
{
    System.Console.WriteLine("Пт");
}
else if(day ==6)
{
    System.Console.WriteLine("Сб");
}
else if(day ==7)
{
    System.Console.WriteLine("Вс");
}
else {
    System.Console.WriteLine("Такого дня недели нет");
}
System.Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
