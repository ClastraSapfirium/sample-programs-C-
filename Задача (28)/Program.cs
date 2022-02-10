// Подсчитать сумму цифр в числе
int a=0;
int sum = 0;
string c;
Console.Clear();

Console.Write("Введите число, сумму цифр которого хотите узнать: ");
c=Console.ReadLine();
a=Convert.ToInt32(c);

while (a>0)
{
    sum = sum + a%10;
    a=a/10;
}
System.Console.WriteLine($"Сумма цифр в числе составляет {sum}");