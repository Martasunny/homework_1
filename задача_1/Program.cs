//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max number:" + a);
}
else
{
    Console.WriteLine("max number:" + b);
}

