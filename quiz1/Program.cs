///Задача 1: Задайте значения M и N. Напишите программу, 
///которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Enter first number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int N = Convert.ToInt32(Console.ReadLine());

void ShowNumbers(int M, int N)
{
    if (M == N)
    {
        Console.Write(M);
        return;
    }
    Console.Write(M + " ");
    ShowNumbers(M + 1, N);
}
ShowNumbers(M, N);