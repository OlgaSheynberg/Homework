Console.Clear();
Console.WriteLine(" Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

int i = 1;
Console.WriteLine("Чётные числа от 1 до N:");

while (i<=N)
{
    int b = (i%2);
     if (b==0)
{
    Console.WriteLine(i);
}
    i++;
}
