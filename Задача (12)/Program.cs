// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
double a=0;
string b;
bool c = true;
Console.Clear();

Console.Write("Введите число: ");
b=Console.ReadLine();
a=Convert.ToDouble(b);

while (c == true)
{
    if (a>9 && a<100)
    {
        a=a%10;
        System.Console.WriteLine($"наибольшая цифра числа {a}");
        c = false;
    }
    else
    {
        System.Console.WriteLine("Введенное Вами число не может быть меньше 10  или превышать значение 99.");
        System.Console.Write("Введите число: ");
        b = Console.ReadLine();
        a = Convert.ToDouble(b);
    }
}