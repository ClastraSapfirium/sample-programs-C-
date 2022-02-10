// Найти кубы чисел от 1 до N
int a=0,b=1;
string c;
Console.Clear();

Console.Write("Введите число: ");
c=Console.ReadLine();
a=Convert.ToInt32(c);
while (b<=a)
{
    System.Console.WriteLine($"Значение числа {b} в кубе = {b*b*b}");
    b++;
}