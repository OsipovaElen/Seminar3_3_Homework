//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);
int lengthNumber = number.Length;

if (lengthNumber != 5)
{
  Console.Write("Введите пятизначное число"); 
}
else
{
    if (num / 10000 == num % 10 & num / 1000 % 10 == num % 100 / 10)
      {
        Console.Write($"Число {num} - палиндром");
      }
      else 
      {
        Console.Write($"Число {num} - не палиндром");
      }
}