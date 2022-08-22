Console.Clear();
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

Console.WriteLine("Введите число a:");
string numberStr1;
numberStr1= Console.ReadLine();
int a = int.Parse(numberStr1);


Console.WriteLine("Введите число b:");
string numberStr2;
numberStr2= Console.ReadLine();
int b = int.Parse(numberStr2);

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