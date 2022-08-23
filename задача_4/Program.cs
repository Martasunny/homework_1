//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine("max number:" + a);
}
else if (b>a && b>c)
{
    Console.WriteLine("max number:" + b);
}
else 
{
    Console.WriteLine("max number:" + c);
}