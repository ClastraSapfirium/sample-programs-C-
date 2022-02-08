// Выяснить, кратно ли число заданному, если нет, вывести остаток.
double a=0, b=0;
string c;
Console.Clear();
Console.Write("Введите число A: ");
c=Console.ReadLine();
a=Convert.ToDouble(c);

Console.Write("ВВедите число которому будет кратно число A: ");
c=Console.ReadLine();
b=Convert.ToDouble(c);

if (a%b==0)
{
    System.Console.WriteLine($"Число {a} кратно числу {b}");
}
else System.Console.WriteLine(a/b);