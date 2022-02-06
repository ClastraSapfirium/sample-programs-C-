// Выяснить является ли число чётным
double a=0;
string b;
Console.Clear();
Console.Write("Vote number a:");
b=Console.ReadLine();
a=Convert.ToDouble(b);
if (a%2==0) System.Console.WriteLine("число четное");
else System.Console.WriteLine("Число нечетное");
