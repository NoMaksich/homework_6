// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double B1()
{
    Console.Write("Введите коэффициент b1: ");
    double limit =double.Parse(Console.ReadLine());
    return limit;
}
double K1()
{
    Console.Write("Введите коэффициент k1: ");
    double limit =double.Parse(Console.ReadLine());
    return limit;
}
double B2()
{
    Console.Write("Введите коэффициент b2: ");
    double limit =double.Parse(Console.ReadLine());
    return limit;
}

double K2()
{
    Console.Write("Введите коэффициент k2: ");
    double limit =double.Parse(Console.ReadLine());
    return limit;
}
double FindX(double b1, double k1, double b2, double k2)
{
    double x=0;
    if(k2>k1)
        x=(b1-b2)/(k2-k1);
    else
        x=(b1-b2)/(k1-k2);
    return x;
}
double FindY(double b1, double k1, double x)
{
    double y=0;
    y=k1*x+b1;
    return y;
}
double b1=B1();
double k1=K1();
double b2=B2();
double k2=K2();
Console.WriteLine($"Первое ур-е: y={k1}*x+{b1}");
Console.WriteLine($"Второе ур-е: y={k2}*x+{b2}");
if(k1!=k2)
{
    double x=FindX(b1, k1, b2, k2);
    double y=FindY(b1, k1, x);
    Console.WriteLine($"Прямые y={k1}*x+{b1} и y={k2}*x+{b2} пересекаются в точке ({x};{y})");
}
if(k1==k2 && b1!=b2)
{
    Console.WriteLine("Прямые параллельны");
}
if(k1==k2 && b1==b2)
{
    Console.WriteLine("Прямые совпадают");
}