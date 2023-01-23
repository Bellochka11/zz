// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int a1 = int.Parse(Console.ReadLine ());
if (a1 % 7 == 0 && a1 % 23 == 0)
{
    Console.WriteLine("Кратно");
}
else Console.WriteLine("Не кратно");