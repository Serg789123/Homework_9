// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите чило m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunc = Ack(m, n);

Console.WriteLine($"Функция Аккермана = {AckermannFunc} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

