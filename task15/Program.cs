// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число, соответствующее дню недели(1-7):");
int number = int.Parse(Console.ReadLine());
if(number>0 && number<6)
{
    Console.WriteLine("Рабочий день!");
}
else if(number>5 && number< 8)
{
    Console.WriteLine("Ура! Выходной!s");
}
else
{
    Console.WriteLine("Введено неверное значение!");
}