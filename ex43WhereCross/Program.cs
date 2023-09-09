// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*  y = k1 * x + b1
    y = k2 * x + b2

    y - y = k1 * x + b1 - (k2 * x + b2)
    y = k2 * x + b2
    
    k2*x - k1*x = b1 - b2
    x(k2-k1) = b1 - b2
    
    x = (b1 - b2) / (k2-k1)
    y = k2*(b1 - b2) / (k2-k1) + b2*/


using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

static void WhereLinesCross(out double x, out double y)
{
    Console.Write("Enter the value for k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the value for b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the value for k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the value for b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    x = (b1 - b2) / (k2 - k1);
    y = k1 * x + b1;
}

double x , y;
WhereLinesCross(out x, out y);
Console.Write($"{x}; {y}");

