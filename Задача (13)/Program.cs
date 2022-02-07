// Удалить вторую цифру трёхзначного числа
int a=0,m=1,s=2;
string b;
bool c = true;
Console.Clear();

Console.Write("Введите число: ");
b=Console.ReadLine();
a=Convert.ToInt32(b);

while (c == true)
{
    if (a>99 && a<1000)
    {
        while (s>1)
        {
            m*=10;
            s--;
        }
    int t = (a % m) + (a / (m * 10)) * m;
    System.Console.WriteLine(t);
    c = false;
    }
    else
    {
        System.Console.WriteLine("Введенное Вами число не может быть меньше 100  или превышать значение 999.");
        System.Console.Write("Введите число: ");
        b = Console.ReadLine();
        a = Convert.ToInt32(b);
    }
}
// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию");
// int s = Convert.ToInt32(Console.ReadLine());
// int m = 1;
// while (s > 1) 
// {
//     m *= 10;
//      s--;
// }
// int t = (x % m) + (x / (m * 10)) * m;
// Console.WriteLine(t);