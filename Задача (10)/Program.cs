// Показать последнюю цифру трёхзначного числа
double a=0;
string b;
bool c = true;
Console.Clear();

Console.Write("Введите число: ");
b=Console.ReadLine();
a=Convert.ToDouble(b);

while (c == true)
{
    if (a>99 && a<1000)
    {
        System.Console.WriteLine(a%10);
        c = false;
    }
    else
    {
        System.Console.WriteLine("Введенное Вами число не может быть меньше 100  или превышать значение 999.");
        System.Console.Write("Введите число: ");
        b = Console.ReadLine();
        a = Convert.ToDouble(b);
    }
}