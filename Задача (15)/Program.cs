// Найти третью цифру числа или сообщить, что её нет
int a=0;
string b;
int asd = 0;
bool c = true;
Console.Clear();

Console.Write("Введите число: ");
b=Console.ReadLine();
a=Convert.ToInt32(b);

while (c == true)
{
    if (a>99)
    {
        while (a>1000)
        {
            a=a/10;
            asd=Convert.ToInt32(a);
        }
        System.Console.WriteLine($"Третья цифра с начала: {asd%10}");
        c = false;
    }
    else
    {
        System.Console.WriteLine("Введенное Вами число не имеет третью цифру");
        System.Console.Write("Введите число: ");
        b = Console.ReadLine();
        a = Convert.ToInt32(b);
    }
}
