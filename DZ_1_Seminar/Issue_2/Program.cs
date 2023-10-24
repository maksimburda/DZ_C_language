//Напишите программу, которая
//принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число с = ");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max > c)
{
    Console.Write("Максимальное число ");
    Console.WriteLine(max);
}
else
{
    max = c;
    Console.Write("Максимальное число ");
    Console.WriteLine(max);
}
