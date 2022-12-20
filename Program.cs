// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Write("Напишите первое число");
int firstnumber = int.Parse(Console.ReadLine());
Console.Write("Напишите второе число");
int secondnumber = int.Parse(Console.ReadLine());
if (firstnumber > secondnumber)
{
    Console.WriteLine ($"max = {firstnumber}");
}
else
{
    Console.WriteLine ($"max = {secondnumber}"); 
}