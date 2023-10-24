// Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b = ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write("max a = ");
    Console.WriteLine(a);
    Console.Write("min b = ",b);
    Console.WriteLine(b);
}
else
{
 Console.Write("max b = ");
 Console.WriteLine(b);
    Console.Write("min a = ");
     Console.WriteLine(a);
}