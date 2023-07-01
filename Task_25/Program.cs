// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите степень В: ");
int b = int.Parse(Console.ReadLine());

double result = 1;

for (int i = 0; i < b; i++)
{
    result *= a;
}

Console.WriteLine($"{a} в степени {b} равно {result}");