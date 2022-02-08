// Дано число. Проверить кратно ли оно 7 и 23
int a=0;
string b;
Console.Clear();

Console.Write("Введите число: ");
b=Console.ReadLine();
a=Convert.ToInt32(b);

if (a%7==0 && a%23==0) System.Console.WriteLine("Заданное число кратно 7 и 23");
else
{
    if (a%7==0) System.Console.WriteLine("Заданное число кратно 7");
    if (a%23==0) System.Console.WriteLine("Заданное число кратно 23");
}
if (a%7!=0 && a%23!=0) System.Console.WriteLine("Заданное число не кратно 7 и 23");