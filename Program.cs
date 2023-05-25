// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int m = ReadInt("Please input the number m: ");
// int n = ReadInt("Please input the number n: ");
// if (n > m)
// {
//     System.Console.WriteLine(Rec(m, n));
// }
// else
// {
//     System.Console.WriteLine(Rec(n, m));
// }
// int ReadInt(string mesage)
// {
//     System.Console.Write(mesage);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int Rec(int m, int n)
// {
//     if (m > n)
//     {
//         return 0;
//     }
//     return m + Rec(m + 1, n);
// }
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = ReadInt("Please input the number m: ");
int n = ReadInt("Please input the number n: ");

System.Console.WriteLine(FuncAcerman(m, n));

int ReadInt(string mesage)
{
    System.Console.Write(mesage);
    return Convert.ToInt32(Console.ReadLine());
}

int FuncAcerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FuncAcerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return FuncAcerman(m - 1, FuncAcerman(m, n - 1));
    }
    return 0;
}