// На вход принимает 2 числа и выдает, какое max, а какое min

Console.WriteLine("введите число ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

 if (a > b)
 {
     Console.Write("max = ");
     Console.WriteLine(a);
     Console.Write("min = ");
     Console.WriteLine(b);
 }
else
{
     Console.Write("max = ");
     Console.WriteLine(b);
     Console.Write("min = ");
     Console.WriteLine(a);
}