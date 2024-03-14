// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void FindRaznost (int a)
{
    if (a%7 ==0 && a%23==0)
    {
        Console.Write ($"Число {a} кратно одновременно 7 и 23");
    }
    else
    {
        Console.Write ($"Число {a} некратно одновременно 7 и 23");
    }
}
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine());

FindRaznost(n);
