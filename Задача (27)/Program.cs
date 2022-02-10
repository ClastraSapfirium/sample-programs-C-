// Определить количество цифр в числе
int a=0;
int index = 0;
string c;
Console.Clear();

Console.Write("Введите число: ");
c=Console.ReadLine();
a=Convert.ToInt32(c);

while (a!=0)
{
    a=a/10;
    a=Convert.ToInt32(a);
    index++;
}
System.Console.WriteLine($"количество цифр в числе {index}");
