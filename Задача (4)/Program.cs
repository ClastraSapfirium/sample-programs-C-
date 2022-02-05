string [] a={"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
int b;
string c;
Console.Write("Vote day number:");
c=Console.ReadLine();
b=Convert.ToDouble(c);
if (1 <= b && b <= 7) System.Console.WriteLine(a[b]);
else System.Console.WriteLine("Ошибка ввода");
//Программа неработает