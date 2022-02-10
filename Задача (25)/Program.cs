// Найти сумму чисел от 1 до А
int a=0,d=1;
int index = 0;
int sum = 1;
string c;
Console.Clear();

Console.Write("Введите число: ");
c=Console.ReadLine();
a=Convert.ToInt32(c);
while (index!=a)
{
    sum = sum +d;
    d = d+1;
    index++;
}
System.Console.WriteLine($"Сумма чисел от 1 до {a} = {sum-1}");