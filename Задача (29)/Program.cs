// Написать программу вычисления произведения чисел от 1 до N
int a = 0, b = 1;
string s;
Console.Clear();
System.Console.Write("Введите число: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

for (int index = 1; index <= a; index++)
{
    b = b * index;
    System.Console.WriteLine($"{b} * {index}");
}