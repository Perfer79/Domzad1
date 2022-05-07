// Принимает на вход число N, на выходе показывает все четные до N]

Console.WriteLine("Введите число: ");

int Number = Convert.ToInt32(Console.ReadLine());
int Temp = Number - 1;
for (int i = 2; i <= Number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        if (i < Temp)
        {
            Console.Write(", ");
        }
    }
}