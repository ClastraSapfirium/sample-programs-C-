// Показать четные числа от 1 до N
double a=1, b=0;
string c;
Console.Write("Vote number N:");
c=Console.ReadLine();
b=Convert.ToDouble(c);

while (a!=b)
{
    if (a%2==0)
    {
        System.Console.WriteLine($"{a}");
    }
    a=a+1;
}