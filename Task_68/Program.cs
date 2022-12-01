/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

Console.Write("Введи число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(m,n) = {FunAkkerman(m, n)}");

int FunAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FunAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
    return FunAkkerman(m, n);
}

/* Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(n,m) = {A(n, m)}");

static int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n, m);
} */