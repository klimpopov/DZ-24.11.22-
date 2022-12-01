/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

Console.Write("Введи число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел: {SumNumberFromM2N(m, n)}");

int SumNumberFromM2N(int start, int end)
{
    while (start <= end)
        return start + SumNumberFromM2N(start + 1, end);
        return 0;
}