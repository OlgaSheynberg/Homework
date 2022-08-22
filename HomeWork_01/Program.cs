Console.Clear();
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b)
{
    max = a;
    min = b; 
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("max=");
Console.WriteLine(max);
Console.WriteLine("min=");
Console.WriteLine(min);