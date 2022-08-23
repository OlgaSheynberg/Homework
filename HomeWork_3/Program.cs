Console.Clear();
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());

int b = (a%2);

if (b==0)
{
   Console.WriteLine(a);
   Console.WriteLine("чётное");
}
else
{
   Console.WriteLine(a);
   Console.WriteLine("нечётное");
}
