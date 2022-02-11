// Показать кубы чисел, заканчивающихся на четную цифру
int a = 0;
double b = 0;
string c;
Console.Clear();
System.Console.WriteLine("Для завершения программы введите число 0.");
System.Console.WriteLine("Введите число: ");
c = Console.ReadLine();
a = Convert.ToInt32(c);

while (a!=0)
{
    if (a%2 == 0)
    {
        b = a*a*a;
        System.Console.WriteLine($"Куб числа {a} равен: {b}");
    }
    System.Console.WriteLine("Введите число: ");
    c = Console.ReadLine();
    a = Convert.ToInt32(c);
}