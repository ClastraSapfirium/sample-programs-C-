// Выяснить являются ли три числа сторонами треугольника
Console.Clear();
double a,b,c;
string s;
System.Console.WriteLine("Введите число (a): ");
s = Console.ReadLine();
a = Convert.ToDouble(s);

System.Console.WriteLine("Введите число (b): ");
s = Console.ReadLine();
b = Convert.ToDouble(s);

System.Console.WriteLine("Введите число (c): ");
s = Console.ReadLine();
c = Convert.ToDouble(s);
bool IsString(double x, double y, double z)
{
    bool flag;
    flag=(a+b>c && a+c>b && b+c>a);
    return flag;
}
System.Console.WriteLine($"{a} {b} {c} - "+IsString(a,b,c));