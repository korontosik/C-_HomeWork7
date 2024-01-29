using System.Diagnostics.Contracts;

Console.Clear();
// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// M = 1; N = 5 -> "1.2.3.4.5"
// M = 4; N = 8 -> "4.5.6.7.8"


// RecursiveLine(1, 5); // M = 1, N = 5
// Console.WriteLine();
// RecursiveLine(4, 8); // M = 4, N = 8

// void RecursiveLine(int m, int n)
// {
//     if (m == n)
//     {
//     Console.Write($"{n} ");
//     return;
//     }
//     RecursiveLine(m, n - 1);
//     Console.Write($"{n} ");
// }


// Задача 2:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m =3 ; n = 2

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))
// Поменять местами "m" и "n"


// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (n == 0) 
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     { 
//         return Akkerman(m - 1, Akkerman(m, n - 1));
//     }
// }
// Console.Write($"{Akkerman(3, 2)}");


// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1



void PrintArray(int[] array, int startIndex = 0)
{
    if (startIndex < array.Length)
    {
        PrintArray(array, startIndex + 1);
        Console.Write(array[startIndex] + " ");
    }
}

int [] array = {1, 2, 5, 0, 10, 34};
PrintArray(array);

