///Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
///Даны два неотрицательных числа m и n.

Console.Write("Enter first number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int N = Convert.ToInt32(Console.ReadLine());
int FunctionAck (int M, int N)
{
    if(M == 0)
    {
        return (N + 1);
    }
else if(N == 0)
{
    return FunctionAck (M - 1, 1);
}
else 
{
    return FunctionAck (M - 1, FunctionAck (M, N - 1));
}
}
Console.Write(FunctionAck(M, N));