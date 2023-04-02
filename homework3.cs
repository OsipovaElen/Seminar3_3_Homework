//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine(" Введите число N для вычисления кубов чисел от 1 до N: ");
string number = Console.ReadLine();
int N = int.Parse(number);

int[] cub = new int[0];
for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3)); 
    if (i != N)
    {
        Console.Write(", ");
    }
    else
    {
       break; 
    }
}