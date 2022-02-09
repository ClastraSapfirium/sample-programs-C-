// По двум заданным числам проверять является ли одно квадратом другого
int a = 0, b = 0;
string c;
Console.Clear();
Console.Write("Введите число A: ");
c=Console.ReadLine();
a=Convert.ToInt32(c);
Console.Write("Введите число B: ");
c=Console.ReadLine();
b=Convert.ToInt32(c);
if (a<b && a*a==b) System.Console.WriteLine($"Число {b} является квадратом числа {a}");
else System.Console.WriteLine($"Число {b} не является квадратом числа {a}");
if (a>b && b*b==a) System.Console.WriteLine($"Число {a} является квадратом числа {b}");
else System.Console.WriteLine($"Число {a} не является квадратом числа {b}");