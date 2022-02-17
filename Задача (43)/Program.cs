// Написать программу преобразования десятичного числа в двоичное

int a = 0, b = 0, step = 0;
string s;
Console.Clear();
System.Console.WriteLine("Введите десятичное число: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);
b = a;
while (a!=0)
{
    a = a/2;
    step++;
}
int [] arr = new int[step];
for (int i = 0; i < step; i++)
{
    arr[i] = b%2;
    b = b/2;
}
System.Console.Write("Двоичное число: ");
for (int i = step-1; i > -1; i--)
{
    System.Console.Write($"{arr[i]} ");
}