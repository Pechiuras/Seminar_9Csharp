//Task65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string f(int m, int n)
{
  if (n == m)
    return $"{m}";
  return f(m, n - 1) + $", {n}";
}

Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));