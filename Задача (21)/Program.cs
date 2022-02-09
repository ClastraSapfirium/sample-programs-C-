// Программа проверяет пятизначное число на палиндромом.
int a = 0;
string b;
System.Console.WriteLine("Введите пятизначное число ");
b = Console.ReadLine();
a = b.Length;
if(a == 5)
{
    int [] q = new int[a];
    for (int index = 0; index < a; index++)
    {
        q [index] = Convert.ToInt32(b[index]);
    }
    if(q[0] == q[4] && q[1] == q[3])
    {
        System.Console.WriteLine("Вами введено число полиндром");
    }
    else System.Console.WriteLine("Вами введено число не являющееся полиндромом");
}
else System.Console.WriteLine("Вами введено не пятизначное число");