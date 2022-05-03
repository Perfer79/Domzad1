// Принимает на вход 3 числа и выдает max из них
Console.WriteLine("введите числа ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
/*
if (a > b) max = a;
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else
if (b > c)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
if (c > b)
{
    Console.Write("max = ");
    Console.WriteLine(c);
}
*/

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);