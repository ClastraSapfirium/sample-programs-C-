//По двум заданным числам проверять является ли первое квадратом второго
double a=0,b=0;
string c;
Console.Clear();
Console.Write("Vote number a:");
c=Console.ReadLine();
a=Convert.ToDouble(c);

Console.Write("Vote number b:");
c=Console.ReadLine();
b=Convert.ToDouble(c);

if (a*a==b)
{
    System.Console.WriteLine("YES");
}
else System.Console.WriteLine("NO");
