//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Enter number");
int n = Convert.ToInt32(Console.ReadLine());
int x = 2;
if (n  <= 1)
{
    Console.WriteLine("четных чисел нет от 1 до N");
}
else while (x <= n)
{
    Console.Write(x + ", ");
    x = x + 2;
}
