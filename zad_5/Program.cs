// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine ());
Console.WriteLine("Введите второе число: ");
int a2 = int.Parse(Console.ReadLine ());
if (a1 * a1 == a2 || a2 * a2 == a1)
{
    Console.WriteLine("Да");
}
else
 Console.WriteLine("Нет");