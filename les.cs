//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
Console.WriteLine(RowNumber(n, m));

int RowNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{RowNumber(n, m + 1)}, ");
    return m;
}




//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

/*Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов от {m} до {n}: {Summa(m, n)}");

int Summa(int m, int n)
{
    if (m == n)
        return n;
    return n + Summa(m, n - 1);
}
*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

/*Console.WriteLine("Введите два положительных числа: n и m.");
int n = InputInt("введите n: ");
int m = InputInt("введите m: ");
Console.WriteLine($"A({n}, {m}) = {Akkerman(n, m)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (n > 0 && m == 0)
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}
*/
