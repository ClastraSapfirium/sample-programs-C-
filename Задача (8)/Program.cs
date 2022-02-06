// Показать числа от -N до N
double a=0, b=0;
string c;
Console.Clear();
Console.Write("Vote number -N:");
c=Console.ReadLine();
a=Convert.ToDouble(c);

Console.Write("Vote number -N:");
c=Console.ReadLine();
b=Convert.ToDouble(c);

while (a!=b)
{
    a=a+1;
    System.Console.WriteLine($"{a}");
}
