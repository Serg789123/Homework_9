// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите чило M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a;
int b;

if (M < N)
{
    a = M;
    b = N;
}
else
{
    a = N;
    b = M;
}

int Sum(int b)
{
    if (a == b) return a;
    else
    {
        return b + Sum(b - 1);
    }
}
Console.WriteLine(Sum(b));
