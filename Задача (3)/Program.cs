//Даны два числа. Показать большее и меньшее число
double a=0,b=0;
string c;
Console.Clear();
Console.Write("Vote number a:");
c=Console.ReadLine();
a=Convert.ToDouble(c);

Console.Write("Vote number b:");
c=Console.ReadLine();
b=Convert.ToDouble(c);

if (a>b)
{
    System.Console.WriteLine($"{a}>{b}");
}
if (a<b)
{
    System.Console.WriteLine($"{a}<{b}");
}
if (a==b)
{
    System.Console.WriteLine($"{a}={b}");
}
