// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a =0;
string b;
Console.Clear();
Console.Write("Введите день недели: ");
b=Console.ReadLine();
a=Convert.ToInt32(b);

string [] arrey = new string [7];

arrey[0]  = "Понедельник";
arrey[1] = "Вторник";
arrey[2] = "Среда";
arrey[3] = "Четверг";
arrey[4] = "Пятница";
arrey[5] = "Субота";
arrey[6] = "Воскресенье";

while (a>7)
{
    System.Console.WriteLine("Заданное вами число не может привышать 7");
    Console.Write("Введите день недели: ");
    b=Console.ReadLine();
    a=Convert.ToInt32(b);
}
int index = 0;
while (index<8)
{
    if (a==index && a<=5) System.Console.WriteLine($"вами введен рабочий день недели {arrey[index-1]}");
    if (a==index && a>5) System.Console.WriteLine($"вами введен выходной день недели {arrey[index-1]}");
    index++;
}
