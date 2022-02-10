// Возведите число А в натуральную степень B используя цикл
int a=0,b=0;
int index = 0;
int step = 1;
string c;
Console.Clear();

Console.Write("Введите число: ");
c=Console.ReadLine();
a=Convert.ToInt32(c);

Console.Write("Введите степень числа: ");
c=Console.ReadLine();
b=Convert.ToInt32(c);
while (index!=b)
{
    step = step*a;
    index++;
}
System.Console.WriteLine($"Возведя число {a} в натуральнeую степень {b} используя цикл, получаем число {step}");